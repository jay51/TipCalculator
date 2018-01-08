using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace TipCalculator
{
    [Activity(Label = "TipCalculator", MainLauncher = true, Icon = "@mipmap/icon")]//make this the primary entry point
    public class MainActivity : Activity
    {
        EditText etxtBill;
        Button btnCal;
        TextView txtTip;
        TextView txtTotal;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource //views you are trying to access are created in SetContentView so views don't exist until after that call completes
            SetContentView(Resource.Layout.Main);

            
            //Get our enrty from the layout resource
            etxtBill = FindViewById<EditText>(Resource.Id.etxtBill);
            // Get our button from the layout resource,
            btnCal = FindViewById<Button>(Resource.Id.btnCalculate);
            // get text of Tip and Bill
            txtTip = FindViewById<TextView>(Resource.Id.txtTip);
            txtTotal = FindViewById<TextView>(Resource.Id.txtTotal);


            //anyonmus event handler
            btnCal.Click += (Object sender,EventArgs e) => 
            {
                // tryparse ensure the program don't crash even if the user didn't input a number and hit the button
                bool result = Int32.TryParse(etxtBill.Text, out int bill);
                Console.WriteLine(result);

                double tip = bill*.15;
                double total = tip + bill;
                Console.WriteLine("tip: "+ tip +"total: " +total);
                // update text for the tip and total textview .
                txtTip.Text = tip.ToString();
                txtTotal.Text = total.ToString();

            };
            

        }
    }
}

