
namespace ProjektZaliczeniowy
{
    partial class UsunProduktForm
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
            this.ProduktDataGridView = new System.Windows.Forms.DataGridView();
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TytulLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UsunButton = new System.Windows.Forms.Button();
            this.KategoriaValueLabel = new System.Windows.Forms.Label();
            this.KategoriaLabel = new System.Windows.Forms.Label();
            this.OpisLabel = new System.Windows.Forms.Label();
            this.opisTtextBox = new System.Windows.Forms.TextBox();
            this.NazwaLabel = new System.Windows.Forms.Label();
            this.SzukajLabel = new System.Windows.Forms.Label();
            this.SzukajTextBox = new System.Windows.Forms.TextBox();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProduktDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProduktDataGridView
            // 
            this.ProduktDataGridView.AllowUserToAddRows = false;
            this.ProduktDataGridView.AllowUserToDeleteRows = false;
            this.ProduktDataGridView.AllowUserToOrderColumns = true;
            this.ProduktDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProduktDataGridView.AutoGenerateColumns = false;
            this.ProduktDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProduktDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProduktDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwaDataGridViewTextBoxColumn,
            this.Kategoria});
            this.ProduktDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProduktDataGridView.DataSource = this.produktBindingSource;
            this.ProduktDataGridView.Location = new System.Drawing.Point(49, 64);
            this.ProduktDataGridView.MultiSelect = false;
            this.ProduktDataGridView.Name = "ProduktDataGridView";
            this.ProduktDataGridView.ReadOnly = true;
            this.ProduktDataGridView.Size = new System.Drawing.Size(463, 225);
            this.ProduktDataGridView.TabIndex = 0;
            this.ProduktDataGridView.Click += new System.EventHandler(this.ProduktDataGridView_Click);
            // 
            // produktBindingSource
            // 
            this.produktBindingSource.DataSource = typeof(ProjektZaliczeniowy.Produkt);
            // 
            // TytulLabel
            // 
            this.TytulLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TytulLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TytulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TytulLabel.Location = new System.Drawing.Point(0, 0);
            this.TytulLabel.Name = "TytulLabel";
            this.TytulLabel.Size = new System.Drawing.Size(556, 23);
            this.TytulLabel.TabIndex = 1;
            this.TytulLabel.Text = "Usuwanie Produtku";
            this.TytulLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UsunButton);
            this.panel1.Controls.Add(this.KategoriaValueLabel);
            this.panel1.Controls.Add(this.KategoriaLabel);
            this.panel1.Controls.Add(this.OpisLabel);
            this.panel1.Controls.Add(this.opisTtextBox);
            this.panel1.Controls.Add(this.NazwaLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 151);
            this.panel1.TabIndex = 2;
            // 
            // UsunButton
            // 
            this.UsunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UsunButton.Location = new System.Drawing.Point(461, 110);
            this.UsunButton.Name = "UsunButton";
            this.UsunButton.Size = new System.Drawing.Size(85, 29);
            this.UsunButton.TabIndex = 5;
            this.UsunButton.Text = "Usuń";
            this.UsunButton.UseVisualStyleBackColor = true;
            this.UsunButton.Click += new System.EventHandler(this.UsunButton_Click);
            // 
            // KategoriaValueLabel
            // 
            this.KategoriaValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KategoriaValueLabel.AutoSize = true;
            this.KategoriaValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KategoriaValueLabel.Location = new System.Drawing.Point(311, 57);
            this.KategoriaValueLabel.Name = "KategoriaValueLabel";
            this.KategoriaValueLabel.Size = new System.Drawing.Size(61, 13);
            this.KategoriaValueLabel.TabIndex = 4;
            this.KategoriaValueLabel.Text = "Kategoria";
            // 
            // KategoriaLabel
            // 
            this.KategoriaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KategoriaLabel.AutoSize = true;
            this.KategoriaLabel.Location = new System.Drawing.Point(311, 38);
            this.KategoriaLabel.Name = "KategoriaLabel";
            this.KategoriaLabel.Size = new System.Drawing.Size(52, 13);
            this.KategoriaLabel.TabIndex = 3;
            this.KategoriaLabel.Text = "Kategoria";
            // 
            // OpisLabel
            // 
            this.OpisLabel.AutoSize = true;
            this.OpisLabel.Location = new System.Drawing.Point(12, 38);
            this.OpisLabel.Name = "OpisLabel";
            this.OpisLabel.Size = new System.Drawing.Size(28, 13);
            this.OpisLabel.TabIndex = 2;
            this.OpisLabel.Text = "Opis";
            // 
            // opisTtextBox
            // 
            this.opisTtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opisTtextBox.Location = new System.Drawing.Point(4, 54);
            this.opisTtextBox.Multiline = true;
            this.opisTtextBox.Name = "opisTtextBox";
            this.opisTtextBox.Size = new System.Drawing.Size(273, 94);
            this.opisTtextBox.TabIndex = 1;
            // 
            // NazwaLabel
            // 
            this.NazwaLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NazwaLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NazwaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaLabel.Location = new System.Drawing.Point(0, 0);
            this.NazwaLabel.Name = "NazwaLabel";
            this.NazwaLabel.Size = new System.Drawing.Size(556, 23);
            this.NazwaLabel.TabIndex = 0;
            this.NazwaLabel.Text = "Nazwa produktu";
            this.NazwaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SzukajLabel
            // 
            this.SzukajLabel.AutoSize = true;
            this.SzukajLabel.Location = new System.Drawing.Point(46, 38);
            this.SzukajLabel.Name = "SzukajLabel";
            this.SzukajLabel.Size = new System.Drawing.Size(39, 13);
            this.SzukajLabel.TabIndex = 3;
            this.SzukajLabel.Text = "Szukaj";
            // 
            // SzukajTextBox
            // 
            this.SzukajTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SzukajTextBox.Location = new System.Drawing.Point(107, 38);
            this.SzukajTextBox.Name = "SzukajTextBox";
            this.SzukajTextBox.Size = new System.Drawing.Size(405, 20);
            this.SzukajTextBox.TabIndex = 4;
            this.SzukajTextBox.TextChanged += new System.EventHandler(this.SzukajTextBox_TextChanged);
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Kategoria
            // 
            this.Kategoria.DataPropertyName = "Kategoria";
            this.Kategoria.HeaderText = "Kategoria";
            this.Kategoria.Name = "Kategoria";
            this.Kategoria.ReadOnly = true;
            // 
            // UsunProduktForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 463);
            this.Controls.Add(this.SzukajTextBox);
            this.Controls.Add(this.SzukajLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TytulLabel);
            this.Controls.Add(this.ProduktDataGridView);
            this.Name = "UsunProduktForm";
            this.Text = "UsunProduktForm";
            this.Load += new System.EventHandler(this.UsunProduktForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProduktDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProduktDataGridView;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label TytulLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UsunButton;
        private System.Windows.Forms.Label KategoriaValueLabel;
        private System.Windows.Forms.Label KategoriaLabel;
        private System.Windows.Forms.Label OpisLabel;
        private System.Windows.Forms.TextBox opisTtextBox;
        private System.Windows.Forms.Label NazwaLabel;
        private System.Windows.Forms.Label SzukajLabel;
        private System.Windows.Forms.TextBox SzukajTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategoria;
    }
}