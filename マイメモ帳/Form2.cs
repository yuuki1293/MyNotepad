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
    public partial class Form2 : Form
    {
        public Form2(ref CustomMassegeBoxInfo info)
        {
            InitializeComponent();
            Text = info.title;
            ShowIcon = info.showicon;
            label1.Text = info.message;
            if (info.font!=null){ Font = info.font; }
            Button[] button = new Button[info.choose.Length];
            for  (int i=0;i<info.choose.Length;i++)
            {
                button[i] = new Button
                {
                    Anchor = (AnchorStyles.Bottom | AnchorStyles.Right),
                    Location = new Point(30 + (i * 100), 50),
                    Text = info.choose[i],
                    AutoSize = true,
                    Name=i.ToString(),
                };
                button[i].Click += new EventHandler(ButtonClick);
                panel1.Controls.Add(button[i]);
                button[i].BringToFront();
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            info.result = int.Parse(button.Name);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
