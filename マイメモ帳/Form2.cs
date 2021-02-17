using System;
using System.Drawing;
using System.Windows.Forms;

namespace マイメモ帳
{
    public partial class Form2 : Form
    {
        public int result { get; set; }

        public Form2(CustomMassegeBoxInfo info)
        {
            InitializeComponent();
            Text = info.title;
            ShowIcon = info.showicon;
            label1.Text = info.message;
            label1.ForeColor = info.messageColor;
            label1.Font = info.messageFont;
            label1.Location = new Point(Location.X + 10, 20);
            result = info.CancelChoose;
            Button[] button = new Button[info.choose.Length];

            for (int i = info.choose.Length - 1; i >= 0; i--)
            {
                button[i] = new Button
                {
                    Text = info.choose[i],
                    AutoSize = true,
                    AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly,
                    Name = i.ToString(),
                    Font = info.chooseFont,
                };
                panel1.Controls.Add(button[i]);
                if (i == info.choose.Length - 1)
                {
                    button[i].Location = new Point(panel1.Width - 20 - button[i].Width, (panel1.Height - button[i].Height) / 2);
                }
                else
                {
                    button[i].Location = new Point(button[i + 1].Location.X - 10 - button[i].Width, (panel1.Height - button[i].Height) / 2);
                }
                //MessageBox.Show(button[i].Size.ToString());
                button[i].Click += new EventHandler(ButtonClick);
                button[i].BringToFront();
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            result = int.Parse(button.Name);
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
