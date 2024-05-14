using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Static_Currency_Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BindCurrency();
        }

        private void BindCurrency()
        {
            DataTable dtCurrency = new DataTable();
            dtCurrency.Columns.Add("Text");
            dtCurrency.Columns.Add("Value");

            // Add rows in the DataTable with text and value
            dtCurrency.Rows.Add("--SELECT--", 0);
            dtCurrency.Rows.Add("INR", 1);
            dtCurrency.Rows.Add("USD", 75);
            dtCurrency.Rows.Add("EUR", 85);
            dtCurrency.Rows.Add("SAR", 20);
            dtCurrency.Rows.Add("GBP", 90);
            dtCurrency.Rows.Add("DEM", 43);

            cmbFromCurrency.ItemsSource = dtCurrency.DefaultView;
            cmbFromCurrency.DisplayMemberPath = "Text";
            cmbFromCurrency.SelectedValuePath = "Value";
            cmbFromCurrency.SelectedIndex = 0;

            cmbToCurrency.ItemsSource = dtCurrency.DefaultView;
            cmbToCurrency.DisplayMemberPath = "Text";
            cmbToCurrency.SelectedValuePath = "Value";
            cmbToCurrency.SelectedIndex = 0;
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            // Create the variable as ConvertedValue with double datatype to store currency converted value
            double convertedValue;

            // Check if the amount TextBox is Null or Empty
            if (txtCurrency.Text == null || txtCurrency.Text.Trim() == "")
            {
                // If amount TextBox is Null or Empty it will show this message box
                MessageBox.Show("Please Enter Currency", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                // After clicking on MessageBox OK set focus on amount TextBox
                txtCurrency.Focus();
                return;
            }
            // Else if currency From is not selected or select default text --SELECT--
            else if (cmbFromCurrency.SelectedValue == null || cmbFromCurrency.SelectedIndex == 0)
            {
                // Show the message
                MessageBox.Show("Please Select Currency From", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                // Set focus on the From ComboBox
                cmbFromCurrency.Focus();
                return;
            }
            // Else if currency To is not selected or select default text --SELECT--
            else if (cmbToCurrency.SelectedValue == null || cmbToCurrency.SelectedIndex == 0)
            {
                // Show the message
                MessageBox.Show("Please Select Currency To", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                // Set focus on the To ComboBox
                cmbToCurrency.Focus();
                return;
            }

            // Check if From and To ComboBox selected values are the same
            if (cmbFromCurrency.Text == cmbToCurrency.Text)
            {
                // Amount TextBox value set in convertedValue
                // Double.Parse is used for converting the datatype String to Double
                // TextBox text have string and convertedValue is Double datatype
                convertedValue = double.Parse(txtCurrency.Text);
                // Show the label converted currency and converted currency name and ToString("N3") is used to place 000 after the dot(.)
                lblCurrency.Content = cmbToCurrency.Text + " " + convertedValue.ToString("N3");
            }
            else
            {
                // Calculation for currency converter is From Currency value multiply(*)
                // With the amount TextBox value and then that total divided(/) with To Currency value
                convertedValue = (double.Parse(cmbFromCurrency.SelectedValue.ToString()) *
                                  double.Parse(txtCurrency.Text)) / 
                                  double.Parse(cmbToCurrency.SelectedValue.ToString());

                // Show the label converted currency and converted currency name
                lblCurrency.Content = cmbToCurrency.Text + " " + convertedValue.ToString("N3");
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            txtCurrency.Text = string.Empty;
            if (cmbFromCurrency.Items.Count > 0)
            {
                cmbFromCurrency.SelectedIndex = 0;
            }
            if (cmbToCurrency.Items.Count > 0)
            {
                cmbToCurrency.SelectedIndex = 0;
            }
            lblCurrency.Content = "";
            txtCurrency.Focus();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+[,]+[.]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}