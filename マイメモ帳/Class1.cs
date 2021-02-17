using System.Drawing;

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
        public int result { get; set; }
        public int CancelChoose { get; set; } = 0;
        public Font messageFont { get; set; } = new Font("Yu Gothic UI", 12);
        public Font chooseFont { get; set; } = new Font("Yu Gothic UI", 9);
        public Color messageColor { get; set; } = Color.FromArgb(0, 51, 153);
    }
}
