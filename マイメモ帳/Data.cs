using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace マイメモ帳
{
    public class Data
    {
        internal Font TextFont { get; set; }
        internal bool ShowTitleBar { get; set; }
        internal Dictionary<string, Color> Colors { get; set; }
        internal Size FormSize { get; set; }

        internal void Save()
        {
            var path = Path.Combine(Application.UserAppDataPath, "usersetting.xml");

            var xml = XElement.Load(path);
            xml.Elements("ShowTitleBar").Single().Value = ShowTitleBar.ToString();
            var fontElements = xml.Elements("Font");
            var xElements = fontElements as XElement[] ?? fontElements.ToArray();
            xElements.Elements("Name").Single().Value = TextFont.Name;
            xElements.Elements("Size").Single().Value = TextFont.Size.ToString(CultureInfo.InvariantCulture);
            xElements.Elements("Bold").Single().Value = TextFont.Bold.ToString();
            xElements.Elements("Italic").Single().Value = TextFont.Italic.ToString(); 
            foreach (var color in Colors)
            {
                xml.Elements("Color")
                    .Single(y => y.Attributes("name").Single().Value == color.Key).Value = Convert.ToString(color.Value.ToArgb(),16);
            }
            xml.Elements("FormSize").Single().Value = $"{FormSize.Width},{FormSize.Height}";

            xml.Save(path);
        }

        internal void Load()
        {
            var path = Path.Combine(Application.UserAppDataPath, "usersetting.xml");
            if (!File.Exists(path))
            {
                using var fs= File.CreateText(path);
                fs.Write("<?xml version=\"1.0\" encoding=\"utf-8\"?>\n<Data>\n</Data>");
            }
            var xml = XElement.Load(path);
            ShowTitleBar = Convert.ToBoolean(NodeExists(xml, "ShowTitleBar", "true"));
            try
            {
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
            }
            catch (System.InvalidOperationException)
            {
                xml.Elements("Font").Remove();
                xml.Add(new XElement("Font",
                    new XElement("Name", "MS UI Gothic"),
                    new XElement("Size", 12),
                    new XElement("Bold", false),
                    new XElement("Italic", false)
                ));
                TextFont = new Font("MS UI Gothic", 12);
            }

            //if (!xml.Elements("Color").Any()) xml.Add(new XElement("Color"));
            var colors = xml.Elements("Color");
            Colors = new Dictionary<string, Color>();

            foreach (var color in colors)
            {
                var key = color.FirstAttribute.Value;
                var value = Color.FromArgb(Convert.ToInt32(color.Value, 16));
                Colors.Add(key, value);
            }

            var formSize=NodeExists(xml, "FormSize","822, 506").Split(',').Select(int.Parse);
            var enumerable = formSize as int[] ?? formSize.ToArray();
            FormSize = new Size(new Point(enumerable[0],enumerable[1]));
            xml.Save(path);
        }

        private static string NodeExists(XContainer xml, string nodeName, string defaultValue = null)
        {
            try
            {
                return xml.Elements(nodeName).Single().Value;
            }
            catch (System.InvalidOperationException)
            {
                xml.Add(new XElement(nodeName, defaultValue));
                return defaultValue;
            }
        }
    }
}
