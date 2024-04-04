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

namespace yourFirstName_yourLastName
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = textname.Text.Trim();
            String age = textage.Text.Trim();
            string email = textemail.Text.Trim();
            double height = sliderheight.Value;
            double weigth = sliderweight.Value;

            if (string.IsNullOrWhiteSpace(textname.Text))
            {
                MessageBox.Show("enter nom valide.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            if (!int.TryParse(age, out int age) || age < 0)
            {
                MessageBox.Show("enter  age valid.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textemail.Text))
            {
                MessageBox.Show("enter email valid .", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

           
            if (height < 100 || height > 250)
            {
                MessageBox.Show("enter taille valide.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            double weight = sliderweight.Value;
            if (weight < 30 || weight > 150)
            {
                MessageBox.Show("enter poid valide.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // If all validation passes, you can proceed with further actions, like saving the data.
            MessageBox.Show("Data submitted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        listBox1.Items.Add($"Name: {name}, Age: {age}, Email: {email}, Height: {height}, Weigth: {weigth}");
    listBox1.Items.Refresh();
  }

    
}
