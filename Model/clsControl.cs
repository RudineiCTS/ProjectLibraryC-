using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMBIBLIO
{
    public static class clsControl
    {
        public static void abreMenu(frmMenu menu2)
        {
            frmMenu menu;
            menu = menu2;
            menu2.Visible = true;
        }


        public static void limparPesquisa(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is GroupBox)
                {
                    foreach (Control item2 in item.Controls)
                    {
                        if (item2 is TextBox)
                        {
                            item2.Text = string.Empty;
                            item2.Enabled = false;
                        }
                        else if (item2 is RadioButton)
                        {
                            ((RadioButton)item2).Checked = false;

                        }
                        else if (item2 is MaskedTextBox) { 
                        item2.Text = "";
                        item2.Text = string.Empty;
                    }
                    }
                }
                
            }

        }
    }
}
