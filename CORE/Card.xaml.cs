using StickyNotes.CORE.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StickyNotes.CORE
{
    /// <summary>
    /// Lógica interna para Card.xaml
    /// </summary>
    public partial class Card : Window
    {
        private DBContext db = new DBContext();
        public Card()
        {
            InitializeComponent();
        }
    }

}
