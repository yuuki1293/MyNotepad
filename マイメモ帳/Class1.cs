using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace マイメモ帳
{
    public class CustomMassegeBoxInfo
    {
        public string title { get; set; }  //必須
        public string[] choose { get; set; }  //必須
        public string message { get; set; }  //必須
        public System.Drawing.Image image { get; set; }
        public bool showicon { get; set; } = false;
        public System.Drawing.Font font { get; set; }
        public int result{get;set;}
        public int defaultChoose { get; set; } = 0;
        public Font messageFont { get; set; } = new Font("MS UI Gothic", 36);
        public Font chooseFont{ get; set; } = new Font("MS UI Gothic", 12);
    }
}
