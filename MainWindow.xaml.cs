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

namespace CoinInventory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Position> positions = new();

            Position pos1 = new(1, "BTC", 0.005, 5000, "Open");
            Position pos2 = new(2, "BCH", 0.05, 200, "Open");
            positions.Add(pos1);
            positions.Add(pos2);

            DG1.DataContext = positions;
        }
    }
    public class Position
    {
        public Position(int id, string ticker, double pos_amount, double hist_price, string status)
        {
            Id = id;
            TickerName = ticker;
            PositionAmount = pos_amount;
            HistoricalPrice = hist_price;
            Status = status;
        }

        public int Id { get; set; }
        public string TickerName { get; set; }
        public double PositionAmount { get; set; }
        public double HistoricalPrice { get; set; }
        public string Status { get; set; }

    }
}
