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
using MySql.Data.MySqlClient;


namespace ProjetoFinal
{
    /// <summary>
    /// Lógica interna para TelaPrincipal.xaml
    /// </summary>
    public partial class TelaPrincipal : Window
    {
        const string qr = "SELECT * FROM banda;";
        public TelaPrincipal()
        {
            InitializeComponent();
            ListaBandas.Items.Clear();
            ConectarBD c = new ConectarBD(qr);
            MySqlCommand cmd;
            string nome;
            cmd = c.atualizarlista(PesquisaTxT.Text);
            try
            {
                MySqlDataReader ler;
                ler = cmd.ExecuteReader();
                while (ler.Read())
                {
                    nome = ler.GetString("nome");
                    ListaBandas.Items.Add(nome);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                c.atualizarlista(PesquisaTxT.Text).Connection.Close();
            }
        }

        private void CadastraBT_Click(object sender, RoutedEventArgs e)
        {
            new Cadastramento().Show();
            this.Close();
        }

        private void EditaBT_Click(object sender, RoutedEventArgs e)
        {
            new Editar(ListaBandas.SelectedItem.ToString()).Show();
            this.Close();
        }

        private void OrganizaBT_Click(object sender, RoutedEventArgs e)
        {
            new Organizar().Show();
            this.Close();
        }

        private void PesquisaTxT_TextChanged(object sender, TextChangedEventArgs e)
        {
            //atualizar a listbox de bandas toda vez que o textbox for alterado, caso fosse outra maneira não seria possível filtrar a listbox
            ListaBandas.Items.Clear();
            ConectarBD c = new ConectarBD(qr);
            MySqlCommand cmd;
            cmd = c.atualizarlista(PesquisaTxT.Text);
            try
            {
                MySqlDataReader ler;
                ler = cmd.ExecuteReader();
                while (ler.Read())
                {
                    string snome = ler.GetString("nome");
                    ListaBandas.Items.Add(snome);
                }
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
            finally
            {
                c.atualizarlista(PesquisaTxT.Text).Connection.Close();
            }



            //filtrar o nome das bandas
            List<string> items = new List<string>();
            for (int i = 0; i < ListaBandas.Items.Count; i++)
            {
                items.Add(ListaBandas.Items[i].ToString());
            }
            ListaBandas.Items.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ToString().ToLower().Contains(PesquisaTxT.Text))
                    ListaBandas.Items.Add(items[i]);
            }
        }

        private void ExcluirBT_Click(object sender, RoutedEventArgs e)
        {
            var banda = new Banda();
            string nome = ListaBandas.SelectedItem.ToString();
            var exc = new Exclui(nome);

            string format = "Você tem certeza que deseja excluir a banda {0}?";
            
            
            

            if (MessageBox.Show(String.Format(format, nome), "DELETAR", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                exc.excluir();
                MessageBox.Show("Banda excluída com sucesso!");
            }
            
        }

        private void Exibir_Click(object sender, RoutedEventArgs e)
        {
            
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=root");
            cmd.CommandText = "SELECT * FROM banda WHERE nome= @nome";
            cmd.Parameters.AddWithValue("@nome", ListaBandas.SelectedItem.ToString());
            cmd.Connection.Open();
            MySqlDataReader ler = cmd.ExecuteReader();
            Banda b = new Banda();
            if(ler.HasRows)
            {
                while(ler.Read())
                {
                    b.Nome = ler.GetString("nome");
                    b.NumIntegrantes = ler.GetInt32("numint");
                    b.NomeMusica = ler.GetString("nomemusica");
                    b.Instrumento = ler.GetInt32("instru");
                    b.DiaPreferencial = ler.GetInt32("diapref");
                }
            }
            string instru;
            if(b.Instrumento == 1)
            {
                instru = "sim";
            }
            else
                instru = "não";
            string s = string.Format(" O nome da banda é: {0} \n O número de integrantes é: {1} \n O nome da música é: {2} \n Vai usar instrumentos da escola?: {3} \n Dia preferencial? {4}", b.Nome, b.NumIntegrantes, b.NomeMusica, instru, b.DiaPreferencial);
            MessageBox.Show(s);
        }
        
    }
}
