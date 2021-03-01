using System;
using System.Drawing;
using System.Windows.Forms;

namespace マイメモ帳
{
    public partial class 色 : Form
    {
        public 色()
        {
            InitializeComponent();
        }

        private void 色_Load(object sender, System.EventArgs e)
        {
            ColorChange();
        }

        internal void ColorChange()
        {
            var textForeColor = new ColorSelectDialog {Text = @"テキストボックスの文字色", ColorName ="textForeColor", Location = new Point(10, 10)};
            Controls.Add(textForeColor);
        }
    }
}
