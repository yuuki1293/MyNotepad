using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace マイメモ帳
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "開く";
            if (dialog.ShowDialog() == DialogResult.OK) {
                txt_memo.Text = File.ReadAllText(dialog.FileName, Encoding.UTF8);
            } 
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "保存";
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
            CustomMassegeBoxInfo customMassegeBoxInfo = new CustomMassegeBoxInfo
            {
                title = "メモ帳",
                choose = new string[] { "はい", "いいえ", "キャンセル" },
                message="保存しますか",
            };
            
            //DialogResult dr = MessageBox.Show("本当によろしいですか？", "確認", MessageBoxButtons.YesNoCancel);
            Form2 form = new Form2(ref customMassegeBoxInfo);
            if (form.ShowDialog() == DialogResult.OK)
            {
                
            }
            form.Dispose();
            customMassegeBoxInfo
        }
    }
}
