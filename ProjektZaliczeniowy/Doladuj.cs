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
    public partial class Doladuj : Form
    {
        private IDataRepository _repository;
        private Uzytkownik _user;
        public Doladuj(Uzytkownik user)
        {
            InitializeComponent();
            _repository = new Repository();
            _user = user;
        }

        private async void DoladujButton_Click(object sender, EventArgs e)
        {
            _repository.DoladujKonto(_user, KwotaNumericUpDown.Value);
            if (await _repository.ZapiszZmiany()) MessageBox.Show($"Konto zostało zasilone kwotą: {KwotaNumericUpDown.Value} zł");
        }
    }
}
