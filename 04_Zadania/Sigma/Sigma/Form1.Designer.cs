namespace Sigma
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
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCzySigma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(159, 132);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(150, 26);
            this.textBoxDateOfBirth.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(145, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // buttonCzySigma
            // 
            this.buttonCzySigma.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCzySigma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCzySigma.Location = new System.Drawing.Point(159, 173);
            this.buttonCzySigma.Name = "buttonCzySigma";
            this.buttonCzySigma.Size = new System.Drawing.Size(150, 50);
            this.buttonCzySigma.TabIndex = 2;
            this.buttonCzySigma.Text = "Sprawdź";
            this.buttonCzySigma.UseVisualStyleBackColor = false;
            this.buttonCzySigma.Click += new System.EventHandler(this.buttonCzySigma_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(69, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Podaj datę i sprawdż czy ta osoba jest sigmą.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCzySigma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDateOfBirth);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Program SIgma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCzySigma;
        private System.Windows.Forms.Label label2;
    }
}

