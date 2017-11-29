using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjetoFinal
{
    /// <summary>
    /// Lógica interna para Organizar.xaml
    /// </summary>
    public partial class Organizar : Window
    {
        public Organizar()
        {
            InitializeComponent();
            string nome;
            List<string> Dia1bloco1 = new List<string>();
            List<string> Dia1bloco2 = new List<string>();
            List<string> Dia2bloco1 = new List<string>();
            List<string> Dia2bloco2 = new List<string>();

            string qr = "SELECT nome FROM banda;";
            ConectarBD con = new ConectarBD(qr);
            
            con.AbrirConexao();
            con.ExecuteReader();
           
            if(con.rd.HasRows)
            {
                for (int i = 0; con.rd.Read(); i++)
                {
                    nome = con.rd.GetString("nome");
                    if (i < 15)
                        Dia1bloco1.Add(nome);
                    else if (i < 30)
                        Dia1bloco2.Add(nome);
                    else if (i < 45)
                        Dia2bloco1.Add(nome);
                    else
                        Dia2bloco2.Add(nome);                       
                }
            }

            Dia1Bloco1.ItemsSource = Dia1bloco1;
            Dia1Bloco2.ItemsSource = Dia1bloco2;
            Dia2Bloco1.ItemsSource = Dia2bloco1;
            Dia2Bloco2.ItemsSource = Dia2bloco2;


        }

        private void Voltarbt_Click(object sender, RoutedEventArgs e)
        {
            new TelaPrincipal().Show();
            this.Close();
        }
    }
}
