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

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Game> games = new List<Game>();

        public MainWindow()
        {
            InitializeComponent();

            this.Title = "Game Industry Repository";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Game g1 = new Game()
            {
                CompanyName = "Naughty Dog",
                CompanyGame = "Crash Bandicoot",
                GameInfo = "Released 1996 for PS1",GameScore=80,
                CompanyImage = "/Resources/naughty-dog-logo.png"
            };
            Game g2= new Game()
            {
                CompanyName = "Bungie",
                CompanyGame = "Halo",
                GameInfo = "Released 2001 for Xbox",
                GameScore = 97,
                CompanyImage = "/Resources/halo.jpg"
            };
            Game g3 = new Game()
            {
                CompanyName = "Nintendo",
                CompanyGame = "Mario 64",
                GameInfo = "Released 1996 for N64",
                GameScore = 94,
                CompanyImage = "/Resources/halo.jpg"
            };
            Game g4 = new Game()
            {
                CompanyName = "Derek Yu",
                CompanyGame = "Spelunky",                
                GameInfo = "Released 2008 for Xbox store",
                GameScore = 65,
                CompanyImage = "/Resources/spelunky.jpg"
            };
            Game g5 = new Game()
            {
                CompanyName = "Valve",
                CompanyGame = "Half Life",
                GameInfo = "Released 1996 for PC",
                GameScore = 79,
                CompanyImage = "/Resources/halo.jpg"
            };

            games.Add(g1);
            games.Add(g2);

            lbxCompany.ItemsSource = games;
            }
    }
}
