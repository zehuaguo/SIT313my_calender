
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

namespace my_calender
{
    [Activity(Label = "ThirdActivity")]
    public class ThirdActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ThirdLayout);
            // Create your application here
            RatingBar ratingBar = FindViewById<RatingBar>(Resource.Id.ratingBar1);
            ratingBar.RatingBarChange += (o, e) =>
            {
                Toast.MakeText(this, " Suanki Rating: " + ratingBar.Rating.ToString(), ToastLength.Short).Show();

            };







           /* var ratingBar = FindViewById<RatingBar>(Resource.Id.ratingBar1);
            ratingBar.NumStars = 5;
            var btnSubmit = FindViewById<Button>(Resource.Id.btnSubmit);
            var txtRate = FindViewById<TextView>(Resource.Id.txtRate);

            txtRate.Text = "Rate: ";

            btnSubmit.Click += (s, e) =>
            {
                //SetContentView(Resource.Layout.ThirdLayout);

                string ratingValue = ratingBar.Rating.ToString();
                txtRate.Text = "Rate: " + ratingValue;
            };*/
        }
    }
}
