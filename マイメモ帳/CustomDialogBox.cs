using System;
using System.Drawing;
using System.Windows.Forms;

namespace マイメモ帳
{
    public partial class CustomDialogBox : Form
    {
        private Button[] button { get; set; }
        CustomMassegeBoxInfo info{get;set;}
        public new int DialogResult { get; set; }

        public CustomDialogBox(CustomMassegeBoxInfo info)
        {
            InitializeComponent();
            this.info = info;
            Text = info.title;
            ShowIcon = info.showicon;
            label1.Text = info.message;
            label1.ForeColor = info.messageColor;
            label1.Font = info.messageFont;
            label1.Location = new Point(Location.X + 10, 20);
            info.result = info.CancelChoose;
            button = new Button[info.choose.Length];

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
            if (button[0].Location.X < 30)
            {
                int dx = 30 - button[0].Location.X;
                Width += dx;
                for (int i = 0; i < button.Length; i++)
                {
                    button[i].Location = new Point(button[i].Location.X + dx, button[i].Location.Y);
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            info.result = int.Parse(button.Name);
            Close();
        }

    }
}
