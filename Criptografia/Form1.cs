using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteCriptografia;

namespace Criptografia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_cripto_Click(object sender, EventArgs e)
        {
            try
            {
                result_cripto.Text =
                        CriptografiaHelper.Encriptar(
                        key.Text,
                        v_ini.Text,
                        text_cripto.Text);
            }
            catch (Exception ex)
            {
                result_cripto.Text =
                    "Erro: " + ex.Message;
            }
        }

        private void bt_decripto_Click(object sender, EventArgs e)
        {
            try
            {
                 result_decripto.Text =
                    CriptografiaHelper.Decriptar(
                        key.Text,
                        v_ini.Text,
                        text_decripto.Text);
            }
            catch (Exception ex)
            {
                result_decripto.Text =
                    "Erro: " + ex.Message;
            }
        }
    }
}
