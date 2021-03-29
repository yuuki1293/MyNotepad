using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace マイメモ帳
{
    public partial class 検索置換form : Form
    {
        public Action<string> 次を検索 { get; set; }
        public Action 次を検索正規表現 { get; set; }
        public Action CountWord { get; set; }
        public string SearchText { get; set; }

        public 検索置換form()
        {
            InitializeComponent();
        }

        private void 検索置換form_Load(object sender, System.EventArgs e)
        {
            FormBorderStyle = MainForm.Data.ShowTitleBar ? FormBorderStyle.FixedSingle : FormBorderStyle.None;
        }

        private void 次を検索button_Click(object sender, System.EventArgs e)
        {
            次を検索(SearchText);
        }

        private void 前を検索button_Click(object sender, System.EventArgs e)
        {

        }

        private void 置換して次にbutton_Click(object sender, System.EventArgs e)
        {

        }

        private void 置換して前にbutton_Click(object sender, System.EventArgs e)
        {

        }

        private void 全て置換button_Click(object sender, System.EventArgs e)
        {

        }

        private void キャンセルbutton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void 検索する文字列textBox_TextChanged(object sender, EventArgs e)
        {
            SearchText = 検索する文字列textBox.Text;
        }
    }
}
