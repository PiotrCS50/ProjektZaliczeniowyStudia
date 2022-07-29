
namespace ProjektZaliczeniowy
{
    partial class DaneUzytkownikaForm
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
            this.TytulLabel = new System.Windows.Forms.Label();
            this.NazwaTextBox = new System.Windows.Forms.TextBox();
            this.ImieTextBox = new System.Windows.Forms.TextBox();
            this.NazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.NazwaLabel = new System.Windows.Forms.Label();
            this.ImieLabel = new System.Windows.Forms.Label();
            this.NazwiskoLabel = new System.Windows.Forms.Label();
            this.ZapiszButton = new System.Windows.Forms.Button();
            this.WalidacjaNazwaLabel = new System.Windows.Forms.Label();
            this.WalidacjaImieLabel = new System.Windows.Forms.Label();
            this.WalidacjaNazwiskoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TytulLabel
            // 
            this.TytulLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TytulLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TytulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TytulLabel.Location = new System.Drawing.Point(0, 0);
            this.TytulLabel.Name = "TytulLabel";
            this.TytulLabel.Size = new System.Drawing.Size(423, 48);
            this.TytulLabel.TabIndex = 0;
            this.TytulLabel.Text = "label1";
            this.TytulLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NazwaTextBox
            // 
            this.NazwaTextBox.Location = new System.Drawing.Point(31, 83);
            this.NazwaTextBox.Name = "NazwaTextBox";
            this.NazwaTextBox.Size = new System.Drawing.Size(360, 20);
            this.NazwaTextBox.TabIndex = 1;
            this.NazwaTextBox.TextChanged += new System.EventHandler(this.NazwaTextBox_TextChanged);
            this.NazwaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NazwaTextBox_Validating);
            // 
            // ImieTextBox
            // 
            this.ImieTextBox.Location = new System.Drawing.Point(31, 132);
            this.ImieTextBox.Name = "ImieTextBox";
            this.ImieTextBox.Size = new System.Drawing.Size(360, 20);
            this.ImieTextBox.TabIndex = 2;
            this.ImieTextBox.TextChanged += new System.EventHandler(this.ImieTextBox_TextChanged);
            this.ImieTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ImieTextBox_Validating);
            // 
            // NazwiskoTextBox
            // 
            this.NazwiskoTextBox.Location = new System.Drawing.Point(31, 185);
            this.NazwiskoTextBox.Name = "NazwiskoTextBox";
            this.NazwiskoTextBox.Size = new System.Drawing.Size(360, 20);
            this.NazwiskoTextBox.TabIndex = 3;
            this.NazwiskoTextBox.TextChanged += new System.EventHandler(this.NazwiskoTextBox_TextChanged);
            this.NazwiskoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NazwiskoTextBox_Validating);
            // 
            // NazwaLabel
            // 
            this.NazwaLabel.AutoSize = true;
            this.NazwaLabel.Location = new System.Drawing.Point(28, 67);
            this.NazwaLabel.Name = "NazwaLabel";
            this.NazwaLabel.Size = new System.Drawing.Size(40, 13);
            this.NazwaLabel.TabIndex = 5;
            this.NazwaLabel.Text = "Nazwa";
            // 
            // ImieLabel
            // 
            this.ImieLabel.AutoSize = true;
            this.ImieLabel.Location = new System.Drawing.Point(28, 116);
            this.ImieLabel.Name = "ImieLabel";
            this.ImieLabel.Size = new System.Drawing.Size(26, 13);
            this.ImieLabel.TabIndex = 6;
            this.ImieLabel.Text = "Imie";
            // 
            // NazwiskoLabel
            // 
            this.NazwiskoLabel.AutoSize = true;
            this.NazwiskoLabel.Location = new System.Drawing.Point(28, 169);
            this.NazwiskoLabel.Name = "NazwiskoLabel";
            this.NazwiskoLabel.Size = new System.Drawing.Size(53, 13);
            this.NazwiskoLabel.TabIndex = 7;
            this.NazwiskoLabel.Text = "Nazwisko";
            // 
            // ZapiszButton
            // 
            this.ZapiszButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ZapiszButton.Enabled = false;
            this.ZapiszButton.Location = new System.Drawing.Point(296, 231);
            this.ZapiszButton.Name = "ZapiszButton";
            this.ZapiszButton.Size = new System.Drawing.Size(95, 33);
            this.ZapiszButton.TabIndex = 9;
            this.ZapiszButton.Text = "Zapisz";
            this.ZapiszButton.UseVisualStyleBackColor = true;
            this.ZapiszButton.Click += new System.EventHandler(this.ZapiszButton_Click);
            // 
            // WalidacjaNazwaLabel
            // 
            this.WalidacjaNazwaLabel.AutoSize = true;
            this.WalidacjaNazwaLabel.Location = new System.Drawing.Point(92, 106);
            this.WalidacjaNazwaLabel.Name = "WalidacjaNazwaLabel";
            this.WalidacjaNazwaLabel.Size = new System.Drawing.Size(35, 13);
            this.WalidacjaNazwaLabel.TabIndex = 10;
            this.WalidacjaNazwaLabel.Text = "label1";
            this.WalidacjaNazwaLabel.Visible = false;
            // 
            // WalidacjaImieLabel
            // 
            this.WalidacjaImieLabel.AutoSize = true;
            this.WalidacjaImieLabel.Location = new System.Drawing.Point(92, 155);
            this.WalidacjaImieLabel.Name = "WalidacjaImieLabel";
            this.WalidacjaImieLabel.Size = new System.Drawing.Size(35, 13);
            this.WalidacjaImieLabel.TabIndex = 11;
            this.WalidacjaImieLabel.Text = "label2";
            this.WalidacjaImieLabel.Visible = false;
            // 
            // WalidacjaNazwiskoLabel
            // 
            this.WalidacjaNazwiskoLabel.AutoSize = true;
            this.WalidacjaNazwiskoLabel.Location = new System.Drawing.Point(92, 208);
            this.WalidacjaNazwiskoLabel.Name = "WalidacjaNazwiskoLabel";
            this.WalidacjaNazwiskoLabel.Size = new System.Drawing.Size(35, 13);
            this.WalidacjaNazwiskoLabel.TabIndex = 12;
            this.WalidacjaNazwiskoLabel.Text = "label3";
            this.WalidacjaNazwiskoLabel.Visible = false;
            // 
            // DaneUzytkownikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 289);
            this.Controls.Add(this.WalidacjaNazwiskoLabel);
            this.Controls.Add(this.WalidacjaImieLabel);
            this.Controls.Add(this.WalidacjaNazwaLabel);
            this.Controls.Add(this.ZapiszButton);
            this.Controls.Add(this.NazwiskoLabel);
            this.Controls.Add(this.ImieLabel);
            this.Controls.Add(this.NazwaLabel);
            this.Controls.Add(this.NazwiskoTextBox);
            this.Controls.Add(this.ImieTextBox);
            this.Controls.Add(this.NazwaTextBox);
            this.Controls.Add(this.TytulLabel);
            this.MaximumSize = new System.Drawing.Size(439, 328);
            this.MinimumSize = new System.Drawing.Size(439, 328);
            this.Name = "DaneUzytkownikaForm";
            this.Text = "DaneUzytkownikaForm";
            this.Load += new System.EventHandler(this.DaneUzytkownikaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TytulLabel;
        private System.Windows.Forms.TextBox NazwaTextBox;
        private System.Windows.Forms.TextBox ImieTextBox;
        private System.Windows.Forms.TextBox NazwiskoTextBox;
        private System.Windows.Forms.Label NazwaLabel;
        private System.Windows.Forms.Label ImieLabel;
        private System.Windows.Forms.Label NazwiskoLabel;
        private System.Windows.Forms.Button ZapiszButton;
        private System.Windows.Forms.Label WalidacjaNazwaLabel;
        private System.Windows.Forms.Label WalidacjaImieLabel;
        private System.Windows.Forms.Label WalidacjaNazwiskoLabel;
    }
}