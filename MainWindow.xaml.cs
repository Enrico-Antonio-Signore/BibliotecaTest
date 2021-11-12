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

namespace Biblioteca_Verifica
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Biblioteca Biblioteca;
        public MainWindow()
        {
            InitializeComponent();
            Biblioteca = new Biblioteca("Malatestiana", "Via Rossi 23", 08, 18);
            AggiornaWPF();
        }

        private void btnCrea_Click(object sender, RoutedEventArgs e)
        {
            Libro l = new Libro(txtNome.Text,txtAutore.Text, int.Parse(txtPagine.Text));
            Biblioteca.listalibri.Add(l);
            cmbLibri.Items.Add(l.Nome);
            cmbLibriAutore.Items.Add(l.Autore);
            AggiornaWPF();
        }
        public void AggiornaWPF()
        {
            int x = 0;
            lstLibri.Items.Clear();
            foreach(Libro l in Biblioteca.listalibri)
            {
                lstLibri.Items.Add(l.ToString());
                x++;
            }
            lblNLibri.Content = x;
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            lstLibriInfo.Items.Clear();
            foreach (Libro l in Biblioteca.listalibri)
            {
                if(l.Nome == cmbLibri.SelectedItem.ToString())
                {
                    lstLibriInfo.Items.Add(l.ToString());
                }
            }
        }

        private void btnInfoAutore_Click(object sender, RoutedEventArgs e)
        {
            lstLibriInfo.Items.Clear();
            foreach (Libro l in Biblioteca.listalibri)
            {
                if (l.Autore == cmbLibriAutore.SelectedItem.ToString())
                {
                    lstLibriInfo.Items.Add(l.ToString());
                }
            }
        }
    }
}
