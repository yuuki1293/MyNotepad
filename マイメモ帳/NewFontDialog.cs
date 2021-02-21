using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace マイメモ帳
{
    public partial class NewFontDialog : Form
    {
        public NewFontDialog()
        {
            InitializeComponent();
        }

        private void NewFontDialog_Load(object sender, EventArgs e)
        {
            var fonts = new InstalledFontCollection();
            FontFamily[] ffArray = fonts.Families;
            foreach (var ff in ffArray)
                フォント名一覧.Items.Add(ff.Name);

            foreach (var str in new[] { "標準", "太字", "斜体", "太字 斜体" })
                スタイル一覧.Items.Add(str);

            int[] fontSize = {8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72};
            foreach (int i in fontSize)
                サイズ一覧.Items.Add(i);

        }

        private void フォント名一覧_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            string txt = ((ListBox)sender).Items[e.Index].ToString();
            Font font = new Font(txt, 10, FontStyle.Regular);
            e.Graphics.DrawString(txt,font,Brushes.Black,e.Bounds);
        }

        private void スタイル一覧_DrawItem(object sender, DrawItemEventArgs e)
        {
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
            Font font = new Font(Font.Name, 10, style);
            e.Graphics.DrawString(txt, font, Brushes.Black, e.Bounds);
        }

        private void サイズ一覧_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), new Font("Yu UI",10, FontStyle.Regular),Brushes.Black,e.Bounds);
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

    }
}
