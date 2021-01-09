using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EndOfShift
{
    class Support
    {
        public static ArrayList parseValues(EditText etHundreds, EditText etFifties, EditText etTwenties, EditText etTens, EditText etFives, EditText etOnes,
            EditText etTwos, EditText etQuarters, EditText etDimes, EditText etNickels, EditText etPennies, EditText etDollars, EditText etHalfDollars)
        {
            ArrayList ret = new ArrayList();
            int hundreds, fifties, twenties, tens, fives, ones, twos, quarters, dimes, nickels, pennies, dollars, halfDollars;
            hundreds = fifties = twenties = tens = fives = ones = twos = quarters = dimes = nickels = pennies = dollars = halfDollars = 0;
            try
            {
                hundreds = int.Parse(etHundreds.Text);
                fifties = int.Parse(etFifties.Text);
                twenties = int.Parse(etTwenties.Text);
                tens = int.Parse(etTens.Text);
                fives = int.Parse(etFives.Text);
                ones = int.Parse(etOnes.Text);
                twos = int.Parse(etTwos.Text);
                quarters = int.Parse(etQuarters.Text);
                dimes = int.Parse(etDimes.Text);
                nickels = int.Parse(etNickels.Text);
                pennies = int.Parse(etPennies.Text);
                dollars = int.Parse(etDollars.Text);
                halfDollars = int.Parse(etHalfDollars.Text);
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
    }
}