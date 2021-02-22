﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;

namespace マイメモ帳
{
    public partial class NewFontDialog : Form
    {
        private Dictionary<FontStyle, string> FontStyleToString { get; } = new Dictionary<FontStyle, string>(){
            { FontStyle.Regular,"標準" },
            { FontStyle.Bold,"太字" },
            { FontStyle.Italic,"斜体" },
            { (FontStyle.Bold|FontStyle.Italic),"太字 斜体" }
        };

        private bool FinLoad { get; set; }

        public NewFontDialog()
        {
            InitializeComponent();
        }

        private void NewFontDialog_Load(object sender, EventArgs e)
        {
            
            var fonts = new InstalledFontCollection();
            FontFamily[] ffArray = fonts.Families;
            foreach (var ff in ffArray)
                フォント名一覧.Items.Add(ff.Name);
            フォント名一覧.SelectedItem = Font.Name;
            
            foreach (var str in new[] { "標準", "太字", "斜体", "太字 斜体" })
                スタイル一覧.Items.Add(str);
            スタイル一覧.SelectedItem = FontStyleToString[Font.Style];
            
            float[] fontSize = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var i in fontSize)
                サイズ一覧.Items.Add(i);
            サイズ一覧.SelectedItem = Font.Size;
            
            int locationListBox = textBox1.Location.Y + textBox1.Size.Height;
            フォント名一覧.Location = new Point(フォント名一覧.Location.X, locationListBox);
            スタイル一覧.Location = new Point(スタイル一覧.Location.X, locationListBox);
            サイズ一覧.Location = new Point(サイズ一覧.Location.X, locationListBox);

            textBox1.Text = Font.Name;
            textBox2.Text = FontStyleToString[Font.Style];
            textBox3.Text = Font.Size.ToString(CultureInfo.InvariantCulture);

            FinLoad = true;
        }

        private void フォント名一覧_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            string txt = ((ListBox)sender).Items[e.Index].ToString();
            Font font = new Font(txt, 11, Font.Style);
            e.Graphics.DrawString(txt, font, Brushes.Black, e.Bounds);
        }

        private void スタイル一覧_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) return;
            e.DrawBackground();

            string txt = ((ListBox)sender).Items[e.Index].ToString();
            FontStyle style;
            switch (txt)
            {
                case "標準":
                    style = FontStyle.Regular;
                    break;
                case "太字":
                    style = FontStyle.Bold;
                    break;
                case "斜体":
                    style = FontStyle.Italic;
                    break;
                default:
                    style = (FontStyle.Italic | FontStyle.Bold);
                    break;
            }
            Font font = new Font(Font.Name, 11, style);
            e.Graphics.DrawString(txt, font, Brushes.Black, e.Bounds);
        }

        private void サイズ一覧_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), new Font("Yu UI", 11, FontStyle.Regular), Brushes.Black, e.Bounds);
        }

        private void OKボタン_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void キャンセルボタン_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void 他のフォントを表示_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c start ms-settings:fonts")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(processStartInfo);
        }

        private void SelectedValueChanged(object sender, EventArgs e)
        {
            if (サイズ一覧.SelectedItem != null && FinLoad)
            {
                FinLoad = false;
                var fontName = フォント名一覧.SelectedItem.ToString();
                var fontSize = (float)サイズ一覧.SelectedItem;
                FontStyle fontStyle;
                switch (スタイル一覧.SelectedItem.ToString())
                {
                    case "標準":
                        fontStyle = FontStyle.Regular;
                        break;
                    case "太字":
                        fontStyle = FontStyle.Bold;
                        break;
                    case "斜体":
                        fontStyle = FontStyle.Italic;
                        break;
                    default:
                        fontStyle = (FontStyle.Italic | FontStyle.Bold);
                        break;
                }

                textBox1.Text = fontName;
                textBox2.Text = FontStyleToString[fontStyle];
                textBox3.Text = fontSize.ToString(CultureInfo.InvariantCulture);
                Font = new Font(fontName, fontSize, fontStyle);
                サンプルテキスト.Font = Font;

                スタイル一覧.Items.Clear();
                foreach (var str in new[] { "標準", "太字", "斜体", "太字 斜体" })
                    スタイル一覧.Items.Add(str);
                //スタイル一覧_DrawItem("標準",drawItemEventArgs);
                スタイル一覧.SelectedItem = FontStyleToString[Font.Style];
                FinLoad = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (FinLoad)
            {
                object[] array = new object[フォント名一覧.Items.Count];
                フォント名一覧.Items.CopyTo(array, 0);
                Array.Find(array, i=>)
            }
        }
    }
}
