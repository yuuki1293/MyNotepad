using System;
using System.Collections.Generic;
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
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;
            Color = colorDialog1.Color;
            ColorButton.BackColor = Color;
            maskedTextBox.Text = Convert.ToString(Color.ToArgb(),16);
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Color = Color.FromArgb(Convert.ToInt32(maskedTextBox.Text.Replace(" ",""),16));
                ColorButton.BackColor = Color;
            }
            else
            {
                var keyPressCk = !(('A' <= e.KeyValue && e.KeyValue <= 'F') // A～F
                                   || ('0' <= e.KeyValue && e.KeyValue <= '9') // 0～9 (キーボード)
                                   || ((int) Keys.NumPad0 <= e.KeyValue &&
                                       e.KeyValue <= (int) Keys.NumPad9) // 1～9(テンキー) 
                                   || ((int) Keys.Left == e.KeyValue || (int) Keys.Right == e.KeyValue));

                // [KeyDown]後の[KeyPress]イベント
                e.SuppressKeyPress = keyPressCk; // true = 無効 / false = 許可
            }
        }

        private void ColorSelectDialog_Load(object sender, EventArgs e)
        {
            ColorButton.BackColor = Color;
            label1.Text = Text;
            maskedTextBox.Text = Convert.ToString(Color.ToArgb(),16);
            BackColor = MainForm.Set("formBackColor",Color.FromArgb(unchecked((int) 0xFFf0f0f0)));
            ForeColor = MainForm.Set("formForeColor",Color.Black);
            label1.ForeColor = MainForm.Set("formForeColor",Color.Black);
            maskedTextBox.BackColor = MainForm.Set("textBackColor",Color.White);
            maskedTextBox.ForeColor = MainForm.Set("textForeColor",Color.Black);
        }
    }
}
