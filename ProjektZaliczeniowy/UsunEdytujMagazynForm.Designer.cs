
namespace ProjektZaliczeniowy
{
    partial class UsunEdytujMagazynForm
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
            this.MagazynyDataGridView = new System.Windows.Forms.DataGridView();
            this.UsunButton = new System.Windows.Forms.Button();
            this.EdytujButton = new System.Windows.Forms.Button();
            this.TytulLabel = new System.Windows.Forms.Label();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazynBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MagazynyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MagazynyDataGridView
            // 
            this.MagazynyDataGridView.AllowUserToAddRows = false;
            this.MagazynyDataGridView.AllowUserToDeleteRows = false;
            this.MagazynyDataGridView.AutoGenerateColumns = false;
            this.MagazynyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MagazynyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwaDataGridViewTextBoxColumn});
            this.MagazynyDataGridView.DataSource = this.magazynBindingSource;
            this.MagazynyDataGridView.Location = new System.Drawing.Point(12, 46);
            this.MagazynyDataGridView.Name = "MagazynyDataGridView";
            this.MagazynyDataGridView.ReadOnly = true;
            this.MagazynyDataGridView.Size = new System.Drawing.Size(415, 190);
            this.MagazynyDataGridView.TabIndex = 0;
            // 
            // UsunButton
            // 
            this.UsunButton.Location = new System.Drawing.Point(334, 267);
            this.UsunButton.Name = "UsunButton";
            this.UsunButton.Size = new System.Drawing.Size(92, 35);
            this.UsunButton.TabIndex = 1;
            this.UsunButton.Text = "Usuń";
            this.UsunButton.UseVisualStyleBackColor = true;
            this.UsunButton.Click += new System.EventHandler(this.UsunButton_Click);
            // 
            // EdytujButton
            // 
            this.EdytujButton.Location = new System.Drawing.Point(222, 267);
            this.EdytujButton.Name = "EdytujButton";
            this.EdytujButton.Size = new System.Drawing.Size(92, 35);
            this.EdytujButton.TabIndex = 2;
            this.EdytujButton.Text = "Edytuj";
            this.EdytujButton.UseVisualStyleBackColor = true;
            this.EdytujButton.Click += new System.EventHandler(this.EdytujButton_Click);
            // 
            // TytulLabel
            // 
            this.TytulLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TytulLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TytulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TytulLabel.Location = new System.Drawing.Point(0, 0);
            this.TytulLabel.Name = "TytulLabel";
            this.TytulLabel.Size = new System.Drawing.Size(438, 34);
            this.TytulLabel.TabIndex = 3;
            this.TytulLabel.Text = "Usuń/Edytuj magazyn";
            this.TytulLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwaDataGridViewTextBoxColumn.Width = 370;
            // 
            // magazynBindingSource
            // 
            this.magazynBindingSource.DataSource = typeof(ProjektZaliczeniowy.Magazyn);
            // 
            // kategoriaBindingSource
            // 
            this.kategoriaBindingSource.DataSource = typeof(ProjektZaliczeniowy.Kategoria);
            // 
            // UsunEdytujMagazynForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 308);
            this.Controls.Add(this.TytulLabel);
            this.Controls.Add(this.EdytujButton);
            this.Controls.Add(this.UsunButton);
            this.Controls.Add(this.MagazynyDataGridView);
            this.MaximumSize = new System.Drawing.Size(454, 347);
            this.MinimumSize = new System.Drawing.Size(454, 347);
            this.Name = "UsunEdytujMagazynForm";
            this.Text = "UsunEdytujMagazynForm";
            this.Load += new System.EventHandler(this.UsunEdytujMagazynForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MagazynyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView MagazynyDataGridView;
        public System.Windows.Forms.Button UsunButton;
        public System.Windows.Forms.Button EdytujButton;
        public System.Windows.Forms.Label TytulLabel;
        public System.Windows.Forms.BindingSource magazynBindingSource;
        public System.Windows.Forms.BindingSource kategoriaBindingSource;
    }
}