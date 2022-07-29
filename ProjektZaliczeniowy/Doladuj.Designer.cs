
namespace ProjektZaliczeniowy
{
    partial class Doladuj
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
            this.KwotaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.KwotaLabel = new System.Windows.Forms.Label();
            this.DoladujButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KwotaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doładuj konto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KwotaNumericUpDown
            // 
            this.KwotaNumericUpDown.Location = new System.Drawing.Point(37, 96);
            this.KwotaNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.KwotaNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.KwotaNumericUpDown.Name = "KwotaNumericUpDown";
            this.KwotaNumericUpDown.Size = new System.Drawing.Size(189, 20);
            this.KwotaNumericUpDown.TabIndex = 1;
            this.KwotaNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // KwotaLabel
            // 
            this.KwotaLabel.AutoSize = true;
            this.KwotaLabel.Location = new System.Drawing.Point(34, 80);
            this.KwotaLabel.Name = "KwotaLabel";
            this.KwotaLabel.Size = new System.Drawing.Size(37, 13);
            this.KwotaLabel.TabIndex = 2;
            this.KwotaLabel.Text = "Kwota";
            // 
            // DoladujButton
            // 
            this.DoladujButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DoladujButton.Location = new System.Drawing.Point(143, 148);
            this.DoladujButton.Name = "DoladujButton";
            this.DoladujButton.Size = new System.Drawing.Size(83, 31);
            this.DoladujButton.TabIndex = 3;
            this.DoladujButton.Text = "Doładuj";
            this.DoladujButton.UseVisualStyleBackColor = true;
            this.DoladujButton.Click += new System.EventHandler(this.DoladujButton_Click);
            // 
            // Doladuj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 217);
            this.Controls.Add(this.DoladujButton);
            this.Controls.Add(this.KwotaLabel);
            this.Controls.Add(this.KwotaNumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "Doladuj";
            this.Text = "Doladuj";
            ((System.ComponentModel.ISupportInitialize)(this.KwotaNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown KwotaNumericUpDown;
        private System.Windows.Forms.Label KwotaLabel;
        private System.Windows.Forms.Button DoladujButton;
    }
}