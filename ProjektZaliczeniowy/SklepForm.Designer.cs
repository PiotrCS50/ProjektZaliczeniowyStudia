
namespace ProjektZaliczeniowy
{
    partial class SklepForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mojeKontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamówieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koszykToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZmienHasloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doladujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujProduktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajProdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usunProdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujProdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajMagazynToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DodajMagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsunEtytujMagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usunEdytujKatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KategorieListBox = new System.Windows.Forms.ListBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.CenaDoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CenaOdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PriceFromLabel = new System.Windows.Forms.Label();
            this.PriceToLabel = new System.Windows.Forms.Label();
            this.KategoryLabel = new System.Windows.Forms.Label();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProduktDataGridView = new System.Windows.Forms.DataGridView();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produktDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EqLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DodajDoKoszaButton = new System.Windows.Forms.Button();
            this.SumaLabel = new System.Windows.Forms.Label();
            this.CenaLabel = new System.Windows.Forms.Label();
            this.SumaTextLabel = new System.Windows.Forms.Label();
            this.CenaTextLabel = new System.Windows.Forms.Label();
            this.IloscLabel = new System.Windows.Forms.Label();
            this.IloscNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OpisLabel = new System.Windows.Forms.Label();
            this.OpisTextBox = new System.Windows.Forms.TextBox();
            this.NazwaLabel = new System.Windows.Forms.Label();
            this.PortwelLabel = new System.Windows.Forms.Label();
            this.PieniadzeLabel = new System.Windows.Forms.Label();
            this.UzytkownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CenaDoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenaOdNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProduktDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktDtoBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IloscNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UzytkownikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(753, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sklep komputerowy IStore";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mojeKontoToolStripMenuItem,
            this.administracjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mojeKontoToolStripMenuItem
            // 
            this.mojeKontoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamówieniaToolStripMenuItem,
            this.koszykToolStripMenuItem,
            this.daneToolStripMenuItem,
            this.ZmienHasloToolStripMenuItem,
            this.doladujToolStripMenuItem,
            this.wylogujToolStripMenuItem});
            this.mojeKontoToolStripMenuItem.Name = "mojeKontoToolStripMenuItem";
            this.mojeKontoToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.mojeKontoToolStripMenuItem.Text = "Moje Konto";
            // 
            // zamówieniaToolStripMenuItem
            // 
            this.zamówieniaToolStripMenuItem.Name = "zamówieniaToolStripMenuItem";
            this.zamówieniaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.zamówieniaToolStripMenuItem.Text = "Zamówienia";
            this.zamówieniaToolStripMenuItem.Click += new System.EventHandler(this.zamówieniaToolStripMenuItem_Click);
            // 
            // koszykToolStripMenuItem
            // 
            this.koszykToolStripMenuItem.Name = "koszykToolStripMenuItem";
            this.koszykToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.koszykToolStripMenuItem.Text = "Koszyk";
            this.koszykToolStripMenuItem.Click += new System.EventHandler(this.koszykToolStripMenuItem_Click);
            // 
            // daneToolStripMenuItem
            // 
            this.daneToolStripMenuItem.Name = "daneToolStripMenuItem";
            this.daneToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.daneToolStripMenuItem.Text = "Dane";
            this.daneToolStripMenuItem.Click += new System.EventHandler(this.daneToolStripMenuItem_Click);
            // 
            // ZmienHasloToolStripMenuItem
            // 
            this.ZmienHasloToolStripMenuItem.Name = "ZmienHasloToolStripMenuItem";
            this.ZmienHasloToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ZmienHasloToolStripMenuItem.Text = "Zmieńj hasło";
            this.ZmienHasloToolStripMenuItem.Click += new System.EventHandler(this.ZresetujHasloToolStripMenuItem_Click);
            // 
            // doladujToolStripMenuItem
            // 
            this.doladujToolStripMenuItem.Name = "doladujToolStripMenuItem";
            this.doladujToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.doladujToolStripMenuItem.Text = "Doładuj";
            this.doladujToolStripMenuItem.Click += new System.EventHandler(this.doladujToolStripMenuItem_Click);
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // administracjaToolStripMenuItem
            // 
            this.administracjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edytujProduktToolStripMenuItem,
            this.dodajMagazynToolStripMenuItem,
            this.kategorieToolStripMenuItem});
            this.administracjaToolStripMenuItem.Name = "administracjaToolStripMenuItem";
            this.administracjaToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.administracjaToolStripMenuItem.Text = "Administracja";
            // 
            // edytujProduktToolStripMenuItem
            // 
            this.edytujProduktToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajProdToolStripMenuItem,
            this.usunProdToolStripMenuItem,
            this.edytujProdToolStripMenuItem});
            this.edytujProduktToolStripMenuItem.Name = "edytujProduktToolStripMenuItem";
            this.edytujProduktToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.edytujProduktToolStripMenuItem.Text = "Produkt";
            // 
            // dodajProdToolStripMenuItem
            // 
            this.dodajProdToolStripMenuItem.Name = "dodajProdToolStripMenuItem";
            this.dodajProdToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.dodajProdToolStripMenuItem.Text = "Dodaj";
            this.dodajProdToolStripMenuItem.Click += new System.EventHandler(this.dodajProduktToolStripMenuItem_Click);
            // 
            // usunProdToolStripMenuItem
            // 
            this.usunProdToolStripMenuItem.Name = "usunProdToolStripMenuItem";
            this.usunProdToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.usunProdToolStripMenuItem.Text = "Usuń";
            this.usunProdToolStripMenuItem.Click += new System.EventHandler(this.usuńProduktToolStripMenuItem_Click);
            // 
            // edytujProdToolStripMenuItem
            // 
            this.edytujProdToolStripMenuItem.Name = "edytujProdToolStripMenuItem";
            this.edytujProdToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.edytujProdToolStripMenuItem.Text = "Edytuj";
            this.edytujProdToolStripMenuItem.Click += new System.EventHandler(this.edytujProduktToolStripMenuItem_Click);
            // 
            // dodajMagazynToolStripMenuItem
            // 
            this.dodajMagazynToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DodajMagToolStripMenuItem,
            this.UsunEtytujMagToolStripMenuItem});
            this.dodajMagazynToolStripMenuItem.Name = "dodajMagazynToolStripMenuItem";
            this.dodajMagazynToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.dodajMagazynToolStripMenuItem.Text = "Magazyn";
            // 
            // DodajMagToolStripMenuItem
            // 
            this.DodajMagToolStripMenuItem.Name = "DodajMagToolStripMenuItem";
            this.DodajMagToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.DodajMagToolStripMenuItem.Text = "Dodaj";
            this.DodajMagToolStripMenuItem.Click += new System.EventHandler(this.dodajMagazynToolStripMenuItem_Click);
            // 
            // UsunEtytujMagToolStripMenuItem
            // 
            this.UsunEtytujMagToolStripMenuItem.Name = "UsunEtytujMagToolStripMenuItem";
            this.UsunEtytujMagToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.UsunEtytujMagToolStripMenuItem.Text = "Usuń\\Edytuj";
            this.UsunEtytujMagToolStripMenuItem.Click += new System.EventHandler(this.UsunEtytujMagToolStripMenuItem_Click);
            // 
            // kategorieToolStripMenuItem
            // 
            this.kategorieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKatToolStripMenuItem,
            this.usunEdytujKatToolStripMenuItem});
            this.kategorieToolStripMenuItem.Name = "kategorieToolStripMenuItem";
            this.kategorieToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.kategorieToolStripMenuItem.Text = "Kategorie";
            // 
            // dodajKatToolStripMenuItem
            // 
            this.dodajKatToolStripMenuItem.Name = "dodajKatToolStripMenuItem";
            this.dodajKatToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.dodajKatToolStripMenuItem.Text = "Dodaj";
            this.dodajKatToolStripMenuItem.Click += new System.EventHandler(this.dodajKatToolStripMenuItem_Click);
            // 
            // usunEdytujKatToolStripMenuItem
            // 
            this.usunEdytujKatToolStripMenuItem.Name = "usunEdytujKatToolStripMenuItem";
            this.usunEdytujKatToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.usunEdytujKatToolStripMenuItem.Text = "Usuń/Edytuj";
            this.usunEdytujKatToolStripMenuItem.Click += new System.EventHandler(this.usunEdytujKatToolStripMenuItem_Click);
            // 
            // KategorieListBox
            // 
            this.KategorieListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.KategorieListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KategorieListBox.FormattingEnabled = true;
            this.KategorieListBox.Location = new System.Drawing.Point(3, 65);
            this.KategorieListBox.Name = "KategorieListBox";
            this.KategorieListBox.Size = new System.Drawing.Size(139, 160);
            this.KategorieListBox.TabIndex = 2;
            this.KategorieListBox.SelectedValueChanged += new System.EventHandler(this.KategorieListBox_SelectedValueChanged);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.CenaDoNumericUpDown);
            this.LeftPanel.Controls.Add(this.CenaOdNumericUpDown);
            this.LeftPanel.Controls.Add(this.PriceFromLabel);
            this.LeftPanel.Controls.Add(this.PriceToLabel);
            this.LeftPanel.Controls.Add(this.KategoryLabel);
            this.LeftPanel.Controls.Add(this.FilterLabel);
            this.LeftPanel.Controls.Add(this.KategorieListBox);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 52);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(145, 376);
            this.LeftPanel.TabIndex = 3;
            // 
            // CenaDoNumericUpDown
            // 
            this.CenaDoNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CenaDoNumericUpDown.Location = new System.Drawing.Point(5, 310);
            this.CenaDoNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.CenaDoNumericUpDown.Name = "CenaDoNumericUpDown";
            this.CenaDoNumericUpDown.Size = new System.Drawing.Size(103, 20);
            this.CenaDoNumericUpDown.TabIndex = 9;
            this.CenaDoNumericUpDown.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.CenaDoNumericUpDown.ValueChanged += new System.EventHandler(this.CenaDoNumericUpDown_ValueChanged);
            // 
            // CenaOdNumericUpDown
            // 
            this.CenaOdNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CenaOdNumericUpDown.Location = new System.Drawing.Point(4, 258);
            this.CenaOdNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.CenaOdNumericUpDown.Name = "CenaOdNumericUpDown";
            this.CenaOdNumericUpDown.Size = new System.Drawing.Size(103, 20);
            this.CenaOdNumericUpDown.TabIndex = 8;
            this.CenaOdNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CenaOdNumericUpDown.ValueChanged += new System.EventHandler(this.CenaOdNumericUpDown_ValueChanged);
            // 
            // PriceFromLabel
            // 
            this.PriceFromLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PriceFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PriceFromLabel.Location = new System.Drawing.Point(2, 232);
            this.PriceFromLabel.Name = "PriceFromLabel";
            this.PriceFromLabel.Size = new System.Drawing.Size(71, 23);
            this.PriceFromLabel.TabIndex = 7;
            this.PriceFromLabel.Text = "Cena od";
            this.PriceFromLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceToLabel
            // 
            this.PriceToLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PriceToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PriceToLabel.Location = new System.Drawing.Point(2, 284);
            this.PriceToLabel.Name = "PriceToLabel";
            this.PriceToLabel.Size = new System.Drawing.Size(71, 23);
            this.PriceToLabel.TabIndex = 6;
            this.PriceToLabel.Text = "Cena do";
            this.PriceToLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KategoryLabel
            // 
            this.KategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KategoryLabel.Location = new System.Drawing.Point(3, 39);
            this.KategoryLabel.Name = "KategoryLabel";
            this.KategoryLabel.Size = new System.Drawing.Size(71, 23);
            this.KategoryLabel.TabIndex = 5;
            this.KategoryLabel.Text = "Kategoria";
            this.KategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterLabel
            // 
            this.FilterLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FilterLabel.Location = new System.Drawing.Point(0, 0);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(145, 29);
            this.FilterLabel.TabIndex = 1;
            this.FilterLabel.Text = "Filtruj";
            this.FilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProduktDataGridView);
            this.panel1.Controls.Add(this.EqLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(145, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 376);
            this.panel1.TabIndex = 4;
            // 
            // ProduktDataGridView
            // 
            this.ProduktDataGridView.AllowUserToAddRows = false;
            this.ProduktDataGridView.AllowUserToDeleteRows = false;
            this.ProduktDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProduktDataGridView.AutoGenerateColumns = false;
            this.ProduktDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProduktDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwaDataGridViewTextBoxColumn,
            this.kategoriaDataGridViewTextBoxColumn,
            this.Ilosc,
            this.Cena});
            this.ProduktDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProduktDataGridView.DataSource = this.produktDtoBindingSource;
            this.ProduktDataGridView.Location = new System.Drawing.Point(6, 39);
            this.ProduktDataGridView.Name = "ProduktDataGridView";
            this.ProduktDataGridView.ReadOnly = true;
            this.ProduktDataGridView.Size = new System.Drawing.Size(597, 201);
            this.ProduktDataGridView.TabIndex = 1;
            this.ProduktDataGridView.Click += new System.EventHandler(this.ProduktDataGridView_Click);
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwaDataGridViewTextBoxColumn.Width = 150;
            // 
            // kategoriaDataGridViewTextBoxColumn
            // 
            this.kategoriaDataGridViewTextBoxColumn.DataPropertyName = "Kategoria";
            this.kategoriaDataGridViewTextBoxColumn.HeaderText = "Kategoria";
            this.kategoriaDataGridViewTextBoxColumn.Name = "kategoriaDataGridViewTextBoxColumn";
            this.kategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kategoriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // Ilosc
            // 
            this.Ilosc.DataPropertyName = "Ilosc";
            this.Ilosc.HeaderText = "Ilość";
            this.Ilosc.Name = "Ilosc";
            this.Ilosc.ReadOnly = true;
            // 
            // Cena
            // 
            this.Cena.DataPropertyName = "Cena";
            this.Cena.HeaderText = "Cena";
            this.Cena.Name = "Cena";
            this.Cena.ReadOnly = true;
            // 
            // produktDtoBindingSource
            // 
            this.produktDtoBindingSource.DataSource = typeof(ProjektZaliczeniowy.ProduktDto);
            // 
            // EqLabel
            // 
            this.EqLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EqLabel.Location = new System.Drawing.Point(0, 0);
            this.EqLabel.Name = "EqLabel";
            this.EqLabel.Size = new System.Drawing.Size(608, 23);
            this.EqLabel.TabIndex = 0;
            this.EqLabel.Text = "Produkty";
            this.EqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DodajDoKoszaButton);
            this.panel2.Controls.Add(this.SumaLabel);
            this.panel2.Controls.Add(this.CenaLabel);
            this.panel2.Controls.Add(this.SumaTextLabel);
            this.panel2.Controls.Add(this.CenaTextLabel);
            this.panel2.Controls.Add(this.IloscLabel);
            this.panel2.Controls.Add(this.IloscNumericUpDown);
            this.panel2.Controls.Add(this.OpisLabel);
            this.panel2.Controls.Add(this.OpisTextBox);
            this.panel2.Controls.Add(this.NazwaLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(145, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 130);
            this.panel2.TabIndex = 5;
            // 
            // DodajDoKoszaButton
            // 
            this.DodajDoKoszaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DodajDoKoszaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DodajDoKoszaButton.Location = new System.Drawing.Point(477, 86);
            this.DodajDoKoszaButton.Name = "DodajDoKoszaButton";
            this.DodajDoKoszaButton.Size = new System.Drawing.Size(104, 23);
            this.DodajDoKoszaButton.TabIndex = 9;
            this.DodajDoKoszaButton.Text = "Dodaj do koszyka";
            this.DodajDoKoszaButton.UseVisualStyleBackColor = true;
            this.DodajDoKoszaButton.Click += new System.EventHandler(this.DodajDoKoszaButton_Click);
            // 
            // SumaLabel
            // 
            this.SumaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SumaLabel.AutoSize = true;
            this.SumaLabel.Location = new System.Drawing.Point(546, 45);
            this.SumaLabel.Name = "SumaLabel";
            this.SumaLabel.Size = new System.Drawing.Size(25, 13);
            this.SumaLabel.TabIndex = 8;
            this.SumaLabel.Text = "0 zł";
            // 
            // CenaLabel
            // 
            this.CenaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CenaLabel.AutoSize = true;
            this.CenaLabel.Location = new System.Drawing.Point(453, 45);
            this.CenaLabel.Name = "CenaLabel";
            this.CenaLabel.Size = new System.Drawing.Size(25, 13);
            this.CenaLabel.TabIndex = 7;
            this.CenaLabel.Text = "0 zł";
            // 
            // SumaTextLabel
            // 
            this.SumaTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SumaTextLabel.AutoSize = true;
            this.SumaTextLabel.Location = new System.Drawing.Point(547, 26);
            this.SumaTextLabel.Name = "SumaTextLabel";
            this.SumaTextLabel.Size = new System.Drawing.Size(34, 13);
            this.SumaTextLabel.TabIndex = 6;
            this.SumaTextLabel.Text = "Suma";
            // 
            // CenaTextLabel
            // 
            this.CenaTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CenaTextLabel.AutoSize = true;
            this.CenaTextLabel.Location = new System.Drawing.Point(427, 27);
            this.CenaTextLabel.Name = "CenaTextLabel";
            this.CenaTextLabel.Size = new System.Drawing.Size(95, 13);
            this.CenaTextLabel.TabIndex = 5;
            this.CenaTextLabel.Text = "Cena jednostkowa";
            // 
            // IloscLabel
            // 
            this.IloscLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IloscLabel.AutoSize = true;
            this.IloscLabel.Location = new System.Drawing.Point(339, 27);
            this.IloscLabel.Name = "IloscLabel";
            this.IloscLabel.Size = new System.Drawing.Size(29, 13);
            this.IloscLabel.TabIndex = 4;
            this.IloscLabel.Text = "Ilość";
            // 
            // IloscNumericUpDown
            // 
            this.IloscNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IloscNumericUpDown.Location = new System.Drawing.Point(339, 43);
            this.IloscNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.IloscNumericUpDown.Name = "IloscNumericUpDown";
            this.IloscNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.IloscNumericUpDown.TabIndex = 3;
            this.IloscNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IloscNumericUpDown.ValueChanged += new System.EventHandler(this.IloscNumericUpDown_ValueChanged);
            // 
            // OpisLabel
            // 
            this.OpisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OpisLabel.AutoSize = true;
            this.OpisLabel.Location = new System.Drawing.Point(6, 19);
            this.OpisLabel.Name = "OpisLabel";
            this.OpisLabel.Size = new System.Drawing.Size(28, 13);
            this.OpisLabel.TabIndex = 2;
            this.OpisLabel.Text = "Opis";
            // 
            // OpisTextBox
            // 
            this.OpisTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpisTextBox.BackColor = System.Drawing.Color.White;
            this.OpisTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.OpisTextBox.ForeColor = System.Drawing.Color.Black;
            this.OpisTextBox.Location = new System.Drawing.Point(6, 27);
            this.OpisTextBox.Multiline = true;
            this.OpisTextBox.Name = "OpisTextBox";
            this.OpisTextBox.ReadOnly = true;
            this.OpisTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OpisTextBox.Size = new System.Drawing.Size(327, 91);
            this.OpisTextBox.TabIndex = 1;
            // 
            // NazwaLabel
            // 
            this.NazwaLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NazwaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaLabel.Location = new System.Drawing.Point(0, 0);
            this.NazwaLabel.Name = "NazwaLabel";
            this.NazwaLabel.Size = new System.Drawing.Size(608, 23);
            this.NazwaLabel.TabIndex = 0;
            this.NazwaLabel.Text = "Nazwa produktu";
            this.NazwaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PortwelLabel
            // 
            this.PortwelLabel.AutoSize = true;
            this.PortwelLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PortwelLabel.Location = new System.Drawing.Point(632, 24);
            this.PortwelLabel.Name = "PortwelLabel";
            this.PortwelLabel.Size = new System.Drawing.Size(40, 13);
            this.PortwelLabel.TabIndex = 6;
            this.PortwelLabel.Text = "Portfel:";
            // 
            // PieniadzeLabel
            // 
            this.PieniadzeLabel.AutoSize = true;
            this.PieniadzeLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PieniadzeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PieniadzeLabel.Location = new System.Drawing.Point(632, 38);
            this.PieniadzeLabel.Name = "PieniadzeLabel";
            this.PieniadzeLabel.Size = new System.Drawing.Size(41, 13);
            this.PieniadzeLabel.TabIndex = 7;
            this.PieniadzeLabel.Text = "label3";
            // 
            // UzytkownikBindingSource
            // 
            this.UzytkownikBindingSource.DataSource = typeof(ProjektZaliczeniowy.Uzytkownik);
            // 
            // SklepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 428);
            this.Controls.Add(this.PieniadzeLabel);
            this.Controls.Add(this.PortwelLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SklepForm";
            this.Text = "IStore";
            this.Load += new System.EventHandler(this.SklepForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CenaDoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenaOdNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProduktDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktDtoBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IloscNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UzytkownikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mojeKontoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamówieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koszykToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.ListBox KategorieListBox;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label KategoryLabel;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.NumericUpDown CenaDoNumericUpDown;
        private System.Windows.Forms.NumericUpDown CenaOdNumericUpDown;
        private System.Windows.Forms.Label PriceFromLabel;
        private System.Windows.Forms.Label PriceToLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EqLabel;
        private System.Windows.Forms.ToolStripMenuItem administracjaToolStripMenuItem;
        private System.Windows.Forms.BindingSource UzytkownikBindingSource;
        private System.Windows.Forms.DataGridView ProduktDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CenaTextLabel;
        private System.Windows.Forms.Label IloscLabel;
        private System.Windows.Forms.NumericUpDown IloscNumericUpDown;
        private System.Windows.Forms.Label OpisLabel;
        private System.Windows.Forms.TextBox OpisTextBox;
        private System.Windows.Forms.Label NazwaLabel;
        private System.Windows.Forms.Label SumaLabel;
        private System.Windows.Forms.Label CenaLabel;
        private System.Windows.Forms.Label SumaTextLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DodajDoKoszaButton;
        private System.Windows.Forms.ToolStripMenuItem edytujProduktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajMagazynToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DodajMagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsunEtytujMagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usunEdytujKatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajProdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usunProdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujProdToolStripMenuItem;
        private System.Windows.Forms.BindingSource produktDtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.ToolStripMenuItem doladujToolStripMenuItem;
        private System.Windows.Forms.Label PortwelLabel;
        private System.Windows.Forms.Label PieniadzeLabel;
        private System.Windows.Forms.ToolStripMenuItem ZmienHasloToolStripMenuItem;
    }
}

