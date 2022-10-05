namespace RichTextBoxKnotrola
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bntCitaj = new System.Windows.Forms.Button();
            this.bntBrisi = new System.Windows.Forms.Button();
            this.bntSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(272, 95);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // bntCitaj
            // 
            this.bntCitaj.Location = new System.Drawing.Point(13, 13);
            this.bntCitaj.Name = "bntCitaj";
            this.bntCitaj.Size = new System.Drawing.Size(75, 23);
            this.bntCitaj.TabIndex = 1;
            this.bntCitaj.Text = "Citaj";
            this.bntCitaj.UseVisualStyleBackColor = true;
            this.bntCitaj.Click += new System.EventHandler(this.bntCitaj_Click);
            // 
            // bntBrisi
            // 
            this.bntBrisi.Location = new System.Drawing.Point(209, 13);
            this.bntBrisi.Name = "bntBrisi";
            this.bntBrisi.Size = new System.Drawing.Size(75, 23);
            this.bntBrisi.TabIndex = 2;
            this.bntBrisi.Text = "Brisi";
            this.bntBrisi.UseVisualStyleBackColor = true;
            this.bntBrisi.Click += new System.EventHandler(this.bntBrisi_Click);
            // 
            // bntSpremi
            // 
            this.bntSpremi.Location = new System.Drawing.Point(12, 168);
            this.bntSpremi.Name = "bntSpremi";
            this.bntSpremi.Size = new System.Drawing.Size(75, 23);
            this.bntSpremi.TabIndex = 3;
            this.bntSpremi.Text = "Spremi";
            this.bntSpremi.UseVisualStyleBackColor = true;
            this.bntSpremi.Click += new System.EventHandler(this.bntSpremi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 210);
            this.Controls.Add(this.bntSpremi);
            this.Controls.Add(this.bntBrisi);
            this.Controls.Add(this.bntCitaj);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Upotreba RichTextBox Kontrole";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bntCitaj;
        private System.Windows.Forms.Button bntBrisi;
        private System.Windows.Forms.Button bntSpremi;
    }
}

