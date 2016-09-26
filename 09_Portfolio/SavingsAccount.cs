using System;
using System.Globalization;
namespace _09_Portfolio
{
    internal class SavingsAccount : Asset
    {
        public String Symbol { get; internal set; }
        public double Value { get; internal set; }
        public double InterestRate { get; internal set; }

        public SavingsAccount(string symbol = "", double value = 0, double interest = 0)
        {
            this.Symbol = Symbol;
            this.Value = value;
            this.InterestRate = interest;
        }

        public override string ToString()
        {
            return String.Format("SavingsAccount[value={0:#.00},interestRate={1}]", Value.ToString(CultureInfo.InvariantCulture), InterestRate);
        }

         public double GetValue()
        {
            return Value;
        }

        public void ApplyInterest()
        {
            this.Value = Value + (Value * (InterestRate/100));
        }

    }
}