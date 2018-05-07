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

namespace Aula02
{
    /// <summary>
    /// Lógica de interacción para DETI_Home.xaml
    /// </summary>
    public partial class DETI_Home : Page
    {

        public String selected;

        public DETI_Home()
        {
           InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DETI_Disciplinas cursosPage = new DETI_Disciplinas();
            this.NavigationService.Navigate(cursosPage);
        }

        private void itemSelected(object sender, SelectionChangedEventArgs e)
        {
            selected = ((ListBoxItem)listBox.SelectedValue).Content.ToString();
        }

    }
}
