using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using System.Collections;

namespace EndOfShift
{

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
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
        ArrayList total_values = new ArrayList();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            // References to all needed components
            EditText etHundreds = FindViewById<EditText>(Resource.Id.etHundreds);
            TextView txtHundreds = FindViewById<TextView>(Resource.Id.txtHundredsTotal);

            EditText etFifties = FindViewById<EditText>(Resource.Id.etFifties);
            TextView txtFifties = FindViewById<TextView>(Resource.Id.txtFiftiesTotal);

            EditText etTwenties = FindViewById<EditText>(Resource.Id.etTwenties);
            TextView txtTwenties = FindViewById<TextView>(Resource.Id.txtTwentiesTotal);

            EditText etTens = FindViewById<EditText>(Resource.Id.etTens);
            TextView txtTens = FindViewById<TextView>(Resource.Id.txtTensTotal);

            EditText etFives = FindViewById<EditText>(Resource.Id.etFives);
            TextView txtFives = FindViewById<TextView>(Resource.Id.txtFivesTotal);

            EditText etOnes = FindViewById<EditText>(Resource.Id.etOnes);
            TextView txtOnes = FindViewById<TextView>(Resource.Id.txtOnesTotal);

            EditText etTwos = FindViewById<EditText>(Resource.Id.etTwos);
            TextView txtTwos = FindViewById<TextView>(Resource.Id.txtTwosTotal);

            EditText etQuarters = FindViewById<EditText>(Resource.Id.etQuarters);
            TextView txtQuarters = FindViewById<TextView>(Resource.Id.txtQuartersTotal);

            EditText etDimes = FindViewById<EditText>(Resource.Id.etDimes);
            TextView txtDimes = FindViewById<TextView>(Resource.Id.txtDimesTotal);

            EditText etNickels = FindViewById<EditText>(Resource.Id.etNickels);
            TextView txtNickels = FindViewById<TextView>(Resource.Id.txtNickelsTotal);

            EditText etPennies = FindViewById<EditText>(Resource.Id.etPennies);
            TextView txtPennies = FindViewById<TextView>(Resource.Id.txtPenniesTotal);

            EditText etDollars = FindViewById<EditText>(Resource.Id.etDollars);
            TextView txtDollars = FindViewById<TextView>(Resource.Id.txtDollarsTotal);

            EditText etHalfDollars = FindViewById<EditText>(Resource.Id.etHalfDollars);
            TextView txtHalfDollars = FindViewById<TextView>(Resource.Id.txtHalfDollarsTotal);

            TextView txtTotal = FindViewById<TextView>(Resource.Id.txtTotalDisp);


            //TextChanged events for EditTexts [Bills]
            etHundreds.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = getValues(parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos, 
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtHundreds.Text = vals[0].ToString();
                txtTotal.Text = calculateTotalRegister(vals).ToString();
            };

            etFifties.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = getValues(parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtFifties.Text = vals[1].ToString();
                txtTotal.Text = calculateTotalRegister(vals).ToString();
            };

            etTwenties.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = getValues(parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtTwenties.Text = vals[2].ToString();
                txtTotal.Text = calculateTotalRegister(vals).ToString();
            };

            etTens.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = getValues(parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtTens.Text = vals[3].ToString();
                txtTotal.Text = calculateTotalRegister(vals).ToString();
            };

            etFives.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = getValues(parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtFives.Text = vals[4].ToString();
                txtTotal.Text = calculateTotalRegister(vals).ToString();
            };

            etOnes.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = getValues(parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtOnes.Text = vals[5].ToString();
                txtTotal.Text = calculateTotalRegister(vals).ToString();
            };

            etTwos.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = getValues(parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtTwos.Text = vals[6].ToString();
                txtTotal.Text = calculateTotalRegister(vals).ToString();
            };

            //TextChanged Events [Coins]
            etQuarters.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = getValues(parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtQuarters.Text = vals[7].ToString();
                txtTotal.Text = calculateTotalRegister(vals).ToString();
            };

            etDimes.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = getValues(parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtDimes.Text = vals[8].ToString();
                txtTotal.Text = calculateTotalRegister(vals).ToString();
            };

            etNickels.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = getValues(parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtNickels.Text = vals[9].ToString();
                txtTotal.Text = calculateTotalRegister(vals).ToString();
            };

            etPennies.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = getValues(parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtPennies.Text = vals[10].ToString();
                txtTotal.Text = calculateTotalRegister(vals).ToString();
            };

            etDollars.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = getValues(parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtDollars.Text = vals[11].ToString();
                txtTotal.Text = calculateTotalRegister(vals).ToString();
            };

            //etHalfDollars.TextChanged += ETextChanged;
            
            etHalfDollars.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = getValues(parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtHalfDollars.Text = vals[12].ToString();
                txtTotal.Text = calculateTotalRegister(vals).ToString();
            };
        }

        /*public void ETextChanged( object sender, Android.Text.TextChangedEventArgs ex)
        {
            ArrayList vals = getValues(parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
            txtHalfDollars.Text = vals[12].ToString();
            txtTotal.Text = calculateTotalRegister(vals).ToString();
        }*/
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private ArrayList getValues(ArrayList parsedValues)
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

        private ArrayList parseValues(EditText etHundreds, EditText etFifties, EditText etTwenties, EditText etTens, EditText etFives, EditText etOnes,
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
            catch(Exception ex)
            {
                // Do Nothing
            }

            return new ArrayList()
            {
                hundreds, fifties, twenties, tens, fives, ones, twos,
                quarters, dimes, nickels, pennies, dollars, halfDollars
            };

        }

        private double calculateTotalRegister( ArrayList vals)
        {
            double total = 0.0;
            foreach( object d in vals )
            {
                total += Convert.ToDouble(d);
            }
            return total;
        }
    }
}