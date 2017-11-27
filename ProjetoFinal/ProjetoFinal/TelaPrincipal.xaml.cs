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
    /// Lógica interna para TelaPrincipal.xaml
    /// </summary>
    public partial class TelaPrincipal : Window
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void CadastraBT_Click(object sender, RoutedEventArgs e)
        {
            new Cadastramento().Show();
            this.Close();
        }

        private void PesquisaBT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditaBT_Click(object sender, RoutedEventArgs e)
        {
            new Editar().Show();
            this.Close();
        }

        private void OrganizaBT_Click(object sender, RoutedEventArgs e)
        {
            new Organizar().Show();
            this.Close();
        }
    }
}
