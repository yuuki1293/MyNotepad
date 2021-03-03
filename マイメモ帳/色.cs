using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace マイメモ帳
{
    public partial class 色 : Form
    {
        private Dictionary<string, ColorSelectDialog> ColorSelectDialogs { get; } = new();

        public 色()
        {
            InitializeComponent();
        }

        private void 色_Load(object sender, System.EventArgs e)
        {
            ColorChange();
        }

        private void ColorChange()
        {
            static Color Set(string name)=> MainForm.Data.Colors[name];
            var count=10;
            foreach (var dataColor in MainForm.Data.Colors)
            {
                ColorSelectDialogs.Add(dataColor.Key, new ColorSelectDialog { Text =dataColor.Key, Color = Set(dataColor.Key), Location = new Point(10, count) });
                Controls.Add(ColorSelectDialogs[dataColor.Key]);
                count += 25;
            }

            Height = count + 50;
        }

        private void OKボタン_Click(object sender, System.EventArgs e)
        {
            string[] keys = new string[MainForm.Data.Colors.Count];
            MainForm.Data.Colors.Keys.CopyTo(keys,0);
            foreach (var dataColor in keys)
            {
                MainForm.Data.Colors[dataColor] = ColorSelectDialogs[dataColor].Color;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void キャンセルボタン_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
