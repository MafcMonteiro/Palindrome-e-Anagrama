namespace Anagrama
{
    partial class Form1
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
            this.btnAnagrama = new System.Windows.Forms.Button();
            this.tbxAnaPlavra1 = new System.Windows.Forms.TextBox();
            this.tbxAnaPalavra2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxPalindrome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btrnPalindrome = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnagrama
            // 
            this.btnAnagrama.Location = new System.Drawing.Point(119, 56);
            this.btnAnagrama.Name = "btnAnagrama";
            this.btnAnagrama.Size = new System.Drawing.Size(75, 37);
            this.btnAnagrama.TabIndex = 0;
            this.btnAnagrama.Text = "Verificar";
            this.btnAnagrama.UseVisualStyleBackColor = true;
            this.btnAnagrama.Click += new System.EventHandler(this.btnAnagrama_Click);
            // 
            // tbxAnaPlavra1
            // 
            this.tbxAnaPlavra1.Location = new System.Drawing.Point(6, 50);
            this.tbxAnaPlavra1.Name = "tbxAnaPlavra1";
            this.tbxAnaPlavra1.Size = new System.Drawing.Size(100, 20);
            this.tbxAnaPlavra1.TabIndex = 1;
            // 
            // tbxAnaPalavra2
            // 
            this.tbxAnaPalavra2.Location = new System.Drawing.Point(6, 93);
            this.tbxAnaPalavra2.Name = "tbxAnaPalavra2";
            this.tbxAnaPalavra2.Size = new System.Drawing.Size(100, 20);
            this.tbxAnaPalavra2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Palavra 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAnagrama);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxAnaPalavra2);
            this.groupBox1.Controls.Add(this.tbxAnaPlavra1);
            this.groupBox1.Location = new System.Drawing.Point(12, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 131);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verificar Anagrama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Palavra 2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btrnPalindrome);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbxPalindrome);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verificar Palindrome";
            // 
            // tbxPalindrome
            // 
            this.tbxPalindrome.Location = new System.Drawing.Point(6, 54);
            this.tbxPalindrome.Name = "tbxPalindrome";
            this.tbxPalindrome.Size = new System.Drawing.Size(100, 20);
            this.tbxPalindrome.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Palavra 1";
            // 
            // btrnPalindrome
            // 
            this.btrnPalindrome.Location = new System.Drawing.Point(119, 37);
            this.btrnPalindrome.Name = "btrnPalindrome";
            this.btrnPalindrome.Size = new System.Drawing.Size(75, 37);
            this.btrnPalindrome.TabIndex = 5;
            this.btrnPalindrome.Text = "Verificar";
            this.btrnPalindrome.UseVisualStyleBackColor = true;
            this.btrnPalindrome.Click += new System.EventHandler(this.btrnPalindrome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 294);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificar Anagrama e Palindrome";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnagrama;
        private System.Windows.Forms.TextBox tbxAnaPlavra1;
        private System.Windows.Forms.TextBox tbxAnaPalavra2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btrnPalindrome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPalindrome;
    }
}

