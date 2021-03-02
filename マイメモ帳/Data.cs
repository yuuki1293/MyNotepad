using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace マイメモ帳
{
    public class Data
    {
        internal Font TextFont { get; set; }
        internal bool ShowTitleBar { get; set; }
        internal Dictionary<string,Color> Colors { get; set; }

        internal void Save()
        {
            var path = Path.Combine(Application.UserAppDataPath, "usersetting.xml");

            var xml = new XmlSerializer(typeof(Data));
            using (var streamWriter = new StreamWriter(path, false, Encoding.UTF8))
            {
                xml.Serialize(streamWriter, this);
                streamWriter.Flush();
            }
        }

        internal void Load()
        {
            var path = Path.Combine(Application.UserAppDataPath, "usersetting.xml");
            XElement xml = XElement.Load(path);
            ShowTitleBar =Convert.ToBoolean(xml.Elements("ShowTitleBar").Single().Value);
        }
    }
}
