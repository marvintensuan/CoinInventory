using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinInventory
{
    class clsPosition
    {
        public clsPosition(int id, string ticker, double pos_amount, double hist_price, string status)
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
