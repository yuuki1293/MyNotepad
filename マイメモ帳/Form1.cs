using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace マイメモ帳
{
    public partial class Form1 : Form
    {
        private string savedText { get; set; } = "";
        private string title { get; set; } = "無題";
        private string filePath { get; set; }

        public Form1(string[] argv)
        {
            InitializeComponent();
            if (argv.Length > 0)
            {
                txt_memo.Text = File.ReadAllText(argv[0]);
                savedText = txt_memo.Text;
                filePath = argv[0];
            }
        }
        
        //保存するor保存しない：0　キャンセル：-1
        private int 保存しますか()
        {
            if (!savedText.Equals(txt_memo.Text))
            {
                CustomMassegeBoxInfo customMassegeBoxInfo = new CustomMassegeBoxInfo
                {
                    message = $"{this.title} への変更内容を保存しますか?",
                    choose = new string[] { "　保存する(&H)　", "　保存しない(&N)　", "　キャンセル　" },
                    title = "マイメモ帳",
                    CancelChoose = 2
                };
                Form2 form = new Form2(customMassegeBoxInfo);
                form.ShowDialog();
                customMassegeBoxInfo.result = form.result;
                form.Dispose();
                //MessageBox.Show(customMassegeBoxInfo.result.ToString());
                if (customMassegeBoxInfo.result == 0)
                {
                    if (filePath == null) { 名前を付けて保存ToolStripMenuItem_Click(new object(), new EventArgs()); }
                    else
                    {
                        File.WriteAllText(filePath, txt_memo.Text);
                    }
                }
                else if (customMassegeBoxInfo.result == 2) { return -1; }
            }
            return 0;
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (保存しますか() == 0) { openFile(); }
        }

        private void openFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "開く";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txt_memo.Text = File.ReadAllText(dialog.FileName, Encoding.UTF8);
                savedText = txt_memo.Text;
                filePath = dialog.FileName;
            }
        }

        private void 名前を付けて保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            //dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "名前を付けて保存";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, txt_memo.Text);
            }
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("メモ帳を終了します", "終了", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void もとに戻すUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ファイルToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 新規toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (保存しますか() == 0)
            {
                savedText = "";
                title = "無題";
                filePath = null;
                txt_memo.Text = "";
            } 
        }

        private void 新しいウィンドウtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start(AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\')+ "\\マイメモ帳.exe");
        }
    }
}
