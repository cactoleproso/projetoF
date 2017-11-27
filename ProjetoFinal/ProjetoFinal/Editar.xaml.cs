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
    /// Lógica interna para Editar.xaml
    /// </summary>
    public partial class Editar : Window
    {
        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }

            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }

        }
        public Editar()
        {

            InitializeComponent();
            NumInt.Items.Add(new Item("1", 1));
            NumInt.Items.Add(new Item("2", 2));
            NumInt.Items.Add(new Item("3", 3));
            NumInt.Items.Add(new Item("4", 4));
            NumInt.Items.Add(new Item("5", 5));
            NumInt.Items.Add(new Item("6", 6));
            NumInt.Items.Add(new Item("7", 7));
            NumInt.Items.Add(new Item("8", 8));
            NumInt.Items.Add(new Item("9", 9));

            DiaPref.Items.Add(new Item("1", 1));
            DiaPref.Items.Add(new Item("2", 2));
        }

        private void CancelarBT_Click(object sender, RoutedEventArgs e)
        {
            new TelaPrincipal().Show();
            this.Close();
        }

        private void NomeBandaTxT_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CadastrarBT_Click(object sender, RoutedEventArgs e)
        {
            ConectarBD c = new ConectarBD();
            int inst;
            if (SIMradio.IsChecked == true)
                inst = 1;
            else
                inst = 0;


            int numintegrantes;
            if (NumInt.SelectedValue != null)
            {
                numintegrantes = ((Item)NumInt.SelectedValue).Value;
            }
            else
                numintegrantes = 0;

            int diapreferencial;
            if (DiaPref.SelectedValue != null)
            {
                //diapreferencial = (int)DiaPref.SelectedItem;
                diapreferencial = ((Item)DiaPref.SelectedValue).Value;
            }
            else
                diapreferencial = 0;
            if (c.cadastrar(NomeBandaTxT.Text, numintegrantes, NomeBandaTxT.Text, diapreferencial, inst))
            {
                MessageBox.Show("Edição feita com sucesso!");
                new TelaPrincipal().Show();
                this.Close();
            }
            else
                MessageBox.Show("Algum erro ocorreu");


        }
    
    }
}
