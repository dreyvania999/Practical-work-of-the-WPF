using System;
using System.Windows;
using System.Windows.Controls;

namespace work1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void resh()
        {
            char[] d = "qwertyuiopasdfghjkl;:zxcvbnm,.1234567890 ".ToCharArray();
            string f = EndData.SelectedItem.ToString().ToLower().Trim(d);
            switch (EndData.SelectedIndex)
            {
                case 0:
                    TBlResult.Text = Convert.ToString(Convert.ToInt32(inputKM.Text.ToString()) * 0.6214 + Convert.ToDouble(inputM.Text.ToString()) * 0.000621371) + " значенее переведенное в " +f;
                    break;
                case 1:
                    TBlResult.Text = Convert.ToString(Convert.ToInt32(inputKM.Text.ToString()) * 3280.84 + Convert.ToDouble(inputM.Text.ToString()) * 3.281) + " значенее переведенное в " + f;
                    break;
                case 2:
                    TBlResult.Text = Convert.ToString(Convert.ToInt32(inputKM.Text.ToString()) * 1093.61 + Convert.ToDouble(inputM.Text.ToString()) * 1.0936) + " значенее переведенное в " + f;
                    break;
                case 3:
                    TBlResult.Text = Convert.ToString(Convert.ToInt32(inputKM.Text.ToString()) * 39370 + Convert.ToDouble(inputM.Text.ToString()) * 39.370) + " значенее переведенное в " + f;
                    break;
                case 4:
                    TBlResult.Text = Convert.ToString(Convert.ToInt32(inputKM.Text.ToString()) * 0.937383 + Convert.ToDouble(inputM.Text.ToString()) * 0.000937382827146607) + " значенее переведенное в " + f;
                    break;
                
            }
        }
        private void reshSombody(double coefMetrs)
        {
            double c = Convert.ToDouble(inputS.Text.ToString()) * coefMetrs;
            int f = (int)(c / 1000);
            double d = c % 1000;
            TBlResult.Text = f + " километров и " + d + " метров";
        }
        private void BTddd_Click(object sender, RoutedEventArgs e)
        {
            switch (CBTreagle.SelectedIndex)
            {
                case 0:
                    resh();

                    break;
                case 1:
                    reshSombody(1609.344);
                    break;
                case 2:
                    reshSombody(0.3048);
                    break;
                case 3:

                    reshSombody(0.9144);
                    break;
                case 4:
                    reshSombody(0.0254);

                    break;
                case 5:

                    reshSombody(1066.8);
                    break;
            }
        }

        private void ActivateVisibleForSombodySelected( string f)
        {
            squareTreagleABC.Visibility = Visibility.Visible;
            selectEnd.Visibility = Visibility.Collapsed;
            ddd.Visibility = Visibility.Visible;
            squareTreagleParamABA.Visibility = Visibility.Collapsed;
            inputSombady.Text = "Введите " + f;
        }
        private void CBTreagle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            char[] d = "qwertyuiopasdfghjkl;:zxcvbnm,.1234567890 ".ToCharArray();
            string f = CBTreagle.SelectedItem.ToString().ToLower().Trim(d);
            switch (CBTreagle.SelectedIndex)
            {
                case 0:

                    squareTreagleParamABA.Visibility = Visibility.Visible;
                    selectEnd.Visibility = Visibility.Visible;
                    ddd.Visibility = Visibility.Collapsed;
                    squareTreagleABC.Visibility = Visibility.Collapsed;
                    break;
                case 1:
                    ActivateVisibleForSombodySelected(f);

                    break;
                case 2:
                    ActivateVisibleForSombodySelected(f);
                    break;
                case 3:
                    ActivateVisibleForSombodySelected(f);
                    break;
                case 4:
                    ActivateVisibleForSombodySelected(f);
                    break;
                case 5:
                    ActivateVisibleForSombodySelected(f);
                    break;
            }
        }

        private void EndData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ddd.Visibility = Visibility.Visible;

        }

    }
}
