namespace AlfoviteSorter
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
            this.label2 = new System.Windows.Forms.Label();
            this.TextIn = new System.Windows.Forms.TextBox();
            this.butSort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наша сортировка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вводим текст:";
            // 
            // TextIn
            // 
            this.TextIn.Location = new System.Drawing.Point(16, 88);
            this.TextIn.Name = "TextIn";
            this.TextIn.Size = new System.Drawing.Size(561, 20);
            this.TextIn.TabIndex = 2;
            // 
            // butSort
            // 
            this.butSort.Location = new System.Drawing.Point(16, 124);
            this.butSort.Name = "butSort";
            this.butSort.Size = new System.Drawing.Size(123, 42);
            this.butSort.TabIndex = 3;
            this.butSort.Text = "Отсортировать";
            this.butSort.UseVisualStyleBackColor = true;
            this.butSort.Click += new System.EventHandler(this.butSort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(747, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Результаты:";
            // 
            // TextOut
            // 
            this.TextOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextOut.Location = new System.Drawing.Point(723, 88);
            this.TextOut.Multiline = true;
            this.TextOut.Name = "TextOut";
            this.TextOut.Size = new System.Drawing.Size(216, 467);
            this.TextOut.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 633);
            this.Controls.Add(this.TextOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butSort);
            this.Controls.Add(this.TextIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Сортировочка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextIn;
        private System.Windows.Forms.Button butSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextOut;
    }
}

