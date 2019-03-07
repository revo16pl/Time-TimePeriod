namespace TimeTimePeriod.StoperGUI
{
    partial class minutnik
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(minutnik));
            this.button_start = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.label_minutnik = new System.Windows.Forms.Label();
            this.pictureBox_minutnik = new System.Windows.Forms.PictureBox();
            this.button_Stop = new System.Windows.Forms.Button();
            this.Label_licznik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minutnik)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(175, 228);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(84, 88);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_ClickAsync);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(50, 228);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(84, 88);
            this.button_reset.TabIndex = 6;
            this.button_reset.Text = "RESET";
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // label_minutnik
            // 
            this.label_minutnik.AutoSize = true;
            this.label_minutnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_minutnik.Location = new System.Drawing.Point(106, 41);
            this.label_minutnik.Name = "label_minutnik";
            this.label_minutnik.Size = new System.Drawing.Size(132, 33);
            this.label_minutnik.TabIndex = 4;
            this.label_minutnik.Text = "Minutnik";
            // 
            // pictureBox_minutnik
            // 
            this.pictureBox_minutnik.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_minutnik.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_minutnik.Image")));
            this.pictureBox_minutnik.Location = new System.Drawing.Point(50, 27);
            this.pictureBox_minutnik.Name = "pictureBox_minutnik";
            this.pictureBox_minutnik.Size = new System.Drawing.Size(50, 59);
            this.pictureBox_minutnik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_minutnik.TabIndex = 5;
            this.pictureBox_minutnik.TabStop = false;
            // 
            // button_Stop
            // 
            this.button_Stop.Enabled = false;
            this.button_Stop.Location = new System.Drawing.Point(175, 228);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(84, 88);
            this.button_Stop.TabIndex = 7;
            this.button_Stop.Text = "STOP";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Visible = false;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_ClickAsync);
            // 
            // Label_licznik
            // 
            this.Label_licznik.AutoSize = true;
            this.Label_licznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_licznik.Location = new System.Drawing.Point(89, 171);
            this.Label_licznik.Name = "Label_licznik";
            this.Label_licznik.Size = new System.Drawing.Size(135, 33);
            this.Label_licznik.TabIndex = 3;
            this.Label_licznik.Text = "00:00:00";
            // 
            // minutnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 348);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.pictureBox_minutnik);
            this.Controls.Add(this.label_minutnik);
            this.Controls.Add(this.Label_licznik);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_start);
            this.Name = "minutnik";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minutnik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label_minutnik;
        private System.Windows.Forms.PictureBox pictureBox_minutnik;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Label Label_licznik;
    }
}

