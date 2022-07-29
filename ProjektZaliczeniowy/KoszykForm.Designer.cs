
namespace ProjektZaliczeniowy
{
    partial class KoszykForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.KoszykDataGridView = new System.Windows.Forms.DataGridView();
            this.SumaLabel = new System.Windows.Forms.Label();
            this.SumaWartoscLabel = new System.Windows.Forms.Label();
            this.KupButton = new System.Windows.Forms.Button();
            this.pozycjaKoszykaDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usun = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.KoszykDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozycjaKoszykaDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(805, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Twój koszyk";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KoszykDataGridView
            // 
            this.KoszykDataGridView.AllowUserToAddRows = false;
            this.KoszykDataGridView.AllowUserToDeleteRows = false;
            this.KoszykDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KoszykDataGridView.AutoGenerateColumns = false;
            this.KoszykDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nazwa,
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.Ilosc,
            this.Suma,
            this.Usun});
            this.KoszykDataGridView.DataSource = this.pozycjaKoszykaDtoBindingSource;
            this.KoszykDataGridView.Location = new System.Drawing.Point(38, 59);
            this.KoszykDataGridView.Name = "KoszykDataGridView";
            this.KoszykDataGridView.ReadOnly = true;
            this.KoszykDataGridView.Size = new System.Drawing.Size(727, 298);
            this.KoszykDataGridView.TabIndex = 1;
            this.KoszykDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KoszykDataGridView_CellContentClick);
            // 
            // SumaLabel
            // 
            this.SumaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SumaLabel.AutoSize = true;
            this.SumaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SumaLabel.Location = new System.Drawing.Point(387, 370);
            this.SumaLabel.Name = "SumaLabel";
            this.SumaLabel.Size = new System.Drawing.Size(143, 16);
            this.SumaLabel.TabIndex = 2;
            this.SumaLabel.Text = "Razem do zapłaty:";
            // 
            // SumaWartoscLabel
            // 
            this.SumaWartoscLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SumaWartoscLabel.AutoSize = true;
            this.SumaWartoscLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SumaWartoscLabel.Location = new System.Drawing.Point(532, 370);
            this.SumaWartoscLabel.Name = "SumaWartoscLabel";
            this.SumaWartoscLabel.Size = new System.Drawing.Size(58, 16);
            this.SumaWartoscLabel.TabIndex = 3;
            this.SumaWartoscLabel.Text = "Wartosc";
            // 
            // KupButton
            // 
            this.KupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KupButton.Location = new System.Drawing.Point(583, 417);
            this.KupButton.Name = "KupButton";
            this.KupButton.Size = new System.Drawing.Size(210, 32);
            this.KupButton.TabIndex = 4;
            this.KupButton.Text = "Zrealizuj zamówienie";
            this.KupButton.UseVisualStyleBackColor = true;
            this.KupButton.Click += new System.EventHandler(this.KupButton_Click);
            // 
            // pozycjaKoszykaDtoBindingSource
            // 
            this.pozycjaKoszykaDtoBindingSource.DataSource = typeof(ProjektZaliczeniowy.PozycjaKoszykaDto);
            // 
            // produktBindingSource
            // 
            this.produktBindingSource.DataSource = typeof(ProjektZaliczeniowy.Produkt);
            // 
            // Nazwa
            // 
            this.Nazwa.DataPropertyName = "NazwaProduktu";
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            this.Nazwa.Width = 137;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PozycjaKoszykaId";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cena";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cena";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Ilosc
            // 
            this.Ilosc.DataPropertyName = "Ilosc";
            this.Ilosc.HeaderText = "Ilość";
            this.Ilosc.Name = "Ilosc";
            this.Ilosc.ReadOnly = true;
            this.Ilosc.Width = 137;
            // 
            // Suma
            // 
            this.Suma.DataPropertyName = "Suma";
            this.Suma.HeaderText = "Suma";
            this.Suma.Name = "Suma";
            this.Suma.ReadOnly = true;
            this.Suma.Width = 137;
            // 
            // Usun
            // 
            this.Usun.HeaderText = "Usuń";
            this.Usun.Name = "Usun";
            this.Usun.ReadOnly = true;
            this.Usun.Text = "Usuń";
            this.Usun.UseColumnTextForButtonValue = true;
            this.Usun.Width = 137;
            // 
            // KoszykForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 461);
            this.Controls.Add(this.KupButton);
            this.Controls.Add(this.SumaWartoscLabel);
            this.Controls.Add(this.SumaLabel);
            this.Controls.Add(this.KoszykDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "KoszykForm";
            this.Text = "Koszyk";
            this.Load += new System.EventHandler(this.KoszykForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KoszykDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozycjaKoszykaDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView KoszykDataGridView;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private System.Windows.Forms.Label SumaLabel;
        private System.Windows.Forms.Label SumaWartoscLabel;
        private System.Windows.Forms.Button KupButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pozycjaKoszykaDtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suma;
        private System.Windows.Forms.DataGridViewButtonColumn Usun;
    }
}