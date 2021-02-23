﻿using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace マイメモ帳
{
    public class Data
    {
        internal Font TextFont { get; set; }

        public bool ShowTitleBar { get; set; }

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

        internal Data Load()
        {
            var xmlSerializer = new XmlSerializer(typeof(Data));
            var path = Path.Combine(Application.UserAppDataPath, "usersetting.xml");

            if (!File.Exists(path)) { return new Data(); }

            var settings = new XmlReaderSettings { CheckCharacters = false };
            using (var streamReader = new StreamReader(path,Encoding.UTF8)) 
            using (var xmlReader = XmlReader.Create(streamReader,settings))
            {
                Data data =(Data)xmlSerializer.Deserialize(xmlReader);
                streamReader.Close();
                return data;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public string DisplayFontAsString
        {
            get => ConvertToString(TextFont);
            set => TextFont = ConvertFromString<Font>(value);
        }

        public static string ConvertToString<T>(T value)
        {
            return TypeDescriptor.GetConverter(typeof(T)).ConvertToString(value);
        }
        public static T ConvertFromString<T>(string value)
        {
            return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(value);
        }
    }
}
