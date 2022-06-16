namespace Exercise4
{
    partial class FormLogin
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
            this.buttonMhs = new System.Windows.Forms.Button();
            this.buttonNilai = new System.Windows.Forms.Button();
            this.buttonPrd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Prodi TI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonMhs
            // 
            this.buttonMhs.Location = new System.Drawing.Point(287, 186);
            this.buttonMhs.Name = "buttonMhs";
            this.buttonMhs.Size = new System.Drawing.Size(168, 42);
            this.buttonMhs.TabIndex = 5;
            this.buttonMhs.Text = "Data Mahasiswa";
            this.buttonMhs.UseVisualStyleBackColor = true;
            this.buttonMhs.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNilai
            // 
            this.buttonNilai.Location = new System.Drawing.Point(287, 246);
            this.buttonNilai.Name = "buttonNilai";
            this.buttonNilai.Size = new System.Drawing.Size(168, 42);
            this.buttonNilai.TabIndex = 6;
            this.buttonNilai.Text = "Data Nilai";
            this.buttonNilai.UseVisualStyleBackColor = true;
            this.buttonNilai.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPrd
            // 
            this.buttonPrd.Location = new System.Drawing.Point(287, 308);
            this.buttonPrd.Name = "buttonPrd";
            this.buttonPrd.Size = new System.Drawing.Size(168, 42);
            this.buttonPrd.TabIndex = 7;
            this.buttonPrd.Text = "Data Periode";
            this.buttonPrd.UseVisualStyleBackColor = true;
            this.buttonPrd.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPrd);
            this.Controls.Add(this.buttonNilai);
            this.Controls.Add(this.buttonMhs);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMhs;
        private System.Windows.Forms.Button buttonNilai;
        private System.Windows.Forms.Button buttonPrd;
    }
}

