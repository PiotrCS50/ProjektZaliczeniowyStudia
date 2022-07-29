using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektZaliczeniowy
{
    public partial class UsunEdytujMagazynForm : Form
    {
        private readonly IDataRepository _repository;
        Magazyn magazyn;
        DodajMagazynForm form;
        public UsunEdytujMagazynForm()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        public async void EdytujButton_Click(object sender, EventArgs e)
        {
            magazyn = (Magazyn)MagazynyDataGridView.CurrentRow.DataBoundItem;
            form = new DodajMagazynForm();
            new FormValidator(form);
            form.TytulLabel.Text = "Edytuj magazyn";
            form.NazwaTextBox.Text = magazyn.Nazwa;
            form.CzyDomyslnyCheckBox.Checked = magazyn.Domyslny;
            form.DodajButton.Text = "Edytuj";
            form.DodajButton.Click -= form.DodajButton_Click;
            form.DodajButton.Click += DodajButton_Click;
            if (form.CzyDomyslnyCheckBox.Checked == true) form.CzyDomyslnyCheckBox.Enabled = false;
            if (form.ShowDialog() == DialogResult.OK)
                await _repository.ZapiszZmiany();
            MagazynyDataGridView.DataSource =await _repository.DajMagazyny();

        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            magazyn.Nazwa = form.NazwaTextBox.Text;
            if (form.CzyDomyslnyCheckBox.Checked == true)
                _repository.UstawMagazynJakoDomyslny(magazyn.Id);
            form.DialogResult = DialogResult.OK;
        }

        public async void UsunButton_Click(object sender, EventArgs e)
        {
            magazyn = (Magazyn)MagazynyDataGridView.CurrentRow.DataBoundItem;
            _repository.UsunMagazyn(magazyn);
            if (await _repository.ZapiszZmiany()) MessageBox.Show("Magazyn usunięty");
            else MessageBox.Show("Nie można usunąć jedynego magazynu!");
            MagazynyDataGridView.DataSource = await _repository.DajMagazyny();
        }

        public async void UsunEdytujMagazynForm_Load(object sender, EventArgs e)
        {
            MagazynyDataGridView.DataSource = await _repository.DajMagazyny();
        }
    }
}
