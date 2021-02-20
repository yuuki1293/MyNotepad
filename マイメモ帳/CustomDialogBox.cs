using System;
using System.Drawing;
using System.Windows.Forms;

namespace マイメモ帳
{
    public partial class CustomDialogBox : Form
    {
        private Button[] Button { get; }
        private CustomMessageBoxInfo Info{get; }

        public CustomDialogBox(CustomMessageBoxInfo info)
        {
            InitializeComponent();
            Info = info;
            Text = info.Title;
            ShowIcon = info.ShowIcon;
            label1.Text = info.Message;
            label1.ForeColor = info.MessageColor;
            label1.Font = info.MessageFont;
            label1.Location = new Point(Location.X + 10, 20);
            info.Result = info.CancelChoose;
            Button = new Button[info.Choose.Length];

            for (var i = info.Choose.Length - 1; i >= 0; i--)
            {
                Button[i] = new Button
                {
                    Text = info.Choose[i],
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowOnly,
                    Name = i.ToString(),
                    Font = info.ChooseFont,
                    Anchor = (AnchorStyles.Bottom|AnchorStyles.Right)
                };
                panel1.Controls.Add(Button[i]);
                Button[i].Location = i == info.Choose.Length - 1 ? new Point(panel1.Width - 20 - Button[i].Width, (panel1.Height - Button[i].Height) / 2) : new Point(Button[i + 1].Location.X - 10 - Button[i].Width, (panel1.Height - Button[i].Height) / 2);
                //MessageBox.Show(button[i].Size.ToString());
                Button[i].Click += ButtonClick;
                Button[i].BringToFront();
            }

            if (Button[0].Location.X < 30)
            {
                var dx = 30 - Button[0].Location.X;
                Width += dx;
            }
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Info.Result = int.Parse(button.Name);
            Close();
        }

    }
}
