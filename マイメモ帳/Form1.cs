using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace マイメモ帳
{
    public partial class Form1 : Form
    {
        private string SavedText { get; set; } = "";
        private string Title;
        private string SetTitle
        {
            set
            {
                SavedText = txt_memo.Text;
                FilePath = value;
                Title = Path.GetFileName(FilePath);
                Text = SetTitle;
            }
            get
            {
                if (SavedText == txt_memo.Text)
                {
                    return $"{Title} - マイメモ帳";
                }
                else
                {
                    return $"*{Title} - マイメモ帳";
                }
            }
        }
        private string FilePath { get; set; }
        private PageSetupDialog PageSetupDialog { get; set; } = new PageSetupDialog();
        private TextHistory TextHistory { get; set; }

        static public XElement xml { get; set; }

        public Form1(string[] argv)
        {
            InitializeComponent();
            if (argv.Length > 0)
            {
                txt_memo.Text = File.ReadAllText(argv[0]);
                SetTitle = argv[0];
            }
            else
            {
                Title = "無題";
                Text = SetTitle;
            }
            //BackColor = System.Drawing.Color.FromArgb();
        }

        //保存するor保存しない：0　キャンセル：-1
        private int 保存しますか()
        {
            if (!SavedText.Equals(txt_memo.Text))
            {
                CustomMassegeBoxInfo customMassegeBoxInfo = new CustomMassegeBoxInfo
                {
                    message = $"{Title} への変更内容を保存しますか?",
                    choose = new string[] { "　保存する(&H)　", "　保存しない(&N)　", "　キャンセル　" },
                    title = "マイメモ帳",
                    CancelChoose = 2
                };
                CustomDialogBox form = new CustomDialogBox(customMassegeBoxInfo);
                form.ShowDialog();
                form.Dispose();
                //MessageBox.Show(customMassegeBoxInfo.result.ToString());
                if (customMassegeBoxInfo.result == 0)
                {
                    if (FilePath == null)
                    {
                        if (名前を付けて保存ToolStripMenuItem_Click() == 0) { return 0; }
                        else { return -1; }
                    }
                    else { File.WriteAllText(FilePath, txt_memo.Text); }
                }
                else if (customMassegeBoxInfo.result == 2) { return -1; }
            }
            return 0;
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (保存しますか() == 0)
            {
                openFile();
                TextHistory.Reset();
            }
        }

        private void openFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "開く";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txt_memo.Text = File.ReadAllText(dialog.FileName, Encoding.UTF8);
                SetTitle = dialog.FileName;
            }
        }

        private void 名前を付けて保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            名前を付けて保存ToolStripMenuItem_Click();
        }

        private int 名前を付けて保存ToolStripMenuItem_Click()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            //dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "名前を付けて保存";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, txt_memo.Text);
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
            if (TextHistory.CanUndo) { もとに戻すUToolStripMenuItem.Enabled = true; }
            else { もとに戻すUToolStripMenuItem.Enabled = false; }
        }

        private void 新規toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (保存しますか() == 0)
            {
                SavedText = "";
                Title = "無題";
                FilePath = null;
                txt_memo.Text = "";
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
                File.WriteAllText(FilePath, txt_memo.Text);
                SetTitle = FilePath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextHistory = new TextHistory(txt_memo);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (保存しますか() != 0)
            {
                e.Cancel = true;
            }
        }

        private void txt_memo_TextChanged(object sender, EventArgs e)
        {
            if (!TextHistory.UseUndoRedo)
            {
                TextHistory.Add();
            }
            Text = SetTitle;
            if (TextHistory.CanUndo) { もとに戻すUToolStripMenuItem.Enabled = true; }
            else { もとに戻すUToolStripMenuItem.Enabled = false; }
            if (TextHistory.CanRedo) { やり直すYToolStripMenuItem.Enabled = true; }
            else { やり直すYToolStripMenuItem.Enabled = false; }
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
            if (TextHistory.CanRedo) { やり直すYToolStripMenuItem.Enabled = true; }
            else { やり直すYToolStripMenuItem.Enabled = false; }
        }

        private void Txt_memo_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(txt_memo.SelectionStart.ToString());
        }

        private void フィードバックを送信FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/yuuki1293/MyNotepad/issues/new");
        }
    }

    public class TextHistory
    {
        private List<string> History { get; set; } = new List<string>();
        private int HistoryNum { get; set; } = 0;
        private TextBox Txt_memo { get; set; }
        private List<int> CursorStartPosition { get; set; } = new List<int>();
        private List<int> CursorLengthPosition { get; set; } = new List<int>();

        public bool UseUndoRedo { get; set; } = false;
        public bool CanUndo { get { return HistoryNum != 0; } }
        public bool CanRedo { get { return HistoryNum != History.Count - 1; } }

        public TextHistory(TextBox txt_memo)
        {
            Txt_memo = txt_memo;
            Reset();
        }

        public void Add()
        {
            //txt_memo.Text = "Addされたよ！";
            if (HistoryNum != History.Count - 1)
            {
                History.RemoveRange(HistoryNum + 1, History.Count - 1 - HistoryNum);
            }
            History.Add(Txt_memo.Text);
            CursorStartPosition.Add(Txt_memo.SelectionStart);
            CursorLengthPosition.Add(Txt_memo.SelectionLength);
            HistoryNum++;
        }

        public void Reset()
        {
            History = new List<string> { Txt_memo.Text };
            CursorStartPosition = new List<int> { Txt_memo.SelectionStart };
            CursorLengthPosition = new List<int> { Txt_memo.SelectionLength };
            HistoryNum = 0;
            UseUndoRedo = false;
        }

        public int Undo()
        {
            if (HistoryNum == 0) { return -1; }
            else
            {
                UseUndoRedo = true;
                Txt_memo.Text = History[--HistoryNum];
                Txt_memo.SelectionStart = CursorStartPosition[HistoryNum];
                Txt_memo.SelectionLength = CursorLengthPosition[HistoryNum];
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
                Txt_memo.Text = History[++HistoryNum];
                Txt_memo.SelectionStart = CursorStartPosition[HistoryNum];
                Txt_memo.SelectionLength = CursorLengthPosition[HistoryNum];
                UseUndoRedo = false;
                return 0;
            }
        }
    }
}


