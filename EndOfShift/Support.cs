using Android.Widget;
using System;
using System.Collections;

namespace EndOfShift
{
    class Support
    {
        public const int Hundred = 100, Fifty = 50, Twenty = 20, Ten = 10, Five = 5, One = 1, Two = 2, Drop = 500;
        public const double Quarter = 0.25, Dime = 0.1, Nickel = 0.05, Penny = 0.01, HalfDollar = 0.5, Dollar = 1.0;
        /**
          * 0 - hundreds
          * 1 - fifties
          * 2 - twenties
          * 3 - tens
          * 4 - fives
          * 5 - ones
          * 6 - twos
          * 7 - quarters
          * 8 - dimes
          * 9 - nickels
          * 10 - pennies
          * 11 - dollars
          * 12 - half dollars
          */
        public static ArrayList getValues(ArrayList parsedValues)
        {
            ArrayList vals = new ArrayList();
            vals.Add(Hundred * (int)parsedValues[0]);
            vals.Add(Fifty * (int)parsedValues[1]);
            vals.Add(Twenty * (int)parsedValues[2]);
            vals.Add(Ten * (int)parsedValues[3]);
            vals.Add(Five * (int)parsedValues[4]);
            vals.Add(One * (int)parsedValues[5]);
            vals.Add(Two * (int)parsedValues[6]);
            vals.Add(Quarter * (int)parsedValues[7]);
            vals.Add(Dime * (int)parsedValues[8]);
            vals.Add(Nickel * (int)parsedValues[9]);
            vals.Add(Penny * (int)parsedValues[10]);
            vals.Add(Dollar * (int)parsedValues[11]);
            vals.Add(HalfDollar * (int)parsedValues[12]);
            return vals;
        }

        public static ArrayList parseValues(string[] vals)
        {
            int hundreds, fifties, twenties, tens, fives, ones, twos, quarters, dimes, nickels, pennies, dollars, halfDollars;
            hundreds = fifties = twenties = tens = fives = ones = twos = quarters = dimes = nickels = pennies = dollars = halfDollars = 0;

            for( int i = 0; i < vals.Length; i++)
            {
                if (vals[i].Equals("") || vals[i].Equals(null))
                    vals[i] = "0";
            }
            // if we try to fill edittext 20 before 50 or 100, then 50 & 100 will show up at blank and will fail parse
            // which is why nothing changes
            // EditText bug might be here
            try
            {
                hundreds = int.Parse(vals[0]);
                fifties = int.Parse(vals[1]);
                twenties = int.Parse(vals[2]);
                tens = int.Parse(vals[3]);
                fives = int.Parse(vals[4]);
                ones = int.Parse(vals[5]);
                twos = int.Parse(vals[6]);
                quarters = int.Parse(vals[7]);
                dimes = int.Parse(vals[8]);
                nickels = int.Parse(vals[9]);
                pennies = int.Parse(vals[10]);
                dollars = int.Parse(vals[11]);
                halfDollars = int.Parse(vals[12]);
            }
            catch (Exception ex)
            {
                // Do Nothing
            }

            return new ArrayList()
            {
                hundreds, fifties, twenties, tens, fives, ones, twos,
                quarters, dimes, nickels, pennies, dollars, halfDollars
            };

        }

        public static double calculateTotalRegister(ArrayList vals)
        {
            double total = 0.0;
            foreach (object d in vals)
            {
                total += Convert.ToDouble(d);
            }
            return total;
        }
    }
}