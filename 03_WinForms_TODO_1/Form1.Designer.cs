namespace _03_lekcja
{
    partial class Form1
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
            this.textBoxNumber_1 = new System.Windows.Forms.TextBox();
            this.textBoxNumber_2 = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonCzyZaprzyjaznione = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNumber_1
            // 
            this.textBoxNumber_1.Location = new System.Drawing.Point(38, 38);
            this.textBoxNumber_1.Name = "textBoxNumber_1";
            this.textBoxNumber_1.Size = new System.Drawing.Size(47, 20);
            this.textBoxNumber_1.TabIndex = 0;
            // 
            // textBoxNumber_2
            // 
            this.textBoxNumber_2.Location = new System.Drawing.Point(38, 64);
            this.textBoxNumber_2.Name = "textBoxNumber_2";
            this.textBoxNumber_2.Size = new System.Drawing.Size(47, 20);
            this.textBoxNumber_2.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(72, 97);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Wynik";
            // 
            // buttonCzyZaprzyjaznione
            // 
            this.buttonCzyZaprzyjaznione.Location = new System.Drawing.Point(91, 52);
            this.buttonCzyZaprzyjaznione.Name = "buttonCzyZaprzyjaznione";
            this.buttonCzyZaprzyjaznione.Size = new System.Drawing.Size(46, 23);
            this.buttonCzyZaprzyjaznione.TabIndex = 3;
            this.buttonCzyZaprzyjaznione.Text = "Sprawdź";
            this.buttonCzyZaprzyjaznione.UseVisualStyleBackColor = true;
            this.buttonCzyZaprzyjaznione.Click += new System.EventHandler(this.buttonCzyZaprzyjaznione_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(181, 158);
            this.Controls.Add(this.buttonCzyZaprzyjaznione);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxNumber_2);
            this.Controls.Add(this.textBoxNumber_1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumber_1;
        private System.Windows.Forms.TextBox textBoxNumber_2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCzyZaprzyjaznione;
    }
}

