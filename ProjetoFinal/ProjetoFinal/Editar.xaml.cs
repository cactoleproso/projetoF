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
        public string nomeantes;
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
        public Editar(string x)
        {
            nomeantes = x;
            InitializeComponent();

            for(int i = 1; i < 10; i++)
                NumInt.Items.Add(new Item(i.ToString(), i));
            
            DiaPref.Items.Add(new Item("1", 1));
            DiaPref.Items.Add(new Item("2", 2));
        }

        private void CancelarBT_Click(object sender, RoutedEventArgs e)
        {
            new TelaPrincipal().Show();
            this.Close();
        }

        private void EditarBT_Click(object sender, RoutedEventArgs e)
        {
           
            var banda = new Banda();

            banda.Nome = NomeBandaTxT.Text;
            banda.NomeMusica = NomeMusicaTxT.Text;

            if (SIMradio.IsChecked == true)
                banda.Instrumento = 1;
            else
                banda.Instrumento = 0;

            if (NumInt.SelectedValue != null)
            {
                banda.NumIntegrantes = ((Item)NumInt.SelectedValue).Value;
            }
            else
                banda.NumIntegrantes = 0;

            if (DiaPref.SelectedValue != null)
            {
                banda.DiaPreferencial = ((Item)DiaPref.SelectedValue).Value;
            }
            else
                banda.DiaPreferencial = 0;


            var att = new Atualiza(banda, nomeantes);

            if (att.Atualizar())
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
