using System;
using System.Globalization;

namespace _09_Portfolio
{
    internal class Stock : Asset
    {
        public double NumShares { get; internal set; }
        public double PricePerShare { get; internal set; }
        public string Symbol { get; internal set; }

        public double GetValue()
        {
            return (PricePerShare * NumShares);
        }

        public Stock(string symbol = "", double pricePerShare = 0, double numShares = 0)
        {
            this.Symbol = symbol;
            this.PricePerShare = pricePerShare;
            this.NumShares = numShares;
        }
        public static double TotalValue(Asset[] stocks)
        {
            double returnValue = 0;
            foreach (Asset element in stocks)
            {
                returnValue += element.GetValue();
            }
            return returnValue;
        }

        public override string ToString()
        {
            return String.Format("Stock[symbol={0},pricePerShare={1},numShares={2}]", Symbol, PricePerShare.ToString(CultureInfo.InvariantCulture), NumShares);
        }

        public bool Equals(Stock stock)
        {
            if (stock.NumShares == this.NumShares && stock.Symbol == this.Symbol && stock.PricePerShare == this.PricePerShare ) return true;
            else return false; 
        }
    }
}