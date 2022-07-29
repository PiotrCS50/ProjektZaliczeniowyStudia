
namespace ProjektZaliczeniowy
{
    partial class LogowanieForm
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
            this.NazwaTextBox = new System.Windows.Forms.TextBox();
            this.HasloTextBox = new System.Windows.Forms.TextBox();
            this.ZalogujButton = new System.Windows.Forms.Button();
            this.nazwaLabel = new System.Windows.Forms.Label();
            this.HasloLabel = new System.Windows.Forms.Label();
            this.RejestracjaButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.WalidacjaNazwaLabel = new System.Windows.Forms.Label();
            this.walidacjaHasloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NazwaTextBox
            // 
            this.NazwaTextBox.Location = new System.Drawing.Point(44, 64);
            this.NazwaTextBox.Name = "NazwaTextBox";
            this.NazwaTextBox.Size = new System.Drawing.Size(262, 20);
            this.NazwaTextBox.TabIndex = 0;
            this.NazwaTextBox.TextChanged += new System.EventHandler(this.NazwaTextBox_TextChanged);
            this.NazwaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NazwaTextBox_Validating);
            // 
            // HasloTextBox
            // 
            this.HasloTextBox.Location = new System.Drawing.Point(44, 120);
            this.HasloTextBox.Name = "HasloTextBox";
            this.HasloTextBox.Size = new System.Drawing.Size(262, 20);
            this.HasloTextBox.TabIndex = 1;
            this.HasloTextBox.UseSystemPasswordChar = true;
            this.HasloTextBox.TextChanged += new System.EventHandler(this.HasloTextBox_TextChanged);
            this.HasloTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.HasloTextBox_Validating);
            // 
            // ZalogujButton
            // 
            this.ZalogujButton.Enabled = false;
            this.ZalogujButton.Location = new System.Drawing.Point(133, 160);
            this.ZalogujButton.Name = "ZalogujButton";
            this.ZalogujButton.Size = new System.Drawing.Size(91, 31);
            this.ZalogujButton.TabIndex = 2;
            this.ZalogujButton.Text = "Zaloguj";
            this.ZalogujButton.UseVisualStyleBackColor = true;
            this.ZalogujButton.Click += new System.EventHandler(this.ZalogujButton_Click);
            // 
            // nazwaLabel
            // 
            this.nazwaLabel.AutoSize = true;
            this.nazwaLabel.Location = new System.Drawing.Point(41, 48);
            this.nazwaLabel.Name = "nazwaLabel";
            this.nazwaLabel.Size = new System.Drawing.Size(40, 13);
            this.nazwaLabel.TabIndex = 3;
            this.nazwaLabel.Text = "Nazwa";
            // 
            // HasloLabel
            // 
            this.HasloLabel.AutoSize = true;
            this.HasloLabel.Location = new System.Drawing.Point(41, 104);
            this.HasloLabel.Name = "HasloLabel";
            this.HasloLabel.Size = new System.Drawing.Size(36, 13);
            this.HasloLabel.TabIndex = 4;
            this.HasloLabel.Text = "Hasło";
            // 
            // RejestracjaButton
            // 
            this.RejestracjaButton.Location = new System.Drawing.Point(133, 237);
            this.RejestracjaButton.Name = "RejestracjaButton";
            this.RejestracjaButton.Size = new System.Drawing.Size(91, 30);
            this.RejestracjaButton.TabIndex = 6;
            this.RejestracjaButton.Text = "Zarejestruj";
            this.RejestracjaButton.UseVisualStyleBackColor = true;
            this.RejestracjaButton.Click += new System.EventHandler(this.RejestracjaButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InfoLabel.Location = new System.Drawing.Point(33, 210);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(297, 13);
            this.InfoLabel.TabIndex = 7;
            this.InfoLabel.Text = "Jeśli nie posiadasz konta załóż je, klikając przycisk zarejestruj";
            // 
            // WalidacjaNazwaLabel
            // 
            this.WalidacjaNazwaLabel.AutoSize = true;
            this.WalidacjaNazwaLabel.CausesValidation = false;
            this.WalidacjaNazwaLabel.Location = new System.Drawing.Point(150, 87);
            this.WalidacjaNazwaLabel.Name = "WalidacjaNazwaLabel";
            this.WalidacjaNazwaLabel.Size = new System.Drawing.Size(35, 13);
            this.WalidacjaNazwaLabel.TabIndex = 8;
            this.WalidacjaNazwaLabel.Text = "label1";
            this.WalidacjaNazwaLabel.Visible = false;
            // 
            // walidacjaHasloLabel
            // 
            this.walidacjaHasloLabel.AutoSize = true;
            this.walidacjaHasloLabel.CausesValidation = false;
            this.walidacjaHasloLabel.Location = new System.Drawing.Point(150, 143);
            this.walidacjaHasloLabel.Name = "walidacjaHasloLabel";
            this.walidacjaHasloLabel.Size = new System.Drawing.Size(35, 13);
            this.walidacjaHasloLabel.TabIndex = 9;
            this.walidacjaHasloLabel.Text = "label2";
            this.walidacjaHasloLabel.Visible = false;
            // 
            // LogowanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 322);
            this.Controls.Add(this.walidacjaHasloLabel);
            this.Controls.Add(this.WalidacjaNazwaLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.RejestracjaButton);
            this.Controls.Add(this.HasloLabel);
            this.Controls.Add(this.nazwaLabel);
            this.Controls.Add(this.ZalogujButton);
            this.Controls.Add(this.HasloTextBox);
            this.Controls.Add(this.NazwaTextBox);
            this.MaximumSize = new System.Drawing.Size(358, 361);
            this.MinimumSize = new System.Drawing.Size(358, 361);
            this.Name = "LogowanieForm";
            this.Text = "LogowanieForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NazwaTextBox;
        private System.Windows.Forms.TextBox HasloTextBox;
        private System.Windows.Forms.Button ZalogujButton;
        private System.Windows.Forms.Label nazwaLabel;
        private System.Windows.Forms.Label HasloLabel;
        private System.Windows.Forms.Button RejestracjaButton;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label WalidacjaNazwaLabel;
        private System.Windows.Forms.Label walidacjaHasloLabel;
    }
}