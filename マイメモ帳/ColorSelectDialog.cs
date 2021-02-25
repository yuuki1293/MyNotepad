using System;
using System.Drawing;
using System.Windows.Forms;

namespace マイメモ帳
{
    public partial class ColorSelectDialog : UserControl
    {
        internal Color Color { get; set; }

        public ColorSelectDialog()
        {
            InitializeComponent();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Color;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color = colorDialog1.Color;
                ColorButton.BackColor = Color;
                maskedTextBoxHex.Text = Color.ToArgb().ToString("X");
            }
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            var keyPressCk = !(('A' <= e.KeyValue && e.KeyValue <= 'F') // A～F
                               || ('0' <= e.KeyValue && e.KeyValue <= '9') // 0～9 (キーボード)
                               || ((int)Keys.NumPad0 <= e.KeyValue && e.KeyValue <= (int)Keys.NumPad9) // 1～9(テンキー) 
                               || ((int)Keys.Left == e.KeyValue || (int)Keys.Right == e.KeyValue));

            // [KeyDown]後の[KeyPress]イベント
            e.SuppressKeyPress = keyPressCk; // true = 無効 / false = 許可
        }

        private void ColorSelectDialog_Load(object sender, EventArgs e)
        {
            ColorButton.BackColor = Color;
            label1.Text = Text;
        }
    }
}
