
namespace マイメモ帳
{
    partial class Form1
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
            this.txt_memo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.切り取りCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ズームZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ステータスバーSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプの表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.バージョン情報AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_memo
            // 
            this.txt_memo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_memo.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_memo.Location = new System.Drawing.Point(0, 36);
            this.txt_memo.Multiline = true;
            this.txt_memo.Name = "txt_memo";
            this.txt_memo.Size = new System.Drawing.Size(800, 414);
            this.txt_memo.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.編集ToolStripMenuItem,
            this.書式OToolStripMenuItem,
            this.表示ToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.ファイルToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 新規toolStripMenuItem1
            // 
            this.新規toolStripMenuItem1.Name = "新規toolStripMenuItem1";
            this.新規toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新規toolStripMenuItem1.Size = new System.Drawing.Size(388, 34);
            this.新規toolStripMenuItem1.Text = "新規(&N)";
            this.新規toolStripMenuItem1.Click += new System.EventHandler(this.新規toolStripMenuItem1_Click);
            // 
            // 新しいウィンドウtoolStripMenuItem1
            // 
            this.新しいウィンドウtoolStripMenuItem1.Name = "新しいウィンドウtoolStripMenuItem1";
            this.新しいウィンドウtoolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.新しいウィンドウtoolStripMenuItem1.Size = new System.Drawing.Size(388, 34);
            this.新しいウィンドウtoolStripMenuItem1.Text = "新しいウィンドウ(&W)";
            this.新しいウィンドウtoolStripMenuItem1.Click += new System.EventHandler(this.新しいウィンドウtoolStripMenuItem1_Click);
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(388, 34);
            this.開くToolStripMenuItem.Text = "開く(&O)...";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // 上書き保存toolStripMenuItem1
            // 
            this.上書き保存toolStripMenuItem1.Name = "上書き保存toolStripMenuItem1";
            this.上書き保存toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.上書き保存toolStripMenuItem1.Size = new System.Drawing.Size(388, 34);
            this.上書き保存toolStripMenuItem1.Text = "上書き保存(&S)";
            this.上書き保存toolStripMenuItem1.Click += new System.EventHandler(this.上書き保存toolStripMenuItem1_Click);
            // 
            // 名前を付けて保存ToolStripMenuItem
            // 
            this.名前を付けて保存ToolStripMenuItem.Name = "名前を付けて保存ToolStripMenuItem";
            this.名前を付けて保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.名前を付けて保存ToolStripMenuItem.Size = new System.Drawing.Size(388, 34);
            this.名前を付けて保存ToolStripMenuItem.Text = "名前を付けて保存(&A)...";
            this.名前を付けて保存ToolStripMenuItem.Click += new System.EventHandler(this.名前を付けて保存ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(385, 6);
            // 
            // ページ設定toolStripMenuItem1
            // 
            this.ページ設定toolStripMenuItem1.Name = "ページ設定toolStripMenuItem1";
            this.ページ設定toolStripMenuItem1.Size = new System.Drawing.Size(388, 34);
            this.ページ設定toolStripMenuItem1.Text = "ページ設定(&U)...";
            // 
            // 印刷toolStripMenuItem1
            // 
            this.印刷toolStripMenuItem1.Name = "印刷toolStripMenuItem1";
            this.印刷toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.印刷toolStripMenuItem1.Size = new System.Drawing.Size(388, 34);
            this.印刷toolStripMenuItem1.Text = "印刷(&P)...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(385, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(388, 34);
            this.終了ToolStripMenuItem.Text = "終了(&X)";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // 編集ToolStripMenuItem
            // 
            this.編集ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.もとに戻すUToolStripMenuItem,
            this.toolStripSeparator3,
            this.切り取りCToolStripMenuItem,
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
            this.編集ToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.編集ToolStripMenuItem.Text = "編集(&E)";
            // 
            // もとに戻すUToolStripMenuItem
            // 
            this.もとに戻すUToolStripMenuItem.Name = "もとに戻すUToolStripMenuItem";
            this.もとに戻すUToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.もとに戻すUToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.もとに戻すUToolStripMenuItem.Text = "もとに戻す(&U)";
            this.もとに戻すUToolStripMenuItem.Click += new System.EventHandler(this.もとに戻すUToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(293, 6);
            // 
            // 切り取りCToolStripMenuItem
            // 
            this.切り取りCToolStripMenuItem.Name = "切り取りCToolStripMenuItem";
            this.切り取りCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.切り取りCToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.切り取りCToolStripMenuItem.Text = "切り取り(&T)";
            // 
            // コピーCToolStripMenuItem
            // 
            this.コピーCToolStripMenuItem.Name = "コピーCToolStripMenuItem";
            this.コピーCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.コピーCToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.コピーCToolStripMenuItem.Text = "コピー(&C)";
            // 
            // 貼り付けPToolStripMenuItem
            // 
            this.貼り付けPToolStripMenuItem.Name = "貼り付けPToolStripMenuItem";
            this.貼り付けPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.貼り付けPToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.貼り付けPToolStripMenuItem.Text = "貼り付け(&P)";
            // 
            // 削除LToolStripMenuItem
            // 
            this.削除LToolStripMenuItem.Name = "削除LToolStripMenuItem";
            this.削除LToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.削除LToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.削除LToolStripMenuItem.Text = "削除(&L)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(293, 6);
            // 
            // bingで検索SToolStripMenuItem
            // 
            this.bingで検索SToolStripMenuItem.Name = "bingで検索SToolStripMenuItem";
            this.bingで検索SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.bingで検索SToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.bingで検索SToolStripMenuItem.Text = "Bing で検索(&S)...";
            // 
            // 検索FToolStripMenuItem
            // 
            this.検索FToolStripMenuItem.Name = "検索FToolStripMenuItem";
            this.検索FToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.検索FToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.検索FToolStripMenuItem.Text = "検索(&F)...";
            // 
            // 次を検索NToolStripMenuItem
            // 
            this.次を検索NToolStripMenuItem.Name = "次を検索NToolStripMenuItem";
            this.次を検索NToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.次を検索NToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.次を検索NToolStripMenuItem.Text = "次を検索(&N)";
            // 
            // 前を検索VToolStripMenuItem
            // 
            this.前を検索VToolStripMenuItem.Name = "前を検索VToolStripMenuItem";
            this.前を検索VToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.前を検索VToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.前を検索VToolStripMenuItem.Text = "前を検索(&V)";
            // 
            // 置換ToolStripMenuItem
            // 
            this.置換ToolStripMenuItem.Name = "置換ToolStripMenuItem";
            this.置換ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.置換ToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.置換ToolStripMenuItem.Text = "置換(&R)...";
            // 
            // 行へ移動GToolStripMenuItem
            // 
            this.行へ移動GToolStripMenuItem.Name = "行へ移動GToolStripMenuItem";
            this.行へ移動GToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.行へ移動GToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.行へ移動GToolStripMenuItem.Text = "行へ移動(&G)...";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(293, 6);
            // 
            // すべて選択AToolStripMenuItem
            // 
            this.すべて選択AToolStripMenuItem.Name = "すべて選択AToolStripMenuItem";
            this.すべて選択AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.すべて選択AToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.すべて選択AToolStripMenuItem.Text = "すべて選択(&A)";
            // 
            // 日付と時刻DToolStripMenuItem
            // 
            this.日付と時刻DToolStripMenuItem.Name = "日付と時刻DToolStripMenuItem";
            this.日付と時刻DToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.日付と時刻DToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.日付と時刻DToolStripMenuItem.Text = "日付と時刻(&D)";
            // 
            // 書式OToolStripMenuItem
            // 
            this.書式OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.右端で折り返すWToolStripMenuItem,
            this.フォントFToolStripMenuItem});
            this.書式OToolStripMenuItem.Name = "書式OToolStripMenuItem";
            this.書式OToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.書式OToolStripMenuItem.Text = "書式(&O)";
            // 
            // 右端で折り返すWToolStripMenuItem
            // 
            this.右端で折り返すWToolStripMenuItem.Name = "右端で折り返すWToolStripMenuItem";
            this.右端で折り返すWToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.右端で折り返すWToolStripMenuItem.Text = "右端で折り返す(&W)";
            // 
            // フォントFToolStripMenuItem
            // 
            this.フォントFToolStripMenuItem.Name = "フォントFToolStripMenuItem";
            this.フォントFToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.フォントFToolStripMenuItem.Text = "フォント(&F)...";
            // 
            // 表示ToolStripMenuItem
            // 
            this.表示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ズームZToolStripMenuItem,
            this.ステータスバーSToolStripMenuItem});
            this.表示ToolStripMenuItem.Name = "表示ToolStripMenuItem";
            this.表示ToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.表示ToolStripMenuItem.Text = "表示(&V)";
            // 
            // ズームZToolStripMenuItem
            // 
            this.ズームZToolStripMenuItem.Name = "ズームZToolStripMenuItem";
            this.ズームZToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.ズームZToolStripMenuItem.Text = "ズーム(&Z)";
            // 
            // ステータスバーSToolStripMenuItem
            // 
            this.ステータスバーSToolStripMenuItem.Name = "ステータスバーSToolStripMenuItem";
            this.ステータスバーSToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.ステータスバーSToolStripMenuItem.Text = "ステータスバー(&S)";
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ヘルプの表示ToolStripMenuItem,
            this.toolStripSeparator6,
            this.バージョン情報AToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // ヘルプの表示ToolStripMenuItem
            // 
            this.ヘルプの表示ToolStripMenuItem.Name = "ヘルプの表示ToolStripMenuItem";
            this.ヘルプの表示ToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.ヘルプの表示ToolStripMenuItem.Text = "ヘルプの表示(&H)";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(235, 6);
            // 
            // バージョン情報AToolStripMenuItem
            // 
            this.バージョン情報AToolStripMenuItem.Name = "バージョン情報AToolStripMenuItem";
            this.バージョン情報AToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.バージョン情報AToolStripMenuItem.Text = "バージョン情報(&A)";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 424);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(800, 26);
            this.hScrollBar1.TabIndex = 2;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(774, 36);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 388);
            this.vScrollBar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.txt_memo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "マイメモ帳";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_memo;
        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ToolStripMenuItem もとに戻すUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 切り取りCToolStripMenuItem;
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
    }
}

