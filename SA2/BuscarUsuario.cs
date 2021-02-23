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
    public partial class BuscarUsuario : Form
    {
        public BuscarUsuario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            string[] BancoDados = Program.listarDados();
            string busca = BoxTXTbusca.Text ;
            int Count = 0;
            listBoxBusca.Items.Clear();
            progressBarBusca.Value = 0;
            progressBarBusca.Maximum = BancoDados.Length;
            if (busca == null || busca == "") {
                MessageBox.Show("busca Vazia");
            }
            else
            {
                for (int i = 0; i < BancoDados.Length; i++)
                {
                    if (BancoDados[i].Contains(busca))
                    {
                        listBoxBusca.Items.Add(BancoDados[i].ToString());
                        //listBoxBusca.Items.Add("teste");
                        //System.Console.WriteLine(BancoDados[i]);
                    }

                    progressBarBusca.Value++;
                    Count++;
                }
            }
          
        }

        private void BTNSairBusca_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
