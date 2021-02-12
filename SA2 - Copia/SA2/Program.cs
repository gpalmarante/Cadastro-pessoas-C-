using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SA2
{

    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new principal());
                   

        }

        public static void RecebeDados(string[] usuario)
            //recebe o dados para cadastro e salva na "BASE".
        {
            StreamWriter x;
            StreamReader Y;
            int counter = 0;
            string line;
            string CaminhoNome = " C:\\Users\\gpalmarante\\source\\repos\\SA2\\SA2\\BancoUsuarios.txt";

            //ler e contar quantidades de dados.
            Y = new StreamReader(CaminhoNome);

            while ((line = Y.ReadLine()) != null)
            {
                //System.Console.WriteLine(line);
                counter++;
            }
            Y.Close();

            // grava dados do usuario na ultima linha com identificador unico.
            x = File.AppendText(CaminhoNome);
            x.Write(counter + 1);
            x.Write(",");
            x.Write(usuario[0]);
            x.Write(",");
            x.WriteLine(usuario[1]);
            
            x.Close();


        }
        public static string[] listarDados()
            // ler os dados da "BASE" e gravar em uma array string com o tamanho nescessario para os dados.
        {
            
            StreamReader Y;
            int counter = 0;
            int counterGrava = 0;
            string line;
            string CaminhoNome = " C:\\Users\\gpalmarante\\source\\repos\\SA2\\SA2\\BancoUsuarios.txt";

            //ler e contar quantidades de dados.
            Y = new StreamReader(CaminhoNome);
            while ((line = Y.ReadLine()) != null)
            {
                System.Console.WriteLine("count"+line);
                counter++;
            }

            string[] Dados = new string[counter];
           // System.Console.WriteLine(Dados.Length.ToString()) ;
            Y.Close();
           
            
            // abri novamente o arquivo para ler e gravar dados no DADOS

            Y = new StreamReader(CaminhoNome);
            while ((line = Y.ReadLine()) != null)
            {
               
                
                // Dados[i] = Y.ReadLine();
                       
                            
                Dados[counterGrava] = line;
              //  Console.WriteLine("este e os dados" + Dados[counterGrava].ToString());
                counterGrava++;
            }


            Y.Close();

            return Dados;

        }
       


    }
}

