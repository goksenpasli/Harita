using System.Windows;
using System.Windows.Input;
using System.Windows.Shapes;
using System.Linq;
namespace Harita
{

    public partial class MainWindow: Window
	{
        public MainWindow() => InitializeComponent();
        void Document_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => AddHandler(MouseLeftButtonUpEvent, new RoutedEventHandler(Tıkla));
        void Tıkla(object x, RoutedEventArgs e)
		{
            var veri = new Veri();
            if (!(e.OriginalSource is Path))
            {
                MessageBox.Show("İllerin Üzerine Tıklayın.");
                return;
            }
            if (e.OriginalSource is Path p && tbilismi.Text == p.Name)
            {
                MessageBox.Show("Tebrikler Bildin.");
                p.Visibility = Visibility.Collapsed;
                veri.iller.Remove(p.Name);
                if (veri.iller.Any()) Veri.Yeniİl(this);
                else
                    MessageBox.Show("Bitti.");
            }
            else
                MessageBox.Show("Cevap Yanlış.");
            e.Handled = true;
		}
        void Window_Loaded(object sender, RoutedEventArgs e) => Veri.Yeniİl(this);
    }
}