
namespace マイメモ帳
{
    public partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新規toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新しいウィンドウtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上書き保存toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.名前を付けて保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ページ設定toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.印刷toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.もとに戻すUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.やり直すYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.切り取りTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.コピーCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼り付けPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.削除LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bingで検索SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.検索FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.次を検索NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.前を検索VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.置換ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.行へ移動GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.すべて選択AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日付と時刻DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.書式OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.右端で折り返すWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォントFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.色CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ズームZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ステータスバーSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.タイトルバーTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプの表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フィードバックを送信FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.バージョン情報AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.text = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.編集ToolStripMenuItem,
            this.書式OToolStripMenuItem,
            this.表示ToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規toolStripMenuItem1,
            this.新しいウィンドウtoolStripMenuItem1,
            this.開くToolStripMenuItem,
            this.上書き保存toolStripMenuItem1,
            this.名前を付けて保存ToolStripMenuItem,
            this.toolStripSeparator1,
            this.ページ設定toolStripMenuItem1,
            this.印刷toolStripMenuItem1,
            this.toolStripSeparator2,
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            resources.ApplyResources(this.ファイルToolStripMenuItem, "ファイルToolStripMenuItem");
            // 
            // 新規toolStripMenuItem1
            // 
            this.新規toolStripMenuItem1.Name = "新規toolStripMenuItem1";
            resources.ApplyResources(this.新規toolStripMenuItem1, "新規toolStripMenuItem1");
            this.新規toolStripMenuItem1.Click += new System.EventHandler(this.新規toolStripMenuItem1_Click);
            // 
            // 新しいウィンドウtoolStripMenuItem1
            // 
            this.新しいウィンドウtoolStripMenuItem1.Name = "新しいウィンドウtoolStripMenuItem1";
            resources.ApplyResources(this.新しいウィンドウtoolStripMenuItem1, "新しいウィンドウtoolStripMenuItem1");
            this.新しいウィンドウtoolStripMenuItem1.Click += new System.EventHandler(this.新しいウィンドウtoolStripMenuItem1_Click);
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            resources.ApplyResources(this.開くToolStripMenuItem, "開くToolStripMenuItem");
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // 上書き保存toolStripMenuItem1
            // 
            this.上書き保存toolStripMenuItem1.Name = "上書き保存toolStripMenuItem1";
            resources.ApplyResources(this.上書き保存toolStripMenuItem1, "上書き保存toolStripMenuItem1");
            this.上書き保存toolStripMenuItem1.Click += new System.EventHandler(this.上書き保存toolStripMenuItem1_Click);
            // 
            // 名前を付けて保存ToolStripMenuItem
            // 
            this.名前を付けて保存ToolStripMenuItem.Name = "名前を付けて保存ToolStripMenuItem";
            resources.ApplyResources(this.名前を付けて保存ToolStripMenuItem, "名前を付けて保存ToolStripMenuItem");
            this.名前を付けて保存ToolStripMenuItem.Click += new System.EventHandler(this.名前を付けて保存ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // ページ設定toolStripMenuItem1
            // 
            resources.ApplyResources(this.ページ設定toolStripMenuItem1, "ページ設定toolStripMenuItem1");
            this.ページ設定toolStripMenuItem1.Name = "ページ設定toolStripMenuItem1";
            this.ページ設定toolStripMenuItem1.Click += new System.EventHandler(this.ページ設定toolStripMenuItem1_Click);
            // 
            // 印刷toolStripMenuItem1
            // 
            resources.ApplyResources(this.印刷toolStripMenuItem1, "印刷toolStripMenuItem1");
            this.印刷toolStripMenuItem1.Name = "印刷toolStripMenuItem1";
            this.印刷toolStripMenuItem1.Click += new System.EventHandler(this.印刷toolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            resources.ApplyResources(this.終了ToolStripMenuItem, "終了ToolStripMenuItem");
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // 編集ToolStripMenuItem
            // 
            this.編集ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.もとに戻すUToolStripMenuItem,
            this.やり直すYToolStripMenuItem,
            this.toolStripSeparator3,
            this.切り取りTToolStripMenuItem,
            this.コピーCToolStripMenuItem,
            this.貼り付けPToolStripMenuItem,
            this.削除LToolStripMenuItem,
            this.toolStripSeparator4,
            this.bingで検索SToolStripMenuItem,
            this.検索FToolStripMenuItem,
            this.次を検索NToolStripMenuItem,
            this.前を検索VToolStripMenuItem,
            this.置換ToolStripMenuItem,
            this.行へ移動GToolStripMenuItem,
            this.toolStripSeparator5,
            this.すべて選択AToolStripMenuItem,
            this.日付と時刻DToolStripMenuItem});
            this.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
            resources.ApplyResources(this.編集ToolStripMenuItem, "編集ToolStripMenuItem");
            // 
            // もとに戻すUToolStripMenuItem
            // 
            resources.ApplyResources(this.もとに戻すUToolStripMenuItem, "もとに戻すUToolStripMenuItem");
            this.もとに戻すUToolStripMenuItem.Name = "もとに戻すUToolStripMenuItem";
            this.もとに戻すUToolStripMenuItem.Click += new System.EventHandler(this.もとに戻すUToolStripMenuItem_Click);
            // 
            // やり直すYToolStripMenuItem
            // 
            resources.ApplyResources(this.やり直すYToolStripMenuItem, "やり直すYToolStripMenuItem");
            this.やり直すYToolStripMenuItem.Name = "やり直すYToolStripMenuItem";
            this.やり直すYToolStripMenuItem.Click += new System.EventHandler(this.やり直すYToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // 切り取りTToolStripMenuItem
            // 
            this.切り取りTToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.切り取りTToolStripMenuItem, "切り取りTToolStripMenuItem");
            this.切り取りTToolStripMenuItem.Name = "切り取りTToolStripMenuItem";
            this.切り取りTToolStripMenuItem.Click += new System.EventHandler(this.切り取りCToolStripMenuItem_Click);
            // 
            // コピーCToolStripMenuItem
            // 
            this.コピーCToolStripMenuItem.Name = "コピーCToolStripMenuItem";
            resources.ApplyResources(this.コピーCToolStripMenuItem, "コピーCToolStripMenuItem");
            this.コピーCToolStripMenuItem.Click += new System.EventHandler(this.コピーCToolStripMenuItem_Click);
            // 
            // 貼り付けPToolStripMenuItem
            // 
            resources.ApplyResources(this.貼り付けPToolStripMenuItem, "貼り付けPToolStripMenuItem");
            this.貼り付けPToolStripMenuItem.Name = "貼り付けPToolStripMenuItem";
            this.貼り付けPToolStripMenuItem.Click += new System.EventHandler(this.貼り付けPToolStripMenuItem_Click);
            // 
            // 削除LToolStripMenuItem
            // 
            resources.ApplyResources(this.削除LToolStripMenuItem, "削除LToolStripMenuItem");
            this.削除LToolStripMenuItem.Name = "削除LToolStripMenuItem";
            this.削除LToolStripMenuItem.Click += new System.EventHandler(this.削除LToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // bingで検索SToolStripMenuItem
            // 
            resources.ApplyResources(this.bingで検索SToolStripMenuItem, "bingで検索SToolStripMenuItem");
            this.bingで検索SToolStripMenuItem.Name = "bingで検索SToolStripMenuItem";
            this.bingで検索SToolStripMenuItem.Click += new System.EventHandler(this.bingで検索SToolStripMenuItem_Click);
            // 
            // 検索FToolStripMenuItem
            // 
            resources.ApplyResources(this.検索FToolStripMenuItem, "検索FToolStripMenuItem");
            this.検索FToolStripMenuItem.Name = "検索FToolStripMenuItem";
            // 
            // 次を検索NToolStripMenuItem
            // 
            resources.ApplyResources(this.次を検索NToolStripMenuItem, "次を検索NToolStripMenuItem");
            this.次を検索NToolStripMenuItem.Name = "次を検索NToolStripMenuItem";
            // 
            // 前を検索VToolStripMenuItem
            // 
            resources.ApplyResources(this.前を検索VToolStripMenuItem, "前を検索VToolStripMenuItem");
            this.前を検索VToolStripMenuItem.Name = "前を検索VToolStripMenuItem";
            // 
            // 置換ToolStripMenuItem
            // 
            this.置換ToolStripMenuItem.Name = "置換ToolStripMenuItem";
            resources.ApplyResources(this.置換ToolStripMenuItem, "置換ToolStripMenuItem");
            // 
            // 行へ移動GToolStripMenuItem
            // 
            this.行へ移動GToolStripMenuItem.Name = "行へ移動GToolStripMenuItem";
            resources.ApplyResources(this.行へ移動GToolStripMenuItem, "行へ移動GToolStripMenuItem");
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // すべて選択AToolStripMenuItem
            // 
            this.すべて選択AToolStripMenuItem.Name = "すべて選択AToolStripMenuItem";
            resources.ApplyResources(this.すべて選択AToolStripMenuItem, "すべて選択AToolStripMenuItem");
            this.すべて選択AToolStripMenuItem.Click += new System.EventHandler(this.すべて選択AToolStripMenuItem_Click);
            // 
            // 日付と時刻DToolStripMenuItem
            // 
            this.日付と時刻DToolStripMenuItem.Name = "日付と時刻DToolStripMenuItem";
            resources.ApplyResources(this.日付と時刻DToolStripMenuItem, "日付と時刻DToolStripMenuItem");
            // 
            // 書式OToolStripMenuItem
            // 
            this.書式OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.右端で折り返すWToolStripMenuItem,
            this.フォントFToolStripMenuItem,
            this.色CToolStripMenuItem});
            this.書式OToolStripMenuItem.Name = "書式OToolStripMenuItem";
            resources.ApplyResources(this.書式OToolStripMenuItem, "書式OToolStripMenuItem");
            // 
            // 右端で折り返すWToolStripMenuItem
            // 
            this.右端で折り返すWToolStripMenuItem.Name = "右端で折り返すWToolStripMenuItem";
            resources.ApplyResources(this.右端で折り返すWToolStripMenuItem, "右端で折り返すWToolStripMenuItem");
            this.右端で折り返すWToolStripMenuItem.Click += new System.EventHandler(this.右端で折り返すWToolStripMenuItem_Click);
            // 
            // フォントFToolStripMenuItem
            // 
            this.フォントFToolStripMenuItem.Name = "フォントFToolStripMenuItem";
            resources.ApplyResources(this.フォントFToolStripMenuItem, "フォントFToolStripMenuItem");
            this.フォントFToolStripMenuItem.Click += new System.EventHandler(this.フォントFToolStripMenuItem_Click);
            // 
            // 色CToolStripMenuItem
            // 
            this.色CToolStripMenuItem.Name = "色CToolStripMenuItem";
            resources.ApplyResources(this.色CToolStripMenuItem, "色CToolStripMenuItem");
            this.色CToolStripMenuItem.Click += new System.EventHandler(this.色CToolStripMenuItem_Click);
            // 
            // 表示ToolStripMenuItem
            // 
            this.表示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ズームZToolStripMenuItem,
            this.ステータスバーSToolStripMenuItem,
            this.タイトルバーTToolStripMenuItem});
            this.表示ToolStripMenuItem.Name = "表示ToolStripMenuItem";
            resources.ApplyResources(this.表示ToolStripMenuItem, "表示ToolStripMenuItem");
            // 
            // ズームZToolStripMenuItem
            // 
            this.ズームZToolStripMenuItem.Name = "ズームZToolStripMenuItem";
            resources.ApplyResources(this.ズームZToolStripMenuItem, "ズームZToolStripMenuItem");
            // 
            // ステータスバーSToolStripMenuItem
            // 
            resources.ApplyResources(this.ステータスバーSToolStripMenuItem, "ステータスバーSToolStripMenuItem");
            this.ステータスバーSToolStripMenuItem.Name = "ステータスバーSToolStripMenuItem";
            // 
            // タイトルバーTToolStripMenuItem
            // 
            this.タイトルバーTToolStripMenuItem.Name = "タイトルバーTToolStripMenuItem";
            resources.ApplyResources(this.タイトルバーTToolStripMenuItem, "タイトルバーTToolStripMenuItem");
            this.タイトルバーTToolStripMenuItem.Click += new System.EventHandler(this.タイトルバーTToolStripMenuItem_Click);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ヘルプの表示ToolStripMenuItem,
            this.フィードバックを送信FToolStripMenuItem,
            this.toolStripSeparator6,
            this.バージョン情報AToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            resources.ApplyResources(this.ヘルプHToolStripMenuItem, "ヘルプHToolStripMenuItem");
            // 
            // ヘルプの表示ToolStripMenuItem
            // 
            resources.ApplyResources(this.ヘルプの表示ToolStripMenuItem, "ヘルプの表示ToolStripMenuItem");
            this.ヘルプの表示ToolStripMenuItem.Name = "ヘルプの表示ToolStripMenuItem";
            // 
            // フィードバックを送信FToolStripMenuItem
            // 
            this.フィードバックを送信FToolStripMenuItem.Name = "フィードバックを送信FToolStripMenuItem";
            resources.ApplyResources(this.フィードバックを送信FToolStripMenuItem, "フィードバックを送信FToolStripMenuItem");
            this.フィードバックを送信FToolStripMenuItem.Click += new System.EventHandler(this.フィードバックを送信FToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // バージョン情報AToolStripMenuItem
            // 
            resources.ApplyResources(this.バージョン情報AToolStripMenuItem, "バージョン情報AToolStripMenuItem");
            this.バージョン情報AToolStripMenuItem.Name = "バージョン情報AToolStripMenuItem";
            // 
            // BottomToolStripPanel
            // 
            resources.ApplyResources(this.BottomToolStripPanel, "BottomToolStripPanel");
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            // 
            // TopToolStripPanel
            // 
            resources.ApplyResources(this.TopToolStripPanel, "TopToolStripPanel");
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            // 
            // RightToolStripPanel
            // 
            resources.ApplyResources(this.RightToolStripPanel, "RightToolStripPanel");
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            // 
            // LeftToolStripPanel
            // 
            resources.ApplyResources(this.LeftToolStripPanel, "LeftToolStripPanel");
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            // 
            // ContentPanel
            // 
            resources.ApplyResources(this.ContentPanel, "ContentPanel");
            // 
            // text
            // 
            this.text.AcceptsReturn = true;
            this.text.AcceptsTab = true;
            resources.ApplyResources(this.text, "text");
            this.text.Name = "text";
            this.text.TabStop = false;
            this.text.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Text_MouseClick);
            this.text.TextChanged += new System.EventHandler(this.Txt_memo_TextChanged);
            this.text.KeyUp += new System.Windows.Forms.KeyEventHandler(this.text_KeyUp);
            this.text.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Text_MouseClick);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.text);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名前を付けて保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 編集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 書式OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新規toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 新しいウィンドウtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 上書き保存toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ページ設定toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 印刷toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem もとに戻すUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 切り取りTToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem コピーCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 貼り付けPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 削除LToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem bingで検索SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 検索FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 次を検索NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 前を検索VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 置換ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 行へ移動GToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem すべて選択AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日付と時刻DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 右端で折り返すWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォントFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ズームZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ステータスバーSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプの表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem やり直すYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フィードバックを送信FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 色CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem タイトルバーTToolStripMenuItem;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.TextBox text;
    }
}

