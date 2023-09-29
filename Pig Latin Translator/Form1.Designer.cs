namespace Pig_Latin_Translator
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
            this.label1 = new System.Windows.Forms.Label();
            this.englishText = new System.Windows.Forms.TextBox();
            this.pigLatinText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter English text here:";
            // 
            // englishText
            // 
            this.englishText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishText.Location = new System.Drawing.Point(12, 25);
            this.englishText.Multiline = true;
            this.englishText.Name = "englishText";
            this.englishText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.englishText.Size = new System.Drawing.Size(460, 145);
            this.englishText.TabIndex = 1;
            // 
            // pigLatinText
            // 
            this.pigLatinText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pigLatinText.Location = new System.Drawing.Point(12, 189);
            this.pigLatinText.Multiline = true;
            this.pigLatinText.Name = "pigLatinText";
            this.pigLatinText.ReadOnly = true;
            this.pigLatinText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pigLatinText.Size = new System.Drawing.Size(460, 145);
            this.pigLatinText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pig Latin Translation:";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnTranslate.Location = new System.Drawing.Point(12, 354);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 4;
            this.btnTranslate.Text = "&Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(93, 354);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(397, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTranslate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(484, 389);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.pigLatinText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.englishText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pig Latin Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox englishText;
        private System.Windows.Forms.TextBox pigLatinText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

