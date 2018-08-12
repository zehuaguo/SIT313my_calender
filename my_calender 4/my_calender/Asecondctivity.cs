
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
//using System;

namespace my_calender
{
    [Activity(Label = "Asecondctivity")]
    public class Asecondctivity : Activity
    {
        Button btnCalculate;
        EditText etTotal;
        TextView tvTipAmount;
        TextView tvTotal;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.secondlayout);

            btnCalculate = FindViewById<Button>(Resource.Id.btnSubmit);

            etTotal = FindViewById<EditText>(Resource.Id.inputBill);

            tvTipAmount = FindViewById<TextView>(Resource.Id.tipAmount);

            tvTotal = FindViewById<TextView>(Resource.Id.totalAmount);

            btnCalculate.Click += CalculateTip;


            void CalculateTip(object sender, EventArgs e)
            {
                double total = double.Parse(etTotal.Text);

                double tip = total * 0.15;

                tvTotal.Text = (total + tip).ToString();

                tvTipAmount.Text = tip.ToString();

            } 
        }
 
    }
}
