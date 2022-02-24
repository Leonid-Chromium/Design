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

namespace Design.UCs
{
    /// <summary>
    /// Логика взаимодействия для TeamCard.xaml
    /// </summary>
    public partial class TeamCard : UserControl
    {
        public string TeamNameStr { get; set; }
        public string RosterStr { get; set; }
        public string MatchupStr { get; set; }
        public string FirstLineupStr { get; set; }

    public TeamCard()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
