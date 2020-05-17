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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Equation equation = new Equation();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            txtInput.Text = equation.BtnNumberClick(txtInput.Text, button.Content.ToString());
        }

        private void operator_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            txtInput.Text = equation.BtnOperatorClick(txtInput.Text, button.Content.ToString());
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = equation.BtnEqualClick(txtInput.Text);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = equation.BtnClear(txtInput.Text);
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = equation.BtnSqrtClick(txtInput.Text);
        }

        private void btnPow_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = equation.BtnPowClick(txtInput.Text);
        }

        private void btnReverse_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = equation.BtnReverseClick(txtInput.Text);
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = equation.BtnDelClick(txtInput.Text);
        }

        private void btnPercent_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = equation.BtnPercentClick(txtInput.Text);
        }

        private void btnPoint_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            txtInput.Text = equation.BtnPointClick(txtInput.Text, button.Content.ToString());
        }

        private void btnPozNeg_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = equation.BtnPozNegClick(txtInput.Text);
        }
    }
}
