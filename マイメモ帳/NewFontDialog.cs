using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;

namespace マイメモ帳
{
    public partial class NewFontDialog : Form
    {
        private Dictionary<FontStyle, string> FontStyleToString { get; } = new(){
            { FontStyle.Regular,"標準" },
            { FontStyle.Bold,"太字" },
            { FontStyle.Italic,"斜体" },
            { (FontStyle.Bold|FontStyle.Italic),"太字 斜体" }
        };
        private bool FinLoad { get; set; }
        private SolidBrush ForeBrushes { get; set; }

        public Data Data { get; set; }

        public NewFontDialog()
        {
            InitializeComponent();
        }

        internal void ColorChange()
        {
            BackColor = MainForm.Set("formBackColor",Color.FromArgb(unchecked((int) 0xFFF0F0F0)));
            ForeColor = MainForm.Set("formForeColor",Color.Black);
            フォント名一覧.BackColor = MainForm.Set("textBackColor",Color.White);
            スタイル一覧.BackColor = MainForm.Set("textBackColor",Color.White);
            サイズ一覧.BackColor = MainForm.Set("textBackColor",Color.White);
            ForeBrushes = new SolidBrush(MainForm.Set("textForeColor",Color.Black));
            textBox1.BackColor = MainForm.Set("textBackColor",Color.White);
            textBox2.BackColor = MainForm.Set("textBackColor",Color.White);
            textBox3.BackColor = MainForm.Set("textBackColor",Color.White);
            textBox1.ForeColor = MainForm.Set("textForeColor",Color.Black);
            textBox2.ForeColor = MainForm.Set("textForeColor",Color.Black);
            textBox3.ForeColor = MainForm.Set("textForeColor",Color.Black);
            OKボタン.BackColor = MainForm.Set("buttonBackColor",Color.FromArgb(unchecked((int) 0xFFE1E1E1)));
            OKボタン.ForeColor = MainForm.Set("buttonForeColor",Color.Black);
            キャンセルボタン.BackColor = MainForm.Set("buttonBackColor",Color.FromArgb(unchecked((int) 0xFFE1E1E1)));
            キャンセルボタン.ForeColor = MainForm.Set("buttonForeColor",Color.Black);
            サンプルテキスト.BackColor = MainForm.Set("textBackColor",Color.White);
            サンプルテキスト.ForeColor = MainForm.Set("textForeColor",Color.Black);
        }

        private void NewFontDialog_Load(object sender, EventArgs e)
        {
            ColorChange();
            if (!Data.ShowTitleBar) FormBorderStyle = FormBorderStyle.None;

            var fonts = new InstalledFontCollection();
            FontFamily[] ffArray = fonts.Families;
            foreach (var ff in ffArray)
                フォント名一覧.Items.Add(ff.Name);
            フォント名一覧.SelectedItem = Font.Name;
            
            foreach (var str in new[] { "標準", "太字", "斜体", "太字 斜体" })
                スタイル一覧.Items.Add(str);
            スタイル一覧.SelectedItem = FontStyleToString[Font.Style];
            
            float[] fontSize = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var i in fontSize)
                サイズ一覧.Items.Add(i);
            サイズ一覧.SelectedItem = Font.Size;
            
            int locationListBox = textBox1.Location.Y + textBox1.Size.Height;
            フォント名一覧.Location = new Point(フォント名一覧.Location.X, locationListBox);
            スタイル一覧.Location = new Point(スタイル一覧.Location.X, locationListBox);
            サイズ一覧.Location = new Point(サイズ一覧.Location.X, locationListBox);

            textBox1.Text = Font.Name;
            textBox2.Text = FontStyleToString[Font.Style];
            textBox3.Text = Font.Size.ToString(CultureInfo.InvariantCulture);

            FinLoad = true;
        }

        private void フォント名一覧_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            string txt = ((ListBox)sender).Items[e.Index].ToString();
            Font font = new Font(txt, 11, Font.Style);
            e.Graphics.DrawString(txt, font, ForeBrushes, e.Bounds);
        }

        private void スタイル一覧_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) return;
            e.DrawBackground();

            string txt = ((ListBox)sender).Items[e.Index].ToString();
            FontStyle style;
            switch (txt)
            {
                case "標準":
                    style = FontStyle.Regular;
                    break;
                case "太字":
                    style = FontStyle.Bold;
                    break;
                case "斜体":
                    style = FontStyle.Italic;
                    break;
                default:
                    style = (FontStyle.Italic | FontStyle.Bold);
                    break;
            }
            Font font = new Font(Font.Name, 11, style);
            e.Graphics.DrawString(txt, font, ForeBrushes, e.Bounds);
        }

        private void サイズ一覧_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), new Font("Yu UI", 11, FontStyle.Regular), ForeBrushes, e.Bounds);
        }

        private void OKボタン_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void キャンセルボタン_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void 他のフォントを表示_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c start ms-settings:fonts")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(processStartInfo);
        }

        private void SelectedValueChanged(object sender, EventArgs e)
        {
            if (フォント名一覧.SelectedItem == null || !FinLoad) return;
            FinLoad = false;
            var fontName = フォント名一覧.SelectedItem.ToString();
            var fontSize = (float)サイズ一覧.SelectedItem;
            FontStyle fontStyle;
            switch (スタイル一覧.SelectedItem.ToString())
            {
                case "標準":
                    fontStyle = FontStyle.Regular;
                    break;
                case "太字":
                    fontStyle = FontStyle.Bold;
                    break;
                case "斜体":
                    fontStyle = FontStyle.Italic;
                    break;
                default:
                    fontStyle = (FontStyle.Italic | FontStyle.Bold);
                    break;
            }

            textBox1.Text = fontName;
            textBox2.Text = FontStyleToString[fontStyle];
            textBox3.Text = fontSize.ToString(CultureInfo.InvariantCulture);
            Font = new Font(fontName, fontSize, fontStyle);
            サンプルテキスト.Font = Font;

            スタイル一覧.Items.Clear();
            foreach (var str in new[] { "標準", "太字", "斜体", "太字 斜体" })
                スタイル一覧.Items.Add(str);
            //スタイル一覧_DrawItem("標準",drawItemEventArgs);
            スタイル一覧.SelectedItem = FontStyleToString[Font.Style];
            FinLoad = true;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!FinLoad) return;
            FinLoad = false;
            var find = フォント名一覧.FindString(textBox1.Text);
            if (find != ListBox.NoMatches)
            {
                フォント名一覧.SelectedItem = フォント名一覧.Items[find];
                var fontName = フォント名一覧.SelectedItem.ToString();
                Font = new Font(fontName, Font.Size, Font.Style);
                サンプルテキスト.Font = Font;
            }
            else
            {
                フォント名一覧.SelectedItem = フォント名一覧.Items[0];
                フォント名一覧.SelectedItem = null;
            }

            FinLoad = true;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!FinLoad) return;
            FinLoad = false;
            var find = スタイル一覧.FindString(textBox2.Text);
            if (find != ListBox.NoMatches)
            {
                スタイル一覧.SelectedItem = スタイル一覧.Items[find]; 
                FontStyle fontStyle;
                switch (スタイル一覧.SelectedItem.ToString())
                {
                    case "標準":
                        fontStyle = FontStyle.Regular;
                        break;
                    case "太字":
                        fontStyle = FontStyle.Bold;
                        break;
                    case "斜体":
                        fontStyle = FontStyle.Italic;
                        break;
                    default:
                        fontStyle = (FontStyle.Italic | FontStyle.Bold);
                        break;
                }
                Font = new Font(Font.Name, Font.Size, fontStyle);
                サンプルテキスト.Font = Font;
            }
            else
            {
                スタイル一覧.SelectedItem = スタイル一覧.Items[0];
                スタイル一覧.SelectedItem = null;
            }

            FinLoad = true;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (!FinLoad) return;
            FinLoad = false;
            var find = サイズ一覧.FindString(textBox3.Text);
            if (find != ListBox.NoMatches)
            {
                サイズ一覧.SelectedItem = サイズ一覧.Items[find];
                var fontSize = (float)サイズ一覧.SelectedItem;
                Font = new Font(Font.Name, fontSize, Font.Style);
                サンプルテキスト.Font = Font;
            }
            else
            {
                サイズ一覧.SelectedItem = サイズ一覧.Items[0];
                サイズ一覧.SelectedItem = null;
            }

            FinLoad = true;
        }
    }
}
