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
            var Administrador = new Administrador()
            {
                Username = UsuarioTxT.Text,
                Password = SenhaTxT.Password
            };
            var login = new Login(Administrador);
            
            if (login.logar())
            {
                MessageBox.Show("Bem vindo!");
                new TelaPrincipal().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
                UsuarioTxT.Clear();
                SenhaTxT.Clear();
            }
        }
    }
}
