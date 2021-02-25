﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace マイメモ帳
{
    public partial class MainForm : Form
    {
        private string SavedText { get; set; } = "";
        private string _title;

        public string SetTitle
        {
            set
            {
                SavedText = text.Text;
                FilePath = value;
                _title = Path.GetFileName(FilePath);
                Text = SetTitle;
            }
            get
            {
                if (SavedText == text.Text)
                {
                    return $"{_title} - マイメモ帳";
                }
                else
                {
                    return $"*{_title} - マイメモ帳";
                }
            }
        }
        private string FilePath { get; set; }
        private PageSetupDialog PageSetupDialog { get; set; } = new PageSetupDialog();
        private TextHistory TextHistory { get; set; }
        public static Data Data { get; set; } = new Data();

        internal MainForm(IReadOnlyList<string> argv)
        {
            InitializeComponent();
            MessageBox.Show(argv[0]);
            if (argv.Count > 0)
            {
                SetTitle = String.Join(" ",argv);
                text.Text = File.ReadAllText(FilePath);
            }
            else
            {
                _title = "無題";
                Text = SetTitle;
            }
        }

        internal void ColorChange()
        {
            Color Set(string name)
            {
                var colorBaf = Convert.ToInt32(Value.Color.Default.ResourceManager.GetString(name), 16);
                return Color.FromArgb(colorBaf);
            }

            text.ForeColor = Set("textForeColor");
            text.BackColor = Set("textBackColor");
            menuStrip.ForeColor = Set("menuStripForeColor");
            menuStrip.BackColor = Set("menuStripBackColor");
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        //保存するor保存しない：0　キャンセル：-1
        private int 保存しますか()
        {
            if (!SavedText.Equals(text.Text))
            {
                CustomMessageBoxInfo customMessageBoxInfo = new CustomMessageBoxInfo
                {
                    Message = $"{_title} への変更内容を保存しますか?",
                    Choose = new[] { "　保存する(&H)　", "　保存しない(&N)　", "　キャンセル　" },
                    Title = "マイメモ帳",
                    CancelChoose = 2
                };
                CustomDialogBox form = new CustomDialogBox(customMessageBoxInfo);
                form.ShowDialog();
                form.Dispose();
                if (customMessageBoxInfo.Result == 0)
                {
                    if (FilePath == null)
                    {
                        if (名前を付けて保存ToolStripMenuItem_Click() == 0) { return 0; }
                        else { return -1; }
                    }
                    else { File.WriteAllText(FilePath, text.Text); }
                }
                else if (customMessageBoxInfo.Result == 2) { return -1; }
            }
            return 0;
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (保存しますか() == 0)
            {
                OpenFile();
                TextHistory.Reset();
                もとに戻すUToolStripMenuItem.Enabled = false;
            }
        }

        private void OpenFile()
        {
            OpenFileDialog dialog = new OpenFileDialog { Title = @"開く" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                text.Text = File.ReadAllText(dialog.FileName, Encoding.UTF8);
                SetTitle = dialog.FileName;
            }
        }

        private void 名前を付けて保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            名前を付けて保存ToolStripMenuItem_Click();
        }

        private int 名前を付けて保存ToolStripMenuItem_Click()
        {
            SaveFileDialog dialog = new SaveFileDialog { Title = @"名前を付けて保存" };
            //dialog.Filter = "テキストファイル(*.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, text.Text);
                SetTitle = dialog.FileName;
                return 0;
            }
            else { return -1; }
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void もとに戻すUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextHistory.Undo();
            もとに戻すUToolStripMenuItem.Enabled = TextHistory.CanUndo;
        }

        private void 新規toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (保存しますか() == 0)
            {
                SavedText = "";
                _title = "無題";
                FilePath = null;
                text.Text = "";
                Text = SetTitle;
                TextHistory.Reset();
            }
        }

        private void 新しいウィンドウtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start(AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\') + "\\マイメモ帳.exe");
        }

        private void 上書き保存toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (FilePath == null)
            {
                名前を付けて保存ToolStripMenuItem_Click();
            }
            else
            {
                File.WriteAllText(FilePath, text.Text);
                SetTitle = FilePath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Data = Data.Load();
            text.Font = Data.TextFont;
            TextHistory = new TextHistory(text);
            ColorChange();
            if (!Data.ShowTitleBar) FormBorderStyle = FormBorderStyle.None;
            else タイトルバーTToolStripMenuItem.Checked = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (保存しますか() != 0)
            {
                e.Cancel = true;
            }
            Data.Save();
        }

        private void Txt_memo_TextChanged(object sender, EventArgs e)
        {
            if (TextHistory == null) return;
            if (!TextHistory.UseUndoRedo)
            {
                TextHistory.Add();
            }
            Text = SetTitle;
            もとに戻すUToolStripMenuItem.Enabled = TextHistory.CanUndo;
            やり直すYToolStripMenuItem.Enabled = TextHistory.CanRedo;
        }

        private void ページ設定toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1 = PageSetupDialog;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                PageSetupDialog = pageSetupDialog1;
            }
            pageSetupDialog1.Dispose();
        }

        private void 印刷toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument.DocumentName = SetTitle;
                printDocument.PrinterSettings = printDialog1.PrinterSettings;
                printDocument.DefaultPageSettings = PageSetupDialog.PageSettings;
                printDocument.Print();
            }
        }

        private void やり直すYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextHistory.Redo();
            やり直すYToolStripMenuItem.Enabled = TextHistory.CanRedo;
        }

        private void フィードバックを送信FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/yuuki1293/MyNotepad/issues/new");
        }

        private void 右端で折り返すWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (右端で折り返すWToolStripMenuItem.Checked)
            {
                text.WordWrap = false;
                右端で折り返すWToolStripMenuItem.Checked = false;
            }
            else
            {
                text.WordWrap = true;
                右端で折り返すWToolStripMenuItem.Checked = true;
            }
        }

        private void すべて選択AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.SelectionStart = 0;
            text.SelectionLength = text.Text.Length;
        }

        private void フォントFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFontDialog newFontDialog = new NewFontDialog { Font = text.Font, Data = Data };
            if (newFontDialog.ShowDialog() == DialogResult.OK)
            {
                text.Font = newFontDialog.Font;
                Data.TextFont = text.Font;
            }

            newFontDialog.Dispose();
            // MessageBox.Show(fontDialog.Font.Name);
        }

        private void 切り取りCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int start = text.SelectionStart;
            var clipboardText = text.Text.Substring(start, text.SelectionLength);
            Clipboard.SetText(clipboardText);
            text.Text = text.Text.Remove(start, text.SelectionLength);
            text.SelectionStart = start;
            text.SelectionLength = 0;
        }

        private void コピーCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clipboardText = text.Text.Substring(text.SelectionStart, text.SelectionLength);
            Clipboard.SetText(clipboardText);
        }

        private void 貼り付けPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var start = text.SelectionStart;
            text.Text = text.Text.Remove(start, text.SelectionLength);
            var clipboardText = Clipboard.GetText();
            text.Text = text.Text.Insert(start, clipboardText);
            text.SelectionStart = start + clipboardText.Length;
            text.SelectionLength = 0;
        }

        private void 削除LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var start = text.SelectionStart;
            text.Text = text.Text.Remove(start, text.SelectionLength);
            text.SelectionStart = start;
            text.SelectionLength = 0;
        }

        private void Text_MouseClick(object sender, MouseEventArgs e)
        {
            TextSelectedCheck();
        }

        private void TextSelectedCheck()
        {
            if (text.SelectionLength == 0)
            {
                切り取りTToolStripMenuItem.Enabled = false;
                コピーCToolStripMenuItem.Enabled = false;
                削除LToolStripMenuItem.Enabled = false;
                bingで検索SToolStripMenuItem.Enabled = false;
            }
            else
            {
                切り取りTToolStripMenuItem.Enabled = true;
                コピーCToolStripMenuItem.Enabled = true;
                削除LToolStripMenuItem.Enabled = true;
                bingで検索SToolStripMenuItem.Enabled = true;
            }
        }

        private void タイトルバーTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (タイトルバーTToolStripMenuItem.Checked == false)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                タイトルバーTToolStripMenuItem.Checked = true;
                Data.ShowTitleBar = true;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
                タイトルバーTToolStripMenuItem.Checked = false;
                Data.ShowTitleBar = false;
            }
        }

        private void bingで検索SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start($@"https://www.bing.com/search?q={text.Text.Substring(text.SelectionStart, text.SelectionLength)}");
        }

        private void text_KeyUp(object sender, KeyEventArgs e)
        {
            TextSelectedCheck();
        }

        private void 色CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            色 form1 = new 色();
            form1.ShowDialog();
            form1.Dispose();
        }
    }

    internal class TextHistory
    {
        private List<string> History { get; set; } = new List<string>();
        private int HistoryNum { get; set; }
        private TextBox TxtMemo { get; }
        private List<int> CursorStartPosition { get; set; } = new List<int>();
        private List<int> CursorLengthPosition { get; set; } = new List<int>();

        public bool UseUndoRedo { get; set; } = false;
        public bool CanUndo => HistoryNum > 0;
        public bool CanRedo => HistoryNum != History.Count - 1;

        public TextHistory(TextBox txtMemo)
        {
            TxtMemo = txtMemo;
            Reset();
        }

        public void Add()
        {
            //txt_memo.Text = "Addされたよ！";
            if (HistoryNum != History.Count - 1)
            {
                History.RemoveRange(HistoryNum + 1, History.Count - 1 - HistoryNum);
            }
            History.Add(TxtMemo.Text);
            CursorStartPosition.Add(TxtMemo.SelectionStart);
            CursorLengthPosition.Add(TxtMemo.SelectionLength);
            HistoryNum++;
        }

        public void Reset()
        {
            History = new List<string> { TxtMemo.Text };
            CursorStartPosition = new List<int> { TxtMemo.SelectionStart };
            CursorLengthPosition = new List<int> { TxtMemo.SelectionLength };
            HistoryNum = 0;
            UseUndoRedo = false;
        }

        public int Undo()
        {
            if (HistoryNum == 0) { return -1; }
            else
            {
                UseUndoRedo = true;
                TxtMemo.Text = History[--HistoryNum];
                TxtMemo.SelectionStart = CursorStartPosition[HistoryNum];
                TxtMemo.SelectionLength = CursorLengthPosition[HistoryNum];
                UseUndoRedo = false;
                return 0;
            }
        }

        public int Redo()
        {
            //MessageBox.Show(historyNum.ToString());
            //MessageBox.Show(history.Count.ToString());
            if (HistoryNum == History.Count - 1) { return 0; }
            else
            {
                UseUndoRedo = true;
                TxtMemo.Text = History[++HistoryNum];
                TxtMemo.SelectionStart = CursorStartPosition[HistoryNum];
                TxtMemo.SelectionLength = CursorLengthPosition[HistoryNum];
                UseUndoRedo = false;
                return 0;
            }
        }
    }

}


