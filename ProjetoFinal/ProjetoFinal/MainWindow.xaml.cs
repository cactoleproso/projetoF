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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace ProjetoFinal
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LogarBT_Click(object sender, RoutedEventArgs e)
        {
            ConectarBD conectar = new ConectarBD();
            bool variavel = conectar.fazerlogin(UsuarioTxT.Text, SenhaTxT.Text);
            if (variavel)
            {
                MessageBox.Show("Bem vindo!");
                new TelaPrincipal().Show();
                this.Close();
            }
            else
                MessageBox.Show("usuario/senha incorreto");
        }
    }
}
