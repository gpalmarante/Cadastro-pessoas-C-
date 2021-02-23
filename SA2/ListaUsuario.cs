using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA2
{
    public partial class ListaUsuario : Form
    {
        public ListaUsuario()
        {
            InitializeComponent();

            //mostra os dados na lista ao abrir o FORMS
            string[] dadosativos = Program.listarDados() ;
            //
            for (int i = 0; i < dadosativos.Length; i++)
            {
                string[] exibir = dadosativos[i].Split(',');
                string exibirFinal ="ID - "+ exibir[0] + "  - Nome - " + exibir[1] + " - Idade - " + exibir[2];
                ListaUsuarios.Items.Add(exibirFinal);
                //ListaUsuarios.Items.Add(dadosativos[0]);
            }

        }
        



        private void ListaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTNSairLista_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
