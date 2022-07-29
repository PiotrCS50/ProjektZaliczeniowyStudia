using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektZaliczeniowy
{
    public delegate void SprawdzPoleTextoweDelegate(string info, TextBox textBox, ref Label label);
    public delegate void SprawdzPoleComboDelegate(string info, ComboBox comboBox, ref Label label);
    public interface IWalidacjaFormluarza
    {
        event SprawdzPoleTextoweDelegate FormTextCheck;
        event SprawdzPoleComboDelegate FormComboCheck;
    }
}
