
namespace マイメモ帳
{
    partial class 色
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
            this.OKボタン = new System.Windows.Forms.Button();
            this.キャンセルボタン = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OKボタン
            // 
            this.OKボタン.Location = new System.Drawing.Point(417, 404);
            this.OKボタン.Name = "OKボタン";
            this.OKボタン.Size = new System.Drawing.Size(110, 34);
            this.OKボタン.TabIndex = 0;
            this.OKボタン.Text = "OK";
            this.OKボタン.UseVisualStyleBackColor = true;
            this.OKボタン.Click += new System.EventHandler(this.OKボタン_Click);
            // 
            // キャンセルボタン
            // 
            this.キャンセルボタン.Location = new System.Drawing.Point(301, 404);
            this.キャンセルボタン.Name = "キャンセルボタン";
            this.キャンセルボタン.Size = new System.Drawing.Size(110, 34);
            this.キャンセルボタン.TabIndex = 1;
            this.キャンセルボタン.Text = "キャンセル";
            this.キャンセルボタン.UseVisualStyleBackColor = true;
            this.キャンセルボタン.Click += new System.EventHandler(this.キャンセルボタン_Click);
            // 
            // 色
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.キャンセルボタン);
            this.Controls.Add(this.OKボタン);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "色";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "色";
            this.Load += new System.EventHandler(this.色_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKボタン;
        private System.Windows.Forms.Button キャンセルボタン;
    }
}