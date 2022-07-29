using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektZaliczeniowy
{
    class FormValidator
    {
        IWalidacjaFormluarza _form;
        public FormValidator(IWalidacjaFormluarza form)
        {
            _form = form;
            _form.FormTextCheck += SprawdzCzyBlednePoleText;
            _form.FormComboCheck += SprawdzCzyBlednePoleCombo;
        }

        private void SprawdzCzyBlednePoleText(string info, TextBox textBox, ref Label label)
        {
            //if (!ok)
            //{
            //    label.Text = info;
            //    label.Visible = true;
            //    label.ForeColor = System.Drawing.Color.Red;
            //    label.CausesValidation = ok;
            //}
            //else
            //{
            //    label.Visible = false;
            //    label.CausesValidation = ok;
            //}
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                label.Text = info;
                label.ForeColor = System.Drawing.Color.Red;
                label.Visible = true;
                label.CausesValidation = false;
            }
            else
            {
                label.Visible = false;
                label.CausesValidation = true;
            }
        }

        private void SprawdzCzyBlednePoleCombo(string info, ComboBox comboBox, ref Label label)
        {
            if(comboBox.SelectedItem == null)
            {
                label.Text = info;
                label.ForeColor = System.Drawing.Color.Red;
                label.Visible = true;
                label.CausesValidation = false;
            }
            else
            {
                label.Visible = false;
                label.CausesValidation = true;
            }
        }
    }
}
