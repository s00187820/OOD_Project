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
using System.IO;
using Newtonsoft.Json;

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
                GameInfo = "Released 1996 for PS1",
                GameScore = 80,
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
                CompanyImage = "/Resources/mario.png"
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
                CompanyImage = "/Resources/half-life-logo.jpg"
            };
            Game g6 = new Game()
            {
                CompanyName = "Nintendo",
                CompanyGame = "The legend of Zelda Ocarina Of Time",
                GameInfo = "Released 1998 for N64",
                GameScore = 99,
                CompanyImage = "/Resources/zelda.jpg"
            };
            Game g7 = new Game()
            {
                CompanyName = "Nintendo",
                CompanyGame = "Pokemon Red and Blue",
                GameInfo = "Released 1996 for Gameboy",
                GameScore = 94,
                CompanyImage = "/Resources/pokemon_red_blue_main.jpg"
            };

            games.Add(g1);
            games.Add(g2);
            games.Add(g3);
            games.Add(g4);
            games.Add(g5);
            games.Add(g6);
            games.Add(g7);

            lbxCompany.ItemsSource = games;
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Info Box");
        }

        private void LbxCompany_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbxTeam.Text = lbxCompany.SelectedItem.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page1 Page1 = new Page1();
            Main.Content = Page1.Content;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Page2 Page2 = new Page2();
            Main.Content = Page2.Content;
        }

        private void TbxTeam_Initialized(object sender, EventArgs e)
        {

        }
    }
}
