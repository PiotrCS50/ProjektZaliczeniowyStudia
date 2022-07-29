
namespace ProjektZaliczeniowy
{
    partial class DodajMagazynForm
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
            this.NazwaLabel = new System.Windows.Forms.Label();
            this.CzyDomyslnyCheckBox = new System.Windows.Forms.CheckBox();
            this.NazwaTextBox = new System.Windows.Forms.TextBox();
            this.DodajButton = new System.Windows.Forms.Button();
            this.WalidacjaNazwaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TytulLabel
            // 
            this.TytulLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TytulLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TytulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TytulLabel.Location = new System.Drawing.Point(0, 0);
            this.TytulLabel.Name = "TytulLabel";
            this.TytulLabel.Size = new System.Drawing.Size(374, 38);
            this.TytulLabel.TabIndex = 0;
            this.TytulLabel.Text = "Dodaj magazyn";
            this.TytulLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NazwaLabel
            // 
            this.NazwaLabel.AutoSize = true;
            this.NazwaLabel.Location = new System.Drawing.Point(12, 94);
            this.NazwaLabel.Name = "NazwaLabel";
            this.NazwaLabel.Size = new System.Drawing.Size(40, 13);
            this.NazwaLabel.TabIndex = 1;
            this.NazwaLabel.Text = "Nazwa";
            // 
            // CzyDomyslnyCheckBox
            // 
            this.CzyDomyslnyCheckBox.AutoSize = true;
            this.CzyDomyslnyCheckBox.Location = new System.Drawing.Point(12, 155);
            this.CzyDomyslnyCheckBox.Name = "CzyDomyslnyCheckBox";
            this.CzyDomyslnyCheckBox.Size = new System.Drawing.Size(71, 17);
            this.CzyDomyslnyCheckBox.TabIndex = 3;
            this.CzyDomyslnyCheckBox.Text = "Domyślny";
            this.CzyDomyslnyCheckBox.UseVisualStyleBackColor = true;
            // 
            // NazwaTextBox
            // 
            this.NazwaTextBox.Location = new System.Drawing.Point(12, 110);
            this.NazwaTextBox.Name = "NazwaTextBox";
            this.NazwaTextBox.Size = new System.Drawing.Size(350, 20);
            this.NazwaTextBox.TabIndex = 4;
            this.NazwaTextBox.TextChanged += new System.EventHandler(this.NazwaTextBox_TextChanged);
            this.NazwaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NazwaTextBox_Validating);
            // 
            // DodajButton
            // 
            this.DodajButton.Enabled = false;
            this.DodajButton.Location = new System.Drawing.Point(265, 218);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(97, 33);
            this.DodajButton.TabIndex = 5;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // WalidacjaNazwaLabel
            // 
            this.WalidacjaNazwaLabel.AutoSize = true;
            this.WalidacjaNazwaLabel.Location = new System.Drawing.Point(164, 133);
            this.WalidacjaNazwaLabel.Name = "WalidacjaNazwaLabel";
            this.WalidacjaNazwaLabel.Size = new System.Drawing.Size(35, 13);
            this.WalidacjaNazwaLabel.TabIndex = 6;
            this.WalidacjaNazwaLabel.Text = "label1";
            this.WalidacjaNazwaLabel.Visible = false;
            // 
            // DodajMagazynForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 263);
            this.Controls.Add(this.WalidacjaNazwaLabel);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.NazwaTextBox);
            this.Controls.Add(this.CzyDomyslnyCheckBox);
            this.Controls.Add(this.NazwaLabel);
            this.Controls.Add(this.TytulLabel);
            this.Name = "DodajMagazynForm";
            this.Text = "DodajMagazynForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NazwaLabel;
        private System.Windows.Forms.Label WalidacjaNazwaLabel;
        public System.Windows.Forms.Label TytulLabel;
        public System.Windows.Forms.CheckBox CzyDomyslnyCheckBox;
        public System.Windows.Forms.TextBox NazwaTextBox;
        public System.Windows.Forms.Button DodajButton;
    }
}