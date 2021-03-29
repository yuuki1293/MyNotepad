
namespace マイメモ帳
{
    partial class 検索置換form
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
            this.検索する文字列label = new System.Windows.Forms.Label();
            this.検索する文字列textBox = new System.Windows.Forms.TextBox();
            this.次を検索button = new System.Windows.Forms.Button();
            this.前を検索button = new System.Windows.Forms.Button();
            this.置換して次にbutton = new System.Windows.Forms.Button();
            this.大文字と小文字を区別するcheckBox = new System.Windows.Forms.CheckBox();
            this.折り返しありcheckBox = new System.Windows.Forms.CheckBox();
            this.正規表現を使用するcheckBox = new System.Windows.Forms.CheckBox();
            this.置換して前にbutton = new System.Windows.Forms.Button();
            this.全て置換button = new System.Windows.Forms.Button();
            this.キャンセルbutton = new System.Windows.Forms.Button();
            this.置換する文字列textBox = new System.Windows.Forms.TextBox();
            this.置換する文字列label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 検索する文字列label
            // 
            this.検索する文字列label.AutoSize = true;
            this.検索する文字列label.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.検索する文字列label.Location = new System.Drawing.Point(12, 28);
            this.検索する文字列label.Name = "検索する文字列label";
            this.検索する文字列label.Size = new System.Drawing.Size(158, 25);
            this.検索する文字列label.TabIndex = 0;
            this.検索する文字列label.Text = "検索する文字列(&N):";
            // 
            // 検索する文字列textBox
            // 
            this.検索する文字列textBox.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.検索する文字列textBox.Location = new System.Drawing.Point(176, 22);
            this.検索する文字列textBox.Name = "検索する文字列textBox";
            this.検索する文字列textBox.Size = new System.Drawing.Size(371, 34);
            this.検索する文字列textBox.TabIndex = 1;
            this.検索する文字列textBox.TextChanged += new System.EventHandler(this.検索する文字列textBox_TextChanged);
            // 
            // 次を検索button
            // 
            this.次を検索button.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.次を検索button.Location = new System.Drawing.Point(558, 16);
            this.次を検索button.Name = "次を検索button";
            this.次を検索button.Size = new System.Drawing.Size(154, 42);
            this.次を検索button.TabIndex = 6;
            this.次を検索button.Text = "次を検索(&F)";
            this.次を検索button.UseVisualStyleBackColor = true;
            this.次を検索button.Click += new System.EventHandler(this.次を検索button_Click);
            // 
            // 前を検索button
            // 
            this.前を検索button.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.前を検索button.Location = new System.Drawing.Point(558, 64);
            this.前を検索button.Name = "前を検索button";
            this.前を検索button.Size = new System.Drawing.Size(154, 42);
            this.前を検索button.TabIndex = 7;
            this.前を検索button.Text = "前を検索(&G)";
            this.前を検索button.UseVisualStyleBackColor = true;
            this.前を検索button.Click += new System.EventHandler(this.前を検索button_Click);
            // 
            // 置換して次にbutton
            // 
            this.置換して次にbutton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.置換して次にbutton.Location = new System.Drawing.Point(558, 112);
            this.置換して次にbutton.Name = "置換して次にbutton";
            this.置換して次にbutton.Size = new System.Drawing.Size(154, 42);
            this.置換して次にbutton.TabIndex = 8;
            this.置換して次にbutton.Text = "置換して次に(&H)";
            this.置換して次にbutton.UseVisualStyleBackColor = true;
            this.置換して次にbutton.Click += new System.EventHandler(this.置換して次にbutton_Click);
            // 
            // 大文字と小文字を区別するcheckBox
            // 
            this.大文字と小文字を区別するcheckBox.AutoSize = true;
            this.大文字と小文字を区別するcheckBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.大文字と小文字を区別するcheckBox.Location = new System.Drawing.Point(12, 112);
            this.大文字と小文字を区別するcheckBox.Name = "大文字と小文字を区別するcheckBox";
            this.大文字と小文字を区別するcheckBox.Size = new System.Drawing.Size(259, 29);
            this.大文字と小文字を区別するcheckBox.TabIndex = 3;
            this.大文字と小文字を区別するcheckBox.Text = "大文字と小文字を区別する(&C)";
            this.大文字と小文字を区別するcheckBox.UseVisualStyleBackColor = true;
            // 
            // 折り返しありcheckBox
            // 
            this.折り返しありcheckBox.AutoSize = true;
            this.折り返しありcheckBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.折り返しありcheckBox.Location = new System.Drawing.Point(12, 147);
            this.折り返しありcheckBox.Name = "折り返しありcheckBox";
            this.折り返しありcheckBox.Size = new System.Drawing.Size(150, 29);
            this.折り返しありcheckBox.TabIndex = 4;
            this.折り返しありcheckBox.Text = "折り返しあり(&O)";
            this.折り返しありcheckBox.UseVisualStyleBackColor = true;
            // 
            // 正規表現を使用するcheckBox
            // 
            this.正規表現を使用するcheckBox.AutoSize = true;
            this.正規表現を使用するcheckBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.正規表現を使用するcheckBox.Location = new System.Drawing.Point(12, 182);
            this.正規表現を使用するcheckBox.Name = "正規表現を使用するcheckBox";
            this.正規表現を使用するcheckBox.Size = new System.Drawing.Size(209, 29);
            this.正規表現を使用するcheckBox.TabIndex = 5;
            this.正規表現を使用するcheckBox.Text = "正規表現を使用する(&S)";
            this.正規表現を使用するcheckBox.UseVisualStyleBackColor = true;
            // 
            // 置換して前にbutton
            // 
            this.置換して前にbutton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.置換して前にbutton.Location = new System.Drawing.Point(558, 160);
            this.置換して前にbutton.Name = "置換して前にbutton";
            this.置換して前にbutton.Size = new System.Drawing.Size(154, 42);
            this.置換して前にbutton.TabIndex = 9;
            this.置換して前にbutton.Text = "置換して前に(&I)";
            this.置換して前にbutton.UseVisualStyleBackColor = true;
            this.置換して前にbutton.Click += new System.EventHandler(this.置換して前にbutton_Click);
            // 
            // 全て置換button
            // 
            this.全て置換button.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.全て置換button.Location = new System.Drawing.Point(558, 208);
            this.全て置換button.Name = "全て置換button";
            this.全て置換button.Size = new System.Drawing.Size(154, 42);
            this.全て置換button.TabIndex = 10;
            this.全て置換button.Text = "全て置換(&A)";
            this.全て置換button.UseVisualStyleBackColor = true;
            this.全て置換button.Click += new System.EventHandler(this.全て置換button_Click);
            // 
            // キャンセルbutton
            // 
            this.キャンセルbutton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.キャンセルbutton.Location = new System.Drawing.Point(558, 256);
            this.キャンセルbutton.Name = "キャンセルbutton";
            this.キャンセルbutton.Size = new System.Drawing.Size(154, 42);
            this.キャンセルbutton.TabIndex = 11;
            this.キャンセルbutton.Text = "キャンセル";
            this.キャンセルbutton.UseVisualStyleBackColor = true;
            this.キャンセルbutton.Click += new System.EventHandler(this.キャンセルbutton_Click);
            // 
            // 置換する文字列textBox
            // 
            this.置換する文字列textBox.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.置換する文字列textBox.Location = new System.Drawing.Point(176, 67);
            this.置換する文字列textBox.Name = "置換する文字列textBox";
            this.置換する文字列textBox.Size = new System.Drawing.Size(371, 34);
            this.置換する文字列textBox.TabIndex = 2;
            // 
            // 置換する文字列label
            // 
            this.置換する文字列label.AutoSize = true;
            this.置換する文字列label.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.置換する文字列label.Location = new System.Drawing.Point(12, 73);
            this.置換する文字列label.Name = "置換する文字列label";
            this.置換する文字列label.Size = new System.Drawing.Size(156, 25);
            this.置換する文字列label.TabIndex = 0;
            this.置換する文字列label.Text = "置換する文字列(&R):";
            // 
            // 検索置換form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 312);
            this.Controls.Add(this.置換する文字列textBox);
            this.Controls.Add(this.置換する文字列label);
            this.Controls.Add(this.キャンセルbutton);
            this.Controls.Add(this.全て置換button);
            this.Controls.Add(this.置換して前にbutton);
            this.Controls.Add(this.正規表現を使用するcheckBox);
            this.Controls.Add(this.折り返しありcheckBox);
            this.Controls.Add(this.大文字と小文字を区別するcheckBox);
            this.Controls.Add(this.置換して次にbutton);
            this.Controls.Add(this.前を検索button);
            this.Controls.Add(this.次を検索button);
            this.Controls.Add(this.検索する文字列textBox);
            this.Controls.Add(this.検索する文字列label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "検索置換form";
            this.ShowIcon = false;
            this.Text = "検索 置換";
            this.Load += new System.EventHandler(this.検索置換form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 検索する文字列label;
        private System.Windows.Forms.TextBox 検索する文字列textBox;
        private System.Windows.Forms.Button 次を検索button;
        private System.Windows.Forms.Button 前を検索button;
        private System.Windows.Forms.Button 置換して次にbutton;
        private System.Windows.Forms.CheckBox 大文字と小文字を区別するcheckBox;
        private System.Windows.Forms.CheckBox 折り返しありcheckBox;
        private System.Windows.Forms.CheckBox 正規表現を使用するcheckBox;
        private System.Windows.Forms.Button 置換して前にbutton;
        private System.Windows.Forms.Button 全て置換button;
        private System.Windows.Forms.Button キャンセルbutton;
        private System.Windows.Forms.TextBox 置換する文字列textBox;
        private System.Windows.Forms.Label 置換する文字列label;
    }
}