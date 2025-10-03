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
using System.Xml.Linq;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void ApplyBtn_Click(object sender, RoutedEventArgs e)
        {
            //If row and column is entered, then create a new button
            //with info about row and column in the designated grid box
            if (!string.IsNullOrWhiteSpace(txtRow.Text) && !string.IsNullOrWhiteSpace(txtColumn.Text))
            {
                Button newButton = new Button();
                int row = int.Parse(txtRow.Text);
                int column = int.Parse(txtColumn.Text);
                newButton.Content = ($"Row {row}, Column {column}");
                Grid.SetRow(newButton, row);
                Grid.SetColumn(newButton, column);
                newButton.Background = new SolidColorBrush(System.Windows.Media.Colors.LightGreen);
                ButtonGrid.Children.Add(newButton);
            }
            else MessageBox.Show("Ange både Rad och Kolumn");
        }
    }
}
