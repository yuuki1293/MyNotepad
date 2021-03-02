﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace マイメモ帳
{
    public class Data
    {
        internal Font TextFont { get; set; }
        internal bool ShowTitleBar { get; set; }
        internal Dictionary<string, Color> Colors { get; set; }

        internal void Save()
        {
            var path = Path.Combine(Application.UserAppDataPath, "usersetting.xml");

            var xml = XElement.Load(path);
            xml.Elements("ShowTitleBar").Single().Value = ShowTitleBar.ToString();

            xml.Save(path);
        }

        internal void Load()
        {
            var path = Path.Combine(Application.UserAppDataPath, "usersetting.xml");

            var xml = XElement.Load(path);
            ShowTitleBar = Convert.ToBoolean(xml.Elements("ShowTitleBar").Single().Value);
            var loadFont = xml.Elements("Font");
            var xElements = loadFont as XElement[] ?? loadFont.ToArray();
            var bold = Convert.ToBoolean(xElements.Elements("Bold").Single().Value);
            var italic = Convert.ToBoolean(xElements.Elements("Italic").Single().Value);
            TextFont = new Font
                (
                    xElements.Elements("Name").Single().Value,
                    int.Parse(xElements.Elements("Size").Single().Value),
                    bold && italic ? (FontStyle.Bold | FontStyle.Italic) :
                            bold ? FontStyle.Bold :
                            italic ? FontStyle.Italic :
                            FontStyle.Regular
                );
            var colors = xml.Elements("Color");
            Colors = new Dictionary<string, Color>();
            foreach (var color in colors)
            {
                var key = color.FirstAttribute.Value;
                var value = Color.FromArgb(Convert.ToInt32(color.Value,16));
                Colors.Add(key,value);
            }
        }
    }
}
