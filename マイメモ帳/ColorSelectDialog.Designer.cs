
namespace マイメモ帳
{
    partial class ColorSelectDialog
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxHex = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // ColorButton
            // 
            this.ColorButton.BackColor = System.Drawing.SystemColors.Control;
            this.ColorButton.Location = new System.Drawing.Point(314, 1);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(75, 23);
            this.ColorButton.TabIndex = 0;
            this.ColorButton.UseVisualStyleBackColor = false;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // maskedTextBoxHex
            // 
            this.maskedTextBoxHex.Location = new System.Drawing.Point(395, 0);
            this.maskedTextBoxHex.Mask = "AA AA AA AA";
            this.maskedTextBoxHex.Name = "maskedTextBoxHex";
            this.maskedTextBoxHex.Size = new System.Drawing.Size(100, 25);
            this.maskedTextBoxHex.TabIndex = 2;
            this.maskedTextBoxHex.Text = "FFFFFFFF";
            this.maskedTextBoxHex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyDown);
            // 
            // ColorSelectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maskedTextBoxHex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ColorSelectDialog";
            this.Size = new System.Drawing.Size(500, 24);
            this.Load += new System.EventHandler(this.ColorSelectDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHex;
    }
}
