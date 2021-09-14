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

namespace Telegram
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

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UserControl1 uc1 = new UserControl1();
            uc1.Width = 640;
            uc1.Message1Txtblock.Text = "Can you check the email?";
            uc1.Message2Txtblock.Text = "thank you very much ";
            uc1.Message3Txtblock.Text = "I looked";
            uc1.Message4Txtblock.Text = "Good bye,See you later";
            MessageGrid.Children.Add(uc1);
        }

        private void Grid_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            UserControl2 uc1 = new UserControl2();
            uc1.Width = 640;
            uc1.ImageCentral.Source = new BitmapImage(new Uri(@"/Images/leonardo.jpg", UriKind.Relative));
            uc1.NameCentral.Content = "Leonardo";
            uc1.Message1Txtblock.Text = "Hi ";
            uc1.Message2Txtblock.Text = "Finally got my oscar award ";
            uc1.Message3Txtblock.Text = "Congratulations. You deserve it";
            uc1.Message4Txtblock.Text = "Yes, i waited so long for this";
            MessageGrid.Children.Add(uc1);
        }

        private void Grid_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            UserControl1 uc1 = new UserControl1();
            uc1.Width = 640;            
            uc1.ImageCentral.Source = new BitmapImage(new Uri(@"/Images/Christopher_Nolan.jpg", UriKind.Relative));
            uc1.NameCentral.Content = "Christopher N";
            uc1.Message1Txtblock.Text = "What is your favorite movie? ";
            uc1.Message2Txtblock.Text = "Interstellar, Prestij ";
            uc1.Message3Txtblock.Text = "Your movies are amazing";
            uc1.Message4Txtblock.Text = "Thank you very much";
            MessageGrid.Children.Add(uc1);
        }

        private void Grid_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            UserControl1 uc1 = new UserControl1();
            uc1.Width = 640;
            uc1.ImageCentral.Source = new BitmapImage(new Uri(@"/Images/jennifer.jpg", UriKind.Relative));
            uc1.NameCentral.Content = "Jennifer";
            uc1.Message1Txtblock.Text = "Can you check the email?";
            uc1.Message2Txtblock.Text = "thank you very much ";
            uc1.Message3Txtblock.Text = "I looked";
            uc1.Message4Txtblock.Text = "Good bye";
            MessageGrid.Children.Add(uc1);
        }

        private void Grid_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            UserControl2 uc1 = new UserControl2();
            uc1.Width = 640;
            uc1.ImageCentral.Source = new BitmapImage(new Uri(@"/Images/jared.jpg", UriKind.Relative));
            uc1.NameCentral.Content = "Jared";
            uc1.Message1Txtblock.Text = "Hi";
            uc1.Message2Txtblock.Text = "Did you watch the movie I told you about?";
            uc1.Message3Txtblock.Text = "Hi, there was no opportunity";
            uc1.Message4Txtblock.Text = "Ok, See you later.";
            MessageGrid.Children.Add(uc1);
        }

        private void Grid_MouseDown_5(object sender, MouseButtonEventArgs e)
        {
            UserControl1 uc1 = new UserControl1();
            uc1.Width = 640;
            uc1.ImageCentral.Source = new BitmapImage(new Uri(@"/Images/mark.jpg", UriKind.Relative));
            uc1.NameCentral.Content = "Mark";
            uc1.Message1Txtblock.Text = "Hi";
            uc1.Message2Txtblock.Text = "Hi";
            uc1.Message3Txtblock.Text = "What do you think about telegram?";
            uc1.Message4Txtblock.Text = "I recommend whatsapp app...";
            MessageGrid.Children.Add(uc1);
        }
    }
}
