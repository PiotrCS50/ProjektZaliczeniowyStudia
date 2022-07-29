
namespace ProjektZaliczeniowy
{
    partial class ZamowieniaForm
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
            this.TytulLabel = new System.Windows.Forms.Label();
            this.ZamowieniaListBox = new System.Windows.Forms.ListBox();
            this.ZamowieniaLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProduktyDataGridView = new System.Windows.Forms.DataGridView();
            this.pozycjaZamowieniaDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProduktyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozycjaZamowieniaDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TytulLabel
            // 
            this.TytulLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TytulLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TytulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TytulLabel.Location = new System.Drawing.Point(0, 0);
            this.TytulLabel.Name = "TytulLabel";
            this.TytulLabel.Size = new System.Drawing.Size(800, 46);
            this.TytulLabel.TabIndex = 1;
            this.TytulLabel.Text = "Zrealizowane zamówienia";
            this.TytulLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ZamowieniaListBox
            // 
            this.ZamowieniaListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZamowieniaListBox.FormattingEnabled = true;
            this.ZamowieniaListBox.Location = new System.Drawing.Point(0, 28);
            this.ZamowieniaListBox.Name = "ZamowieniaListBox";
            this.ZamowieniaListBox.Size = new System.Drawing.Size(178, 374);
            this.ZamowieniaListBox.TabIndex = 2;
            this.ZamowieniaListBox.SelectedIndexChanged += new System.EventHandler(this.ZamowieniaListBox_SelectedIndexChanged);
            // 
            // ZamowieniaLabel
            // 
            this.ZamowieniaLabel.BackColor = System.Drawing.SystemColors.Info;
            this.ZamowieniaLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ZamowieniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZamowieniaLabel.Location = new System.Drawing.Point(0, 0);
            this.ZamowieniaLabel.Name = "ZamowieniaLabel";
            this.ZamowieniaLabel.Size = new System.Drawing.Size(178, 28);
            this.ZamowieniaLabel.TabIndex = 3;
            this.ZamowieniaLabel.Text = "Zamowienia";
            this.ZamowieniaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ZamowieniaListBox);
            this.panel1.Controls.Add(this.ZamowieniaLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 402);
            this.panel1.TabIndex = 4;
            // 
            // ProduktyDataGridView
            // 
            this.ProduktyDataGridView.AutoGenerateColumns = false;
            this.ProduktyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProduktyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProduktyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwaDataGridViewTextBoxColumn,
            this.Ilosc,
            this.Cena,
            this.Suma});
            this.ProduktyDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProduktyDataGridView.DataSource = this.pozycjaZamowieniaDtoBindingSource;
            this.ProduktyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProduktyDataGridView.Location = new System.Drawing.Point(178, 46);
            this.ProduktyDataGridView.Name = "ProduktyDataGridView";
            this.ProduktyDataGridView.Size = new System.Drawing.Size(622, 402);
            this.ProduktyDataGridView.TabIndex = 5;
            // 
            // pozycjaZamowieniaDtoBindingSource
            // 
            this.pozycjaZamowieniaDtoBindingSource.DataSource = typeof(ProjektZaliczeniowy.PozycjaZamowieniaDto);
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Ilosc
            // 
            this.Ilosc.DataPropertyName = "Ilosc";
            this.Ilosc.HeaderText = "Ilosc";
            this.Ilosc.Name = "Ilosc";
            // 
            // Cena
            // 
            this.Cena.DataPropertyName = "Cena";
            this.Cena.HeaderText = "Cena";
            this.Cena.Name = "Cena";
            // 
            // Suma
            // 
            this.Suma.DataPropertyName = "Suma";
            this.Suma.HeaderText = "Suma";
            this.Suma.Name = "Suma";
            // 
            // ZamowieniaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.ProduktyDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TytulLabel);
            this.Name = "ZamowieniaForm";
            this.Text = "ZamowieniaForm";
            this.Load += new System.EventHandler(this.ZamowieniaForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProduktyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozycjaZamowieniaDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TytulLabel;
        private System.Windows.Forms.ListBox ZamowieniaListBox;
        private System.Windows.Forms.Label ZamowieniaLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ProduktyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suma;
        private System.Windows.Forms.BindingSource pozycjaZamowieniaDtoBindingSource;
    }
}