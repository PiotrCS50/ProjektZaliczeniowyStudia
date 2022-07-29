
namespace ProjektZaliczeniowy
{
    partial class EdytujProduktForm
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
            this.OpisLabel = new System.Windows.Forms.Label();
            this.KategoriaLabel = new System.Windows.Forms.Label();
            this.IloscLabel = new System.Windows.Forms.Label();
            this.CenaLabel = new System.Windows.Forms.Label();
            this.NazwaTextBox = new System.Windows.Forms.TextBox();
            this.OpisTextBox = new System.Windows.Forms.TextBox();
            this.CenaTextBox = new System.Windows.Forms.TextBox();
            this.KategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.IloscNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EdytujButton = new System.Windows.Forms.Button();
            this.WalidacjaNazwaLabel = new System.Windows.Forms.Label();
            this.WalidacjaKategoriaLabel = new System.Windows.Forms.Label();
            this.WalidacjaOpisLabel = new System.Windows.Forms.Label();
            this.WalidacjaCenaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IloscNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TytulLabel
            // 
            this.TytulLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TytulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TytulLabel.Location = new System.Drawing.Point(0, 0);
            this.TytulLabel.Name = "TytulLabel";
            this.TytulLabel.Size = new System.Drawing.Size(491, 23);
            this.TytulLabel.TabIndex = 0;
            this.TytulLabel.Text = "Eycja produktu: Nazwa";
            this.TytulLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NazwaLabel
            // 
            this.NazwaLabel.AutoSize = true;
            this.NazwaLabel.Location = new System.Drawing.Point(63, 79);
            this.NazwaLabel.Name = "NazwaLabel";
            this.NazwaLabel.Size = new System.Drawing.Size(40, 13);
            this.NazwaLabel.TabIndex = 1;
            this.NazwaLabel.Text = "Nazwa";
            // 
            // OpisLabel
            // 
            this.OpisLabel.AutoSize = true;
            this.OpisLabel.Location = new System.Drawing.Point(64, 159);
            this.OpisLabel.Name = "OpisLabel";
            this.OpisLabel.Size = new System.Drawing.Size(28, 13);
            this.OpisLabel.TabIndex = 2;
            this.OpisLabel.Text = "Opis";
            // 
            // KategoriaLabel
            // 
            this.KategoriaLabel.AutoSize = true;
            this.KategoriaLabel.Location = new System.Drawing.Point(63, 119);
            this.KategoriaLabel.Name = "KategoriaLabel";
            this.KategoriaLabel.Size = new System.Drawing.Size(52, 13);
            this.KategoriaLabel.TabIndex = 3;
            this.KategoriaLabel.Text = "Kategoria";
            // 
            // IloscLabel
            // 
            this.IloscLabel.AutoSize = true;
            this.IloscLabel.Location = new System.Drawing.Point(249, 316);
            this.IloscLabel.Name = "IloscLabel";
            this.IloscLabel.Size = new System.Drawing.Size(29, 13);
            this.IloscLabel.TabIndex = 4;
            this.IloscLabel.Text = "Ilość";
            // 
            // CenaLabel
            // 
            this.CenaLabel.AutoSize = true;
            this.CenaLabel.Location = new System.Drawing.Point(63, 316);
            this.CenaLabel.Name = "CenaLabel";
            this.CenaLabel.Size = new System.Drawing.Size(32, 13);
            this.CenaLabel.TabIndex = 5;
            this.CenaLabel.Text = "Cena";
            // 
            // NazwaTextBox
            // 
            this.NazwaTextBox.Location = new System.Drawing.Point(66, 96);
            this.NazwaTextBox.Name = "NazwaTextBox";
            this.NazwaTextBox.Size = new System.Drawing.Size(365, 20);
            this.NazwaTextBox.TabIndex = 6;
            this.NazwaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NazwaTextBox_Validating);
            // 
            // OpisTextBox
            // 
            this.OpisTextBox.Location = new System.Drawing.Point(66, 175);
            this.OpisTextBox.Multiline = true;
            this.OpisTextBox.Name = "OpisTextBox";
            this.OpisTextBox.Size = new System.Drawing.Size(365, 129);
            this.OpisTextBox.TabIndex = 7;
            this.OpisTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.OpisTextBox_Validating);
            // 
            // CenaTextBox
            // 
            this.CenaTextBox.Location = new System.Drawing.Point(66, 332);
            this.CenaTextBox.Name = "CenaTextBox";
            this.CenaTextBox.Size = new System.Drawing.Size(158, 20);
            this.CenaTextBox.TabIndex = 8;
            this.CenaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CenaTextBox_KeyPress);
            this.CenaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CenaTextBox_Validating);
            // 
            // KategoriaComboBox
            // 
            this.KategoriaComboBox.FormattingEnabled = true;
            this.KategoriaComboBox.Location = new System.Drawing.Point(66, 135);
            this.KategoriaComboBox.Name = "KategoriaComboBox";
            this.KategoriaComboBox.Size = new System.Drawing.Size(365, 21);
            this.KategoriaComboBox.TabIndex = 9;
            this.KategoriaComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.KategoriaComboBox_Validating);
            // 
            // IloscNumericUpDown
            // 
            this.IloscNumericUpDown.Location = new System.Drawing.Point(252, 332);
            this.IloscNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.IloscNumericUpDown.Name = "IloscNumericUpDown";
            this.IloscNumericUpDown.Size = new System.Drawing.Size(179, 20);
            this.IloscNumericUpDown.TabIndex = 10;
            // 
            // EdytujButton
            // 
            this.EdytujButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.EdytujButton.Location = new System.Drawing.Point(327, 391);
            this.EdytujButton.Name = "EdytujButton";
            this.EdytujButton.Size = new System.Drawing.Size(104, 47);
            this.EdytujButton.TabIndex = 11;
            this.EdytujButton.Text = "Edytuj";
            this.EdytujButton.UseVisualStyleBackColor = true;
            this.EdytujButton.Click += new System.EventHandler(this.EdytujButton_Click);
            // 
            // WalidacjaNazwaLabel
            // 
            this.WalidacjaNazwaLabel.AutoSize = true;
            this.WalidacjaNazwaLabel.Location = new System.Drawing.Point(228, 119);
            this.WalidacjaNazwaLabel.Name = "WalidacjaNazwaLabel";
            this.WalidacjaNazwaLabel.Size = new System.Drawing.Size(35, 13);
            this.WalidacjaNazwaLabel.TabIndex = 12;
            this.WalidacjaNazwaLabel.Text = "label1";
            this.WalidacjaNazwaLabel.Visible = false;
            // 
            // WalidacjaKategoriaLabel
            // 
            this.WalidacjaKategoriaLabel.AutoSize = true;
            this.WalidacjaKategoriaLabel.Location = new System.Drawing.Point(228, 159);
            this.WalidacjaKategoriaLabel.Name = "WalidacjaKategoriaLabel";
            this.WalidacjaKategoriaLabel.Size = new System.Drawing.Size(35, 13);
            this.WalidacjaKategoriaLabel.TabIndex = 13;
            this.WalidacjaKategoriaLabel.Text = "label2";
            this.WalidacjaKategoriaLabel.Visible = false;
            // 
            // WalidacjaOpisLabel
            // 
            this.WalidacjaOpisLabel.AutoSize = true;
            this.WalidacjaOpisLabel.Location = new System.Drawing.Point(228, 303);
            this.WalidacjaOpisLabel.Name = "WalidacjaOpisLabel";
            this.WalidacjaOpisLabel.Size = new System.Drawing.Size(35, 13);
            this.WalidacjaOpisLabel.TabIndex = 14;
            this.WalidacjaOpisLabel.Text = "label3";
            this.WalidacjaOpisLabel.Visible = false;
            // 
            // WalidacjaCenaLabel
            // 
            this.WalidacjaCenaLabel.AutoSize = true;
            this.WalidacjaCenaLabel.Location = new System.Drawing.Point(117, 355);
            this.WalidacjaCenaLabel.Name = "WalidacjaCenaLabel";
            this.WalidacjaCenaLabel.Size = new System.Drawing.Size(35, 13);
            this.WalidacjaCenaLabel.TabIndex = 15;
            this.WalidacjaCenaLabel.Text = "label4";
            this.WalidacjaCenaLabel.Visible = false;
            // 
            // EdytujProduktForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.WalidacjaCenaLabel);
            this.Controls.Add(this.WalidacjaOpisLabel);
            this.Controls.Add(this.WalidacjaKategoriaLabel);
            this.Controls.Add(this.WalidacjaNazwaLabel);
            this.Controls.Add(this.EdytujButton);
            this.Controls.Add(this.IloscNumericUpDown);
            this.Controls.Add(this.KategoriaComboBox);
            this.Controls.Add(this.CenaTextBox);
            this.Controls.Add(this.OpisTextBox);
            this.Controls.Add(this.NazwaTextBox);
            this.Controls.Add(this.CenaLabel);
            this.Controls.Add(this.IloscLabel);
            this.Controls.Add(this.KategoriaLabel);
            this.Controls.Add(this.OpisLabel);
            this.Controls.Add(this.NazwaLabel);
            this.Controls.Add(this.TytulLabel);
            this.Name = "EdytujProduktForm";
            this.Text = "EdytujProduktForm";
            this.Load += new System.EventHandler(this.EdytujProduktForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IloscNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TytulLabel;
        private System.Windows.Forms.Label NazwaLabel;
        private System.Windows.Forms.Label OpisLabel;
        private System.Windows.Forms.Label KategoriaLabel;
        private System.Windows.Forms.Label IloscLabel;
        private System.Windows.Forms.Label CenaLabel;
        private System.Windows.Forms.TextBox NazwaTextBox;
        private System.Windows.Forms.TextBox OpisTextBox;
        private System.Windows.Forms.TextBox CenaTextBox;
        private System.Windows.Forms.ComboBox KategoriaComboBox;
        private System.Windows.Forms.NumericUpDown IloscNumericUpDown;
        private System.Windows.Forms.Button EdytujButton;
        private System.Windows.Forms.Label WalidacjaNazwaLabel;
        private System.Windows.Forms.Label WalidacjaKategoriaLabel;
        private System.Windows.Forms.Label WalidacjaOpisLabel;
        private System.Windows.Forms.Label WalidacjaCenaLabel;
    }
}