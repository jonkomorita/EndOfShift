using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections;
using System;

namespace EndOfShift
{

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            // References to all needed components
            EditText etHundreds = FindViewById<EditText>(Resource.Id.etHundreds);
            EditText etFifties = FindViewById<EditText>(Resource.Id.etFifties);
            EditText etTwenties = FindViewById<EditText>(Resource.Id.etTwenties);
            EditText etTens = FindViewById<EditText>(Resource.Id.etTens);
            EditText etFives = FindViewById<EditText>(Resource.Id.etFives);
            EditText etOnes = FindViewById<EditText>(Resource.Id.etOnes);
            EditText etTwos = FindViewById<EditText>(Resource.Id.etTwos);
            EditText etQuarters = FindViewById<EditText>(Resource.Id.etQuarters);
            EditText etDimes = FindViewById<EditText>(Resource.Id.etDimes);
            EditText etNickels = FindViewById<EditText>(Resource.Id.etNickels);
            EditText etPennies = FindViewById<EditText>(Resource.Id.etPennies);
            EditText etDollars = FindViewById<EditText>(Resource.Id.etDollars);
            EditText etHalfDollars = FindViewById<EditText>(Resource.Id.etHalfDollars);
            EditText etDrops = FindViewById<EditText>(Resource.Id.etDrops);


            //TextChanged events for EditTexts [Bills]
            etHundreds.TextChanged += OTextChanged;
            etFifties.TextChanged += OTextChanged;
            etTwenties.TextChanged += OTextChanged;
            etTens.TextChanged += OTextChanged;
            etFives.TextChanged += OTextChanged;
            etOnes.TextChanged += OTextChanged;
            etTwos.TextChanged += OTextChanged;

            //TextChanged Events [Coins]
            etQuarters.TextChanged += OTextChanged;
            etDimes.TextChanged += OTextChanged;
            etNickels.TextChanged += OTextChanged;
            etPennies.TextChanged += OTextChanged;
            etDollars.TextChanged += OTextChanged;
            etHalfDollars.TextChanged += OTextChanged;

            //TextChanged Event [Drops]
            etDrops.TextChanged += OTextChanged;
        }
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
          * 13 - drops
          */
        public void OTextChanged(object sender, Android.Text.TextChangedEventArgs ex)
        {
            var changed = (EditText)sender;
            var id = changed.Id;

            // Get rid of leading 0 when first clicking
            EditText etChanged = FindViewById<EditText>(id);
            string txt = etChanged.Text;
            if (txt.Length > 1 && txt.StartsWith("0"))
                etChanged.Text = txt.Substring(1);

            // get reference to EditText and TextViews
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

            EditText etDrops = FindViewById<EditText>(Resource.Id.etDrops);
            TextView txtDropsTotal = FindViewById<TextView>(Resource.Id.txtDropsTotal);


            // Build arraylist of totals [stored as objects]
            ArrayList vals = Support.getValues(Support.parseValues( new string[] { etHundreds.Text, etFifties.Text, etTwenties.Text, etTens.Text, etFives.Text, etOnes.Text, etTwos.Text, 
                                                                   etQuarters.Text, etDimes.Text, etNickels.Text, etPennies.Text, etDollars.Text, etHalfDollars.Text, etDrops.Text }));
            
            // Check id for which component we are working on, then convert object in vals to string
            //  or to a double depending on which one is needed
            if( id == Resource.Id.etHundreds)
            {
                txtHundreds.Text = Support.formattedTotal(vals[0]);
                txtTotal.Text = Support.formattedDecimal(Support.calculateTotalRegister(vals));
            }
            else if( id == Resource.Id.etFifties)
            {
                txtFifties.Text = Support.formattedTotal(vals[1]);
                txtTotal.Text = Support.formattedDecimal(Support.calculateTotalRegister(vals));
            }
            else if (id == Resource.Id.etTwenties)
            {
                txtTwenties.Text = Support.formattedTotal(vals[2]);
                txtTotal.Text = Support.formattedDecimal(Support.calculateTotalRegister(vals));
            }
            else if (id == Resource.Id.etTens)
            {
                txtTens.Text = Support.formattedTotal(vals[3]);
                txtTotal.Text = Support.formattedDecimal(Support.calculateTotalRegister(vals));
            }
            else if (id == Resource.Id.etFives)
            {
                txtFives.Text = Support.formattedTotal(vals[4]);
                txtTotal.Text = Support.formattedDecimal(Support.calculateTotalRegister(vals));
            }
            else if (id == Resource.Id.etOnes)
            {
                txtOnes.Text = Support.formattedTotal(vals[5]);
                txtTotal.Text = Support.formattedDecimal(Support.calculateTotalRegister(vals));
            }
            else if (id == Resource.Id.etTwos)
            {
                txtTwos.Text = Support.formattedTotal(vals[6]);
                txtTotal.Text = Support.formattedDecimal(Support.calculateTotalRegister(vals));
            }
            else if (id == Resource.Id.etQuarters)
            {
                txtQuarters.Text = Support.formattedDecimal(Convert.ToDouble(vals[7]));
                txtTotal.Text = Support.formattedDecimal(Support.calculateTotalRegister(vals));
            }
            else if (id == Resource.Id.etDimes)
            {
                txtDimes.Text = Support.formattedDecimal(Convert.ToDouble(vals[8]));
                txtTotal.Text = Support.formattedDecimal(Support.calculateTotalRegister(vals));
            }
            else if (id == Resource.Id.etNickels)
            {
                txtNickels.Text = Support.formattedDecimal(Convert.ToDouble(vals[9]));
                txtTotal.Text = Support.formattedDecimal(Support.calculateTotalRegister(vals));
            }
            else if (id == Resource.Id.etPennies)
            {
                txtPennies.Text = Support.formattedDecimal(Convert.ToDouble(vals[10]));
                txtTotal.Text = Support.formattedDecimal(Support.calculateTotalRegister(vals));
            }
            else if (id == Resource.Id.etDollars)
            {
                txtDollars.Text = Support.formattedTotal(vals[11]);
                txtTotal.Text = Support.formattedDecimal(Support.calculateTotalRegister(vals));
            }
            else if (id == Resource.Id.etHalfDollars)
            {
                txtHalfDollars.Text = Support.formattedDecimal(Convert.ToDouble(vals[12]));
                txtTotal.Text = Support.formattedDecimal(Support.calculateTotalRegister(vals));
            }
            else if( id == Resource.Id.etDrops)
            {
                txtDropsTotal.Text = Support.formattedTotal(vals[13]);
            }

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        
    }

}