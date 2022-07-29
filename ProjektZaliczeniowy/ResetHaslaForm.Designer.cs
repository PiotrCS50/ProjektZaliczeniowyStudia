
namespace ProjektZaliczeniowy
{
    partial class ResetHaslaForm
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
            this.StareHasloTextBox = new System.Windows.Forms.TextBox();
            this.NoweHasloTextBox = new System.Windows.Forms.TextBox();
            this.PowtorzHasloTextBox = new System.Windows.Forms.TextBox();
            this.StareHasloLabel = new System.Windows.Forms.Label();
            this.NoweHasloLabel = new System.Windows.Forms.Label();
            this.PowtorzHasloLabel = new System.Windows.Forms.Label();
            this.ZapiszButton = new System.Windows.Forms.Button();
            this.WalidacjaStareHasloLabel = new System.Windows.Forms.Label();
            this.WalidacjaNoweHasloLabel = new System.Windows.Forms.Label();
            this.WalidacjaPowtorzHasloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TytulLabel
            // 
            this.TytulLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TytulLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TytulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TytulLabel.Location = new System.Drawing.Point(0, 0);
            this.TytulLabel.Name = "TytulLabel";
            this.TytulLabel.Size = new System.Drawing.Size(390, 46);
            this.TytulLabel.TabIndex = 0;
            this.TytulLabel.Text = "Zmiana hasła";
            this.TytulLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StareHasloTextBox
            // 
            this.StareHasloTextBox.Location = new System.Drawing.Point(12, 91);
            this.StareHasloTextBox.Name = "StareHasloTextBox";
            this.StareHasloTextBox.Size = new System.Drawing.Size(366, 20);
            this.StareHasloTextBox.TabIndex = 1;
            this.StareHasloTextBox.TextChanged += new System.EventHandler(this.StareHasloTextBox_TextChanged);
            this.StareHasloTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.StareHasloTextBox_Validating);
            // 
            // NoweHasloTextBox
            // 
            this.NoweHasloTextBox.Location = new System.Drawing.Point(12, 142);
            this.NoweHasloTextBox.Name = "NoweHasloTextBox";
            this.NoweHasloTextBox.Size = new System.Drawing.Size(366, 20);
            this.NoweHasloTextBox.TabIndex = 2;
            this.NoweHasloTextBox.TextChanged += new System.EventHandler(this.NoweHasloTextBox_TextChanged);
            this.NoweHasloTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NoweHasloTextBox_Validating);
            // 
            // PowtorzHasloTextBox
            // 
            this.PowtorzHasloTextBox.Location = new System.Drawing.Point(12, 197);
            this.PowtorzHasloTextBox.Name = "PowtorzHasloTextBox";
            this.PowtorzHasloTextBox.Size = new System.Drawing.Size(366, 20);
            this.PowtorzHasloTextBox.TabIndex = 3;
            this.PowtorzHasloTextBox.TextChanged += new System.EventHandler(this.PowtorzHasloTextBox_TextChanged);
            this.PowtorzHasloTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PowtorzHasloTextBox_Validating);
            // 
            // StareHasloLabel
            // 
            this.StareHasloLabel.AutoSize = true;
            this.StareHasloLabel.Location = new System.Drawing.Point(9, 75);
            this.StareHasloLabel.Name = "StareHasloLabel";
            this.StareHasloLabel.Size = new System.Drawing.Size(62, 13);
            this.StareHasloLabel.TabIndex = 4;
            this.StareHasloLabel.Text = "Stare hasło";
            // 
            // NoweHasloLabel
            // 
            this.NoweHasloLabel.AutoSize = true;
            this.NoweHasloLabel.Location = new System.Drawing.Point(9, 126);
            this.NoweHasloLabel.Name = "NoweHasloLabel";
            this.NoweHasloLabel.Size = new System.Drawing.Size(65, 13);
            this.NoweHasloLabel.TabIndex = 5;
            this.NoweHasloLabel.Text = "Nowe hasło";
            // 
            // PowtorzHasloLabel
            // 
            this.PowtorzHasloLabel.AutoSize = true;
            this.PowtorzHasloLabel.Location = new System.Drawing.Point(9, 181);
            this.PowtorzHasloLabel.Name = "PowtorzHasloLabel";
            this.PowtorzHasloLabel.Size = new System.Drawing.Size(75, 13);
            this.PowtorzHasloLabel.TabIndex = 6;
            this.PowtorzHasloLabel.Text = "Powtórz hasło";
            // 
            // ZapiszButton
            // 
            this.ZapiszButton.Enabled = false;
            this.ZapiszButton.Location = new System.Drawing.Point(290, 252);
            this.ZapiszButton.Name = "ZapiszButton";
            this.ZapiszButton.Size = new System.Drawing.Size(88, 31);
            this.ZapiszButton.TabIndex = 7;
            this.ZapiszButton.Text = "Zapisz";
            this.ZapiszButton.UseVisualStyleBackColor = true;
            this.ZapiszButton.Click += new System.EventHandler(this.ZapiszButton_Click);
            // 
            // WalidacjaStareHasloLabel
            // 
            this.WalidacjaStareHasloLabel.AutoSize = true;
            this.WalidacjaStareHasloLabel.CausesValidation = false;
            this.WalidacjaStareHasloLabel.Location = new System.Drawing.Point(110, 114);
            this.WalidacjaStareHasloLabel.Name = "WalidacjaStareHasloLabel";
            this.WalidacjaStareHasloLabel.Size = new System.Drawing.Size(35, 13);
            this.WalidacjaStareHasloLabel.TabIndex = 8;
            this.WalidacjaStareHasloLabel.Text = "label1";
            this.WalidacjaStareHasloLabel.Visible = false;
            // 
            // WalidacjaNoweHasloLabel
            // 
            this.WalidacjaNoweHasloLabel.AutoSize = true;
            this.WalidacjaNoweHasloLabel.CausesValidation = false;
            this.WalidacjaNoweHasloLabel.Location = new System.Drawing.Point(110, 165);
            this.WalidacjaNoweHasloLabel.Name = "WalidacjaNoweHasloLabel";
            this.WalidacjaNoweHasloLabel.Size = new System.Drawing.Size(35, 13);
            this.WalidacjaNoweHasloLabel.TabIndex = 9;
            this.WalidacjaNoweHasloLabel.Text = "label2";
            this.WalidacjaNoweHasloLabel.Visible = false;
            // 
            // WalidacjaPowtorzHasloLabel
            // 
            this.WalidacjaPowtorzHasloLabel.AutoSize = true;
            this.WalidacjaPowtorzHasloLabel.CausesValidation = false;
            this.WalidacjaPowtorzHasloLabel.Location = new System.Drawing.Point(110, 220);
            this.WalidacjaPowtorzHasloLabel.Name = "WalidacjaPowtorzHasloLabel";
            this.WalidacjaPowtorzHasloLabel.Size = new System.Drawing.Size(35, 13);
            this.WalidacjaPowtorzHasloLabel.TabIndex = 10;
            this.WalidacjaPowtorzHasloLabel.Text = "label3";
            this.WalidacjaPowtorzHasloLabel.Visible = false;
            // 
            // ResetHaslaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 295);
            this.Controls.Add(this.WalidacjaPowtorzHasloLabel);
            this.Controls.Add(this.WalidacjaNoweHasloLabel);
            this.Controls.Add(this.WalidacjaStareHasloLabel);
            this.Controls.Add(this.ZapiszButton);
            this.Controls.Add(this.PowtorzHasloLabel);
            this.Controls.Add(this.NoweHasloLabel);
            this.Controls.Add(this.StareHasloLabel);
            this.Controls.Add(this.PowtorzHasloTextBox);
            this.Controls.Add(this.NoweHasloTextBox);
            this.Controls.Add(this.StareHasloTextBox);
            this.Controls.Add(this.TytulLabel);
            this.MaximumSize = new System.Drawing.Size(406, 334);
            this.MinimumSize = new System.Drawing.Size(406, 334);
            this.Name = "ResetHaslaForm";
            this.Text = "ResetHaslaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TytulLabel;
        private System.Windows.Forms.TextBox StareHasloTextBox;
        private System.Windows.Forms.TextBox NoweHasloTextBox;
        private System.Windows.Forms.TextBox PowtorzHasloTextBox;
        private System.Windows.Forms.Label StareHasloLabel;
        private System.Windows.Forms.Label NoweHasloLabel;
        private System.Windows.Forms.Label PowtorzHasloLabel;
        private System.Windows.Forms.Button ZapiszButton;
        private System.Windows.Forms.Label WalidacjaStareHasloLabel;
        private System.Windows.Forms.Label WalidacjaNoweHasloLabel;
        private System.Windows.Forms.Label WalidacjaPowtorzHasloLabel;
    }
}