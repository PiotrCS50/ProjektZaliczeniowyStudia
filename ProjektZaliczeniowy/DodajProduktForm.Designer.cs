
namespace ProjektZaliczeniowy
{
    partial class DodajProduktForm
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
            this.KategoriaLabel = new System.Windows.Forms.Label();
            this.OpisLabel = new System.Windows.Forms.Label();
            this.CenaLabel = new System.Windows.Forms.Label();
            this.NazwaTextBox = new System.Windows.Forms.TextBox();
            this.OpisTextBox = new System.Windows.Forms.TextBox();
            this.KategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.DodajButton = new System.Windows.Forms.Button();
            this.CenaTextBox = new System.Windows.Forms.TextBox();
            this.WalidacjaCenaLabel = new System.Windows.Forms.Label();
            this.WalidacjaNazwaLabel = new System.Windows.Forms.Label();
            this.WalidacjaOpisLabel = new System.Windows.Forms.Label();
            this.WalidacjaKategoriaLabel = new System.Windows.Forms.Label();
            this.IloscLabel = new System.Windows.Forms.Label();
            this.IloscNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WalidacjaIloscLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IloscNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TytulLabel
            // 
            this.TytulLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TytulLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TytulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TytulLabel.Location = new System.Drawing.Point(0, 0);
            this.TytulLabel.Name = "TytulLabel";
            this.TytulLabel.Size = new System.Drawing.Size(484, 38);
            this.TytulLabel.TabIndex = 0;
            this.TytulLabel.Text = "Dodaj produkt";
            this.TytulLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NazwaLabel
            // 
            this.NazwaLabel.AutoSize = true;
            this.NazwaLabel.Location = new System.Drawing.Point(12, 77);
            this.NazwaLabel.Name = "NazwaLabel";
            this.NazwaLabel.Size = new System.Drawing.Size(40, 13);
            this.NazwaLabel.TabIndex = 1;
            this.NazwaLabel.Text = "Nazwa";
            // 
            // KategoriaLabel
            // 
            this.KategoriaLabel.AutoSize = true;
            this.KategoriaLabel.Location = new System.Drawing.Point(12, 127);
            this.KategoriaLabel.Name = "KategoriaLabel";
            this.KategoriaLabel.Size = new System.Drawing.Size(52, 13);
            this.KategoriaLabel.TabIndex = 2;
            this.KategoriaLabel.Text = "Kategoria";
            // 
            // OpisLabel
            // 
            this.OpisLabel.AutoSize = true;
            this.OpisLabel.Location = new System.Drawing.Point(12, 180);
            this.OpisLabel.Name = "OpisLabel";
            this.OpisLabel.Size = new System.Drawing.Size(28, 13);
            this.OpisLabel.TabIndex = 3;
            this.OpisLabel.Text = "Opis";
            // 
            // CenaLabel
            // 
            this.CenaLabel.AutoSize = true;
            this.CenaLabel.Location = new System.Drawing.Point(12, 315);
            this.CenaLabel.Name = "CenaLabel";
            this.CenaLabel.Size = new System.Drawing.Size(32, 13);
            this.CenaLabel.TabIndex = 4;
            this.CenaLabel.Text = "Cena";
            // 
            // NazwaTextBox
            // 
            this.NazwaTextBox.Location = new System.Drawing.Point(12, 93);
            this.NazwaTextBox.Name = "NazwaTextBox";
            this.NazwaTextBox.Size = new System.Drawing.Size(460, 20);
            this.NazwaTextBox.TabIndex = 1;
            this.NazwaTextBox.TextChanged += new System.EventHandler(this.NazwaTextBox_TextChanged);
            this.NazwaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NazwaTextBox_Validating);
            // 
            // OpisTextBox
            // 
            this.OpisTextBox.Location = new System.Drawing.Point(12, 196);
            this.OpisTextBox.Multiline = true;
            this.OpisTextBox.Name = "OpisTextBox";
            this.OpisTextBox.Size = new System.Drawing.Size(460, 103);
            this.OpisTextBox.TabIndex = 3;
            this.OpisTextBox.TextChanged += new System.EventHandler(this.OpisTextBox_TextChanged);
            this.OpisTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.OpisTextBox_Validating);
            // 
            // KategoriaComboBox
            // 
            this.KategoriaComboBox.FormattingEnabled = true;
            this.KategoriaComboBox.Location = new System.Drawing.Point(12, 143);
            this.KategoriaComboBox.Name = "KategoriaComboBox";
            this.KategoriaComboBox.Size = new System.Drawing.Size(460, 21);
            this.KategoriaComboBox.TabIndex = 2;
            this.KategoriaComboBox.TextChanged += new System.EventHandler(this.KategoriaComboBox_TextChanged);
            this.KategoriaComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.KategoriaComboBox_Validating);
            // 
            // DodajButton
            // 
            this.DodajButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DodajButton.Enabled = false;
            this.DodajButton.Location = new System.Drawing.Point(320, 400);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(152, 49);
            this.DodajButton.TabIndex = 6;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // CenaTextBox
            // 
            this.CenaTextBox.Location = new System.Drawing.Point(12, 331);
            this.CenaTextBox.Name = "CenaTextBox";
            this.CenaTextBox.Size = new System.Drawing.Size(138, 20);
            this.CenaTextBox.TabIndex = 4;
            this.CenaTextBox.TextChanged += new System.EventHandler(this.CenaTextBox_TextChanged);
            this.CenaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CenaTextBox_KeyPress);
            this.CenaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CenaTextBox_Validating);
            // 
            // WalidacjaCenaLabel
            // 
            this.WalidacjaCenaLabel.AutoSize = true;
            this.WalidacjaCenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WalidacjaCenaLabel.Location = new System.Drawing.Point(37, 354);
            this.WalidacjaCenaLabel.Name = "WalidacjaCenaLabel";
            this.WalidacjaCenaLabel.Size = new System.Drawing.Size(67, 13);
            this.WalidacjaCenaLabel.TabIndex = 16;
            this.WalidacjaCenaLabel.Text = "Bledna cena";
            this.WalidacjaCenaLabel.Visible = false;
            // 
            // WalidacjaNazwaLabel
            // 
            this.WalidacjaNazwaLabel.AutoSize = true;
            this.WalidacjaNazwaLabel.CausesValidation = false;
            this.WalidacjaNazwaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WalidacjaNazwaLabel.Location = new System.Drawing.Point(187, 116);
            this.WalidacjaNazwaLabel.Name = "WalidacjaNazwaLabel";
            this.WalidacjaNazwaLabel.Size = new System.Drawing.Size(74, 13);
            this.WalidacjaNazwaLabel.TabIndex = 13;
            this.WalidacjaNazwaLabel.Text = "Bledna nazwa";
            this.WalidacjaNazwaLabel.Visible = false;
            // 
            // WalidacjaOpisLabel
            // 
            this.WalidacjaOpisLabel.AutoSize = true;
            this.WalidacjaOpisLabel.CausesValidation = false;
            this.WalidacjaOpisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WalidacjaOpisLabel.Location = new System.Drawing.Point(187, 302);
            this.WalidacjaOpisLabel.Name = "WalidacjaOpisLabel";
            this.WalidacjaOpisLabel.Size = new System.Drawing.Size(61, 13);
            this.WalidacjaOpisLabel.TabIndex = 15;
            this.WalidacjaOpisLabel.Text = "Bledny opis";
            this.WalidacjaOpisLabel.Visible = false;
            // 
            // WalidacjaKategoriaLabel
            // 
            this.WalidacjaKategoriaLabel.AutoSize = true;
            this.WalidacjaKategoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WalidacjaKategoriaLabel.Location = new System.Drawing.Point(187, 167);
            this.WalidacjaKategoriaLabel.Name = "WalidacjaKategoriaLabel";
            this.WalidacjaKategoriaLabel.Size = new System.Drawing.Size(87, 13);
            this.WalidacjaKategoriaLabel.TabIndex = 14;
            this.WalidacjaKategoriaLabel.Text = "Bledna kategoria";
            this.WalidacjaKategoriaLabel.Visible = false;
            // 
            // IloscLabel
            // 
            this.IloscLabel.AutoSize = true;
            this.IloscLabel.Location = new System.Drawing.Point(317, 315);
            this.IloscLabel.Name = "IloscLabel";
            this.IloscLabel.Size = new System.Drawing.Size(29, 13);
            this.IloscLabel.TabIndex = 17;
            this.IloscLabel.Text = "Ilość";
            // 
            // IloscNumericUpDown
            // 
            this.IloscNumericUpDown.Location = new System.Drawing.Point(320, 332);
            this.IloscNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.IloscNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IloscNumericUpDown.Name = "IloscNumericUpDown";
            this.IloscNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.IloscNumericUpDown.TabIndex = 5;
            this.IloscNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IloscNumericUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.IloscNumericUpDown_Validating);
            // 
            // WalidacjaIloscLabel
            // 
            this.WalidacjaIloscLabel.AutoSize = true;
            this.WalidacjaIloscLabel.Location = new System.Drawing.Point(344, 354);
            this.WalidacjaIloscLabel.Name = "WalidacjaIloscLabel";
            this.WalidacjaIloscLabel.Size = new System.Drawing.Size(64, 13);
            this.WalidacjaIloscLabel.TabIndex = 19;
            this.WalidacjaIloscLabel.Text = "Bledna ilosc";
            this.WalidacjaIloscLabel.Visible = false;
            // 
            // DodajProduktForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.WalidacjaIloscLabel);
            this.Controls.Add(this.IloscNumericUpDown);
            this.Controls.Add(this.IloscLabel);
            this.Controls.Add(this.WalidacjaCenaLabel);
            this.Controls.Add(this.WalidacjaOpisLabel);
            this.Controls.Add(this.WalidacjaKategoriaLabel);
            this.Controls.Add(this.WalidacjaNazwaLabel);
            this.Controls.Add(this.CenaTextBox);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.KategoriaComboBox);
            this.Controls.Add(this.OpisTextBox);
            this.Controls.Add(this.NazwaTextBox);
            this.Controls.Add(this.CenaLabel);
            this.Controls.Add(this.OpisLabel);
            this.Controls.Add(this.KategoriaLabel);
            this.Controls.Add(this.NazwaLabel);
            this.Controls.Add(this.TytulLabel);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.Name = "DodajProduktForm";
            this.Text = "DodajProduktForm";
            this.Load += new System.EventHandler(this.DodajProduktForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IloscNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TytulLabel;
        private System.Windows.Forms.Label NazwaLabel;
        private System.Windows.Forms.Label KategoriaLabel;
        private System.Windows.Forms.Label OpisLabel;
        private System.Windows.Forms.Label CenaLabel;
        private System.Windows.Forms.TextBox NazwaTextBox;
        private System.Windows.Forms.TextBox OpisTextBox;
        private System.Windows.Forms.ComboBox KategoriaComboBox;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.TextBox CenaTextBox;
        private System.Windows.Forms.Label WalidacjaCenaLabel;
        private System.Windows.Forms.Label WalidacjaNazwaLabel;
        private System.Windows.Forms.Label WalidacjaOpisLabel;
        private System.Windows.Forms.Label WalidacjaKategoriaLabel;
        private System.Windows.Forms.Label IloscLabel;
        private System.Windows.Forms.NumericUpDown IloscNumericUpDown;
        private System.Windows.Forms.Label WalidacjaIloscLabel;
    }
}