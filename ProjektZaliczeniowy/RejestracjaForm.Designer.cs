
namespace ProjektZaliczeniowy
{
    partial class RejestracjaForm
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
            this.NazwaLabel = new System.Windows.Forms.Label();
            this.ImieLabel = new System.Windows.Forms.Label();
            this.NazwiskoLabel = new System.Windows.Forms.Label();
            this.HasloLabel = new System.Windows.Forms.Label();
            this.WalidacjaNazwaLabel = new System.Windows.Forms.Label();
            this.WalidacjaImieLabel = new System.Windows.Forms.Label();
            this.WalidacjaHasloLabel = new System.Windows.Forms.Label();
            this.WalidacjaNazwiskoLabel = new System.Windows.Forms.Label();
            this.NazwaTextBox = new System.Windows.Forms.TextBox();
            this.ImieTextBox = new System.Windows.Forms.TextBox();
            this.NazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.HasloTextBox = new System.Windows.Forms.TextBox();
            this.TytulLabel = new System.Windows.Forms.Label();
            this.rejetracjaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NazwaLabel
            // 
            this.NazwaLabel.AutoSize = true;
            this.NazwaLabel.Location = new System.Drawing.Point(44, 61);
            this.NazwaLabel.Name = "NazwaLabel";
            this.NazwaLabel.Size = new System.Drawing.Size(40, 13);
            this.NazwaLabel.TabIndex = 0;
            this.NazwaLabel.Text = "Nazwa";
            // 
            // ImieLabel
            // 
            this.ImieLabel.AutoSize = true;
            this.ImieLabel.Location = new System.Drawing.Point(44, 127);
            this.ImieLabel.Name = "ImieLabel";
            this.ImieLabel.Size = new System.Drawing.Size(26, 13);
            this.ImieLabel.TabIndex = 1;
            this.ImieLabel.Text = "Imie";
            // 
            // NazwiskoLabel
            // 
            this.NazwiskoLabel.AutoSize = true;
            this.NazwiskoLabel.Location = new System.Drawing.Point(44, 197);
            this.NazwiskoLabel.Name = "NazwiskoLabel";
            this.NazwiskoLabel.Size = new System.Drawing.Size(53, 13);
            this.NazwiskoLabel.TabIndex = 2;
            this.NazwiskoLabel.Text = "Nazwisko";
            // 
            // HasloLabel
            // 
            this.HasloLabel.AutoSize = true;
            this.HasloLabel.Location = new System.Drawing.Point(44, 265);
            this.HasloLabel.Name = "HasloLabel";
            this.HasloLabel.Size = new System.Drawing.Size(34, 13);
            this.HasloLabel.TabIndex = 3;
            this.HasloLabel.Text = "Haslo";
            // 
            // WalidacjaNazwaLabel
            // 
            this.WalidacjaNazwaLabel.AutoSize = true;
            this.WalidacjaNazwaLabel.Location = new System.Drawing.Point(145, 100);
            this.WalidacjaNazwaLabel.Name = "WalidacjaNazwaLabel";
            this.WalidacjaNazwaLabel.Size = new System.Drawing.Size(35, 13);
            this.WalidacjaNazwaLabel.TabIndex = 4;
            this.WalidacjaNazwaLabel.Text = "label5";
            this.WalidacjaNazwaLabel.Visible = false;
            // 
            // WalidacjaImieLabel
            // 
            this.WalidacjaImieLabel.AutoSize = true;
            this.WalidacjaImieLabel.Location = new System.Drawing.Point(145, 166);
            this.WalidacjaImieLabel.Name = "WalidacjaImieLabel";
            this.WalidacjaImieLabel.Size = new System.Drawing.Size(35, 13);
            this.WalidacjaImieLabel.TabIndex = 5;
            this.WalidacjaImieLabel.Text = "label6";
            this.WalidacjaImieLabel.Visible = false;
            // 
            // WalidacjaHasloLabel
            // 
            this.WalidacjaHasloLabel.AutoSize = true;
            this.WalidacjaHasloLabel.Location = new System.Drawing.Point(145, 304);
            this.WalidacjaHasloLabel.Name = "WalidacjaHasloLabel";
            this.WalidacjaHasloLabel.Size = new System.Drawing.Size(35, 13);
            this.WalidacjaHasloLabel.TabIndex = 6;
            this.WalidacjaHasloLabel.Text = "label7";
            this.WalidacjaHasloLabel.Visible = false;
            // 
            // WalidacjaNazwiskoLabel
            // 
            this.WalidacjaNazwiskoLabel.AutoSize = true;
            this.WalidacjaNazwiskoLabel.Location = new System.Drawing.Point(145, 236);
            this.WalidacjaNazwiskoLabel.Name = "WalidacjaNazwiskoLabel";
            this.WalidacjaNazwiskoLabel.Size = new System.Drawing.Size(35, 13);
            this.WalidacjaNazwiskoLabel.TabIndex = 7;
            this.WalidacjaNazwiskoLabel.Text = "label8";
            this.WalidacjaNazwiskoLabel.Visible = false;
            // 
            // NazwaTextBox
            // 
            this.NazwaTextBox.Location = new System.Drawing.Point(47, 77);
            this.NazwaTextBox.Name = "NazwaTextBox";
            this.NazwaTextBox.Size = new System.Drawing.Size(289, 20);
            this.NazwaTextBox.TabIndex = 8;
            this.NazwaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NazwaTextBox_Validating);
            // 
            // ImieTextBox
            // 
            this.ImieTextBox.Location = new System.Drawing.Point(47, 143);
            this.ImieTextBox.Name = "ImieTextBox";
            this.ImieTextBox.Size = new System.Drawing.Size(289, 20);
            this.ImieTextBox.TabIndex = 9;
            this.ImieTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ImieTextBox_Validating);
            // 
            // NazwiskoTextBox
            // 
            this.NazwiskoTextBox.Location = new System.Drawing.Point(47, 213);
            this.NazwiskoTextBox.Name = "NazwiskoTextBox";
            this.NazwiskoTextBox.Size = new System.Drawing.Size(289, 20);
            this.NazwiskoTextBox.TabIndex = 10;
            this.NazwiskoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NazwiskoTextBox_Validating);
            // 
            // HasloTextBox
            // 
            this.HasloTextBox.Location = new System.Drawing.Point(47, 281);
            this.HasloTextBox.Name = "HasloTextBox";
            this.HasloTextBox.Size = new System.Drawing.Size(289, 20);
            this.HasloTextBox.TabIndex = 11;
            this.HasloTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.HasloTextBox_Validating);
            // 
            // TytulLabel
            // 
            this.TytulLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TytulLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TytulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TytulLabel.Location = new System.Drawing.Point(0, 0);
            this.TytulLabel.Name = "TytulLabel";
            this.TytulLabel.Size = new System.Drawing.Size(372, 38);
            this.TytulLabel.TabIndex = 12;
            this.TytulLabel.Text = "Rejsetracja";
            this.TytulLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rejetracjaButton
            // 
            this.rejetracjaButton.Location = new System.Drawing.Point(219, 354);
            this.rejetracjaButton.Name = "rejetracjaButton";
            this.rejetracjaButton.Size = new System.Drawing.Size(117, 34);
            this.rejetracjaButton.TabIndex = 13;
            this.rejetracjaButton.Text = "Zarejestruj";
            this.rejetracjaButton.UseVisualStyleBackColor = true;
            this.rejetracjaButton.Click += new System.EventHandler(this.rejetracjaButton_Click);
            // 
            // RejestracjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 400);
            this.Controls.Add(this.rejetracjaButton);
            this.Controls.Add(this.TytulLabel);
            this.Controls.Add(this.HasloTextBox);
            this.Controls.Add(this.NazwiskoTextBox);
            this.Controls.Add(this.ImieTextBox);
            this.Controls.Add(this.NazwaTextBox);
            this.Controls.Add(this.WalidacjaNazwiskoLabel);
            this.Controls.Add(this.WalidacjaHasloLabel);
            this.Controls.Add(this.WalidacjaImieLabel);
            this.Controls.Add(this.WalidacjaNazwaLabel);
            this.Controls.Add(this.HasloLabel);
            this.Controls.Add(this.NazwiskoLabel);
            this.Controls.Add(this.ImieLabel);
            this.Controls.Add(this.NazwaLabel);
            this.Name = "RejestracjaForm";
            this.Text = "RejestracjaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NazwaLabel;
        private System.Windows.Forms.Label ImieLabel;
        private System.Windows.Forms.Label NazwiskoLabel;
        private System.Windows.Forms.Label HasloLabel;
        private System.Windows.Forms.Label WalidacjaNazwaLabel;
        private System.Windows.Forms.Label WalidacjaImieLabel;
        private System.Windows.Forms.Label WalidacjaHasloLabel;
        private System.Windows.Forms.Label WalidacjaNazwiskoLabel;
        private System.Windows.Forms.TextBox NazwaTextBox;
        private System.Windows.Forms.TextBox ImieTextBox;
        private System.Windows.Forms.TextBox NazwiskoTextBox;
        private System.Windows.Forms.TextBox HasloTextBox;
        private System.Windows.Forms.Label TytulLabel;
        private System.Windows.Forms.Button rejetracjaButton;
    }
}