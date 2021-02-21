
namespace マイメモ帳
{
    partial class NewFontDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.フォント名 = new System.Windows.Forms.Label();
            this.スタイル = new System.Windows.Forms.Label();
            this.サイズ = new System.Windows.Forms.Label();
            this.フォント名一覧 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.スタイル一覧 = new System.Windows.Forms.ListBox();
            this.サイズ一覧 = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.サンプル = new System.Windows.Forms.Label();
            this.サンプルテキスト = new System.Windows.Forms.TextBox();
            this.他のフォントを表示 = new System.Windows.Forms.LinkLabel();
            this.OKボタン = new System.Windows.Forms.Button();
            this.キャンセルボタン = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // フォント名
            // 
            this.フォント名.AutoSize = true;
            this.フォント名.Cursor = System.Windows.Forms.Cursors.Default;
            this.フォント名.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.フォント名.Location = new System.Drawing.Point(12, 26);
            this.フォント名.Name = "フォント名";
            this.フォント名.Size = new System.Drawing.Size(80, 18);
            this.フォント名.TabIndex = 0;
            this.フォント名.Text = "フォント名:";
            // 
            // スタイル
            // 
            this.スタイル.AutoSize = true;
            this.スタイル.Cursor = System.Windows.Forms.Cursors.Default;
            this.スタイル.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.スタイル.Location = new System.Drawing.Point(284, 26);
            this.スタイル.Name = "スタイル";
            this.スタイル.Size = new System.Drawing.Size(66, 18);
            this.スタイル.TabIndex = 1;
            this.スタイル.Text = "スタイル:";
            // 
            // サイズ
            // 
            this.サイズ.AutoSize = true;
            this.サイズ.Cursor = System.Windows.Forms.Cursors.Default;
            this.サイズ.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.サイズ.Location = new System.Drawing.Point(488, 26);
            this.サイズ.Name = "サイズ";
            this.サイズ.Size = new System.Drawing.Size(55, 18);
            this.サイズ.TabIndex = 2;
            this.サイズ.Text = "サイズ:";
            // 
            // フォント名一覧
            // 
            this.フォント名一覧.Cursor = System.Windows.Forms.Cursors.Default;
            this.フォント名一覧.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.フォント名一覧.FormattingEnabled = true;
            this.フォント名一覧.ItemHeight = 26;
            this.フォント名一覧.Location = new System.Drawing.Point(12, 74);
            this.フォント名一覧.Name = "フォント名一覧";
            this.フォント名一覧.ScrollAlwaysVisible = true;
            this.フォント名一覧.Size = new System.Drawing.Size(250, 238);
            this.フォント名一覧.TabIndex = 3;
            this.フォント名一覧.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.フォント名一覧_DrawItem);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.textBox1.Location = new System.Drawing.Point(12, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.WordWrap = false;
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.textBox2.Location = new System.Drawing.Point(287, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 27);
            this.textBox2.TabIndex = 5;
            // 
            // スタイル一覧
            // 
            this.スタイル一覧.Cursor = System.Windows.Forms.Cursors.Default;
            this.スタイル一覧.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.スタイル一覧.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.スタイル一覧.FormattingEnabled = true;
            this.スタイル一覧.ItemHeight = 26;
            this.スタイル一覧.Location = new System.Drawing.Point(287, 74);
            this.スタイル一覧.Name = "スタイル一覧";
            this.スタイル一覧.ScrollAlwaysVisible = true;
            this.スタイル一覧.Size = new System.Drawing.Size(180, 238);
            this.スタイル一覧.TabIndex = 6;
            this.スタイル一覧.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.スタイル一覧_DrawItem);
            // 
            // サイズ一覧
            // 
            this.サイズ一覧.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.サイズ一覧.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.サイズ一覧.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.サイズ一覧.FormattingEnabled = true;
            this.サイズ一覧.ItemHeight = 26;
            this.サイズ一覧.Location = new System.Drawing.Point(491, 74);
            this.サイズ一覧.Name = "サイズ一覧";
            this.サイズ一覧.ScrollAlwaysVisible = true;
            this.サイズ一覧.Size = new System.Drawing.Size(90, 238);
            this.サイズ一覧.TabIndex = 7;
            this.サイズ一覧.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.サイズ一覧_DrawItem);
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.textBox3.Location = new System.Drawing.Point(491, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 27);
            this.textBox3.TabIndex = 8;
            // 
            // サンプル
            // 
            this.サンプル.AutoSize = true;
            this.サンプル.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.サンプル.Location = new System.Drawing.Point(284, 353);
            this.サンプル.Name = "サンプル";
            this.サンプル.Size = new System.Drawing.Size(65, 18);
            this.サンプル.TabIndex = 0;
            this.サンプル.Text = "サンプル";
            // 
            // サンプルテキスト
            // 
            this.サンプルテキスト.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.サンプルテキスト.Location = new System.Drawing.Point(287, 374);
            this.サンプルテキスト.Name = "サンプルテキスト";
            this.サンプルテキスト.Size = new System.Drawing.Size(294, 25);
            this.サンプルテキスト.TabIndex = 9;
            // 
            // 他のフォントを表示
            // 
            this.他のフォントを表示.AutoSize = true;
            this.他のフォントを表示.Cursor = System.Windows.Forms.Cursors.Hand;
            this.他のフォントを表示.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.他のフォントを表示.Location = new System.Drawing.Point(12, 374);
            this.他のフォントを表示.Name = "他のフォントを表示";
            this.他のフォントを表示.Size = new System.Drawing.Size(141, 18);
            this.他のフォントを表示.TabIndex = 10;
            this.他のフォントを表示.TabStop = true;
            this.他のフォントを表示.Text = "他のフォントを表示";
            this.他のフォントを表示.Click += new System.EventHandler(this.他のフォントを表示_Click);
            // 
            // OKボタン
            // 
            this.OKボタン.Location = new System.Drawing.Point(375, 491);
            this.OKボタン.Name = "OKボタン";
            this.OKボタン.Size = new System.Drawing.Size(100, 35);
            this.OKボタン.TabIndex = 11;
            this.OKボタン.Text = "OK";
            this.OKボタン.UseMnemonic = false;
            this.OKボタン.UseVisualStyleBackColor = true;
            this.OKボタン.Click += new System.EventHandler(this.OKボタン_Click);
            // 
            // キャンセルボタン
            // 
            this.キャンセルボタン.Location = new System.Drawing.Point(481, 491);
            this.キャンセルボタン.Name = "キャンセルボタン";
            this.キャンセルボタン.Size = new System.Drawing.Size(100, 35);
            this.キャンセルボタン.TabIndex = 12;
            this.キャンセルボタン.Text = "キャンセル";
            this.キャンセルボタン.UseMnemonic = false;
            this.キャンセルボタン.UseVisualStyleBackColor = true;
            this.キャンセルボタン.Click += new System.EventHandler(this.キャンセルボタン_Click);
            // 
            // NewFontDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 540);
            this.Controls.Add(this.キャンセルボタン);
            this.Controls.Add(this.OKボタン);
            this.Controls.Add(this.他のフォントを表示);
            this.Controls.Add(this.サンプルテキスト);
            this.Controls.Add(this.サンプル);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.サイズ一覧);
            this.Controls.Add(this.スタイル一覧);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.フォント名一覧);
            this.Controls.Add(this.サイズ);
            this.Controls.Add(this.スタイル);
            this.Controls.Add(this.フォント名);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewFontDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "フォント";
            this.Load += new System.EventHandler(this.NewFontDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label フォント名;
        private System.Windows.Forms.Label スタイル;
        private System.Windows.Forms.Label サイズ;
        private System.Windows.Forms.ListBox フォント名一覧;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox スタイル一覧;
        private System.Windows.Forms.ListBox サイズ一覧;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label サンプル;
        private System.Windows.Forms.TextBox サンプルテキスト;
        private System.Windows.Forms.LinkLabel 他のフォントを表示;
        private System.Windows.Forms.Button OKボタン;
        private System.Windows.Forms.Button キャンセルボタン;
    }
}