using System.Drawing;

namespace マイメモ帳
{
    public class CustomMessageBoxInfo
    {
        public string Title { get; set; }  //必須
        public string[] Choose { get; set; }  //必須
        public string Message { get; set; }  //必須
        public System.Drawing.Image Image { get; set; }
        public bool ShowIcon { get; set; } = false;
        public int Result { get; set; }
        public int CancelChoose { get; set; } = 0;
        public Font MessageFont { get; set; } = new("Yu Gothic UI", 12);
        public Font ChooseFont { get; set; } = new("Yu Gothic UI", 9);
        public Color MessageColor { get; set; } = Color.FromArgb(0, 51, 153);
    }
}
