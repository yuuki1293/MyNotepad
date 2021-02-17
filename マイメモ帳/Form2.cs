using System;
using System.Drawing;
using System.Windows.Forms;

namespace マイメモ帳
{
    public partial class Form2 : Form
    {
        public int result { get; set; }
        private int buttonLength { get; set; }

        public Form2(CustomMassegeBoxInfo info)
        {
            InitializeComponent();
            Text = info.title;
            ShowIcon = info.showicon;
            label1.Text = info.message;
            label1.Font = info.messageFont;
            result = info.defaultChoose;
            Button[] button = new Button[info.choose.Length];

            for (int i = 0; i < info.choose.Length; i++)
            {
                button[i] = new Button
                {
                    Anchor = (AnchorStyles.Bottom | AnchorStyles.Right),
                    Text = info.choose[i],
                    AutoSize = true,
                    AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly,
                    Name = i.ToString(),
                    Font = info.chooseFont,
                };
                panel1.Controls.Add(button[i]);
                if (i == 0)
                {
                    button[i].Location = new Point(30, (panel1.Height - button[i].Height) / 2);
                }
                else
                {
                    button[i].Location = new Point(30 + button[i - 1].Location.X + button[i - 1].Width, (panel1.Height - button[i].Height) / 2);
                }
                MessageBox.Show(button[i].Size.ToString());
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
