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
using System.Xml;

namespace ControlsLib
{
    /// <summary>
    /// Логика взаимодействия для CheckListItem.xaml
    /// </summary>
    public partial class CheckListItem : UserControl
    {
        public string name { get; private set; }
        public bool selected { get; private set; }

        public CheckListItem(string name, bool selected, BitmapImage? image)
        {
            InitializeComponent();
            this.name = name;
            this.selected = selected;

            SelectedCheckBox.IsChecked = selected;
            Label.Content = name;
            Image.Source = image;
        }

        private void SelectedCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            selected = true;
        }

        private void SelectedCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            selected = false;
        }
    }
}
