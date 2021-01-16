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
          * 
          *  parses the value being passed in from MainActivity (objects) then calculate the totals
          *  and store into vals to return back to the user in MainActivity
          */
        public static ArrayList getValues(ArrayList parseValues)
        {
            ArrayList vals = new ArrayList();
            vals.Add(Hundred * (int)parseValues[0]);
            vals.Add(Fifty * (int)parseValues[1]);
            vals.Add(Twenty * (int)parseValues[2]);
            vals.Add(Ten * (int)parseValues[3]);
            vals.Add(Five * (int)parseValues[4]);
            vals.Add(One * (int)parseValues[5]);
            vals.Add(Two * (int)parseValues[6]);
            vals.Add(Quarter * (int)parseValues[7]);
            vals.Add(Dime * (int)parseValues[8]);
            vals.Add(Nickel * (int)parseValues[9]);
            vals.Add(Penny * (int)parseValues[10]);
            vals.Add(Dollar * (int)parseValues[11]);
            vals.Add(HalfDollar * (int)parseValues[12]);
            vals.Add(Drop * (int)parseValues[13]);
            return vals;
        }

        // ensure all values are filled out with at least a 0 for calculation
        public static ArrayList parseValues(string[] vals)
        {
            int hundreds, fifties, twenties, tens, fives, ones, twos, quarters, dimes, nickels, pennies, dollars, halfDollars, drops;
            hundreds = fifties = twenties = tens = fives = ones = twos = quarters = dimes = nickels = pennies = dollars = halfDollars = drops = 0;

            // if EditText[i].Text is blank or null, replace with 0
            for( int i = 0; i < vals.Length; i++)
            {
                if (vals[i].Equals("") || vals[i].Equals(null))
                    vals[i] = "0";
            }

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
                drops = int.Parse(vals[13]);
            }
            catch (Exception ex)
            {
                // Do Nothing
            }

            return new ArrayList()
            {
                hundreds, fifties, twenties, tens, fives, ones, twos,
                quarters, dimes, nickels, pennies, dollars, halfDollars, drops
            };

        }

        // calculate the total of all bills and coins [NOT drops]
        public static double calculateTotalRegister(ArrayList vals)
        {
            double total = 0.0;
            // i < vals.Count - 1 to skip the drops total
            for (int i = 0; i < vals.Count - 1; i++)
                total += Convert.ToDouble(vals[i]);
            return total;
        }
        
        // double into currency format
        public static string formattedDecimal( double d) => string.Format("{0:C}", d);

        public static string formattedTotal(object o) => $"${o}";
        
    }
}