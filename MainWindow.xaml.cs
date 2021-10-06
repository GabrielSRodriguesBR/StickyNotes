using Microsoft.EntityFrameworkCore;
using StickyNotes.CORE;
using StickyNotes.CORE.DAL;
using StickyNotes.CORE.Models;
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

namespace StickyNotes
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DBContext db = new DBContext();



            InitializeComponent();
        }

        private void NewCard_Click(object sender, RoutedEventArgs e)
        {
            Card newCard = new Card();
            newCard.Show();
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OpenOptions_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
