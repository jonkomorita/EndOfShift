using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections;

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


            //TextChanged events for EditTexts [Bills]
            etHundreds.TextChanged += ETextChanged;
            etFifties.TextChanged += ETextChanged;
            etTwenties.TextChanged += ETextChanged;
            etTens.TextChanged += ETextChanged;
            etFives.TextChanged += ETextChanged;
            etOnes.TextChanged += ETextChanged;
            etTwos.TextChanged += ETextChanged;

            //TextChanged Events [Coins]
            etQuarters.TextChanged += ETextChanged;
            etDimes.TextChanged += ETextChanged;
            etNickels.TextChanged += ETextChanged;
            etPennies.TextChanged += ETextChanged;
            etDollars.TextChanged += ETextChanged;
            etHalfDollars.TextChanged += ETextChanged;
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
          */
        public void ETextChanged(object sender, Android.Text.TextChangedEventArgs ex)
        {
            var changed = (EditText)sender;
            var id = changed.Id;

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

            ArrayList vals = Support.getValues(Support.parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos, 
                                                                   etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
            
            if( id == Resource.Id.etHundreds)
            {
                txtHundreds.Text = vals[0].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            }
            else if( id == Resource.Id.etFifties)
            {
                txtFifties.Text = vals[1].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            }
            else if (id == Resource.Id.etTwenties)
            {
                txtTwenties.Text = vals[2].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            }
            else if (id == Resource.Id.etTens)
            {
                txtTens.Text = vals[3].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            }
            else if (id == Resource.Id.etFives)
            {
                txtFives.Text = vals[4].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            }
            else if (id == Resource.Id.etOnes)
            {
                txtOnes.Text = vals[5].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            }
            else if (id == Resource.Id.etTwos)
            {
                txtTwos.Text = vals[6].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            }
            else if (id == Resource.Id.etQuarters)
            {
                txtQuarters.Text = vals[7].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            }
            else if (id == Resource.Id.etDimes)
            {
                txtDimes.Text = vals[8].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            }
            else if (id == Resource.Id.etNickels)
            {
                txtNickels.Text = vals[9].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            }
            else if (id == Resource.Id.etPennies)
            {
                txtPennies.Text = vals[10].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            }
            else if (id == Resource.Id.etDollars)
            {
                txtDollars.Text = vals[11].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            }
            else if (id == Resource.Id.etHalfDollars)
            {
                txtHalfDollars.Text = vals[12].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            }

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        
    }
}