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
                ArrayList vals = Support.getValues(Support.parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos, 
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtHundreds.Text = vals[0].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            };

            etFifties.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = Support.getValues(Support.parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtFifties.Text = vals[1].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            };

            etTwenties.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = Support.getValues(Support.parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtTwenties.Text = vals[2].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            };

            etTens.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = Support.getValues(Support.parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtTens.Text = vals[3].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            };

            etFives.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = Support.getValues(Support.parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtFives.Text = vals[4].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            };

            etOnes.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = Support.getValues(Support.parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtOnes.Text = vals[5].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            };

            etTwos.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = Support.getValues(Support.parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtTwos.Text = vals[6].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            };

            //TextChanged Events [Coins]
            etQuarters.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = Support.getValues(Support.parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtQuarters.Text = vals[7].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            };

            etDimes.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = Support.getValues(Support.parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtDimes.Text = vals[8].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            };

            etNickels.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = Support.getValues(Support.parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtNickels.Text = vals[9].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            };

            etPennies.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = Support.getValues(Support.parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtPennies.Text = vals[10].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            };

            etDollars.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = Support.getValues(Support.parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtDollars.Text = vals[11].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
            };

            //etHalfDollars.TextChanged += ETextChanged;
            
            etHalfDollars.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                ArrayList vals = Support.getValues(Support.parseValues(etHundreds, etFifties, etTwenties, etTens, etFives, etOnes, etTwos,
                                                        etQuarters, etDimes, etNickels, etPennies, etDollars, etHalfDollars));
                txtHalfDollars.Text = vals[12].ToString();
                txtTotal.Text = Support.calculateTotalRegister(vals).ToString();
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

        
    }
}