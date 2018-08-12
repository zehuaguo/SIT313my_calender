
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Util;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
 using Android;

namespace my_calender
{
    [Activity(Label = "FourthActivity")]
    public class FourthActivity : Activity
    {
        //"You have selected :" + e.Parent.GetItemAtPosition(e.Position).ToString, ToastLength.Short).Show();
        int count = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.FourthLayout);


            var spinner = FindViewById<Spinner>(Resource.Id.spinner1);
            spinner.ItemSelected += (s, e) => {
                string firstTtem = spinner.SelectedItem.ToString();
                if(firstTtem.Equals(spinner.SelectedItem.ToString())){
                    
                }
                else{
                    Toast.MakeText(this, "You have seleted: " + e.Parent.GetItemAtPosition(e.Position).ToString(), ToastLength.Short).Show();
                }
            

            };










            // Create your application here
            Button counterBtn = FindViewById<Button>(Resource.Id.my_button);             counterBtn.Click += new EventHandler(this.Button1Clicked);              if (savedInstanceState != null)             {                 //GetInt                 count = savedInstanceState.GetInt("counter");                 counterBtn.Text = string.Format("{0} clicks!", count);             }            }           public void Button1Clicked(object sender, EventArgs e)         {              Log.Info("W2", "myButton - Clicked");             count++;             ((Button)sender).Text = string.Format("{0} clicks!", count);         }          //PutInt         protected override void OnSaveInstanceState(Bundle outState)         {             base.OnSaveInstanceState(outState);             Log.Info("W2", "OnSaveInstanceState");             outState.PutInt("counter", count);         }          protected override void OnPause()         {             Log.Info("W2", "OnPause");             base.OnPause();         }          protected override void OnStop()         {             Log.Info("W2", "OnStop");             base.OnStop();         }          protected override void OnDestroy()         {             Log.Info("W2", "OnDestroy");             base.OnDestroy();         }         protected override void OnStart()         {              Log.Info("W2", "OnStart");             base.OnStart();         }          protected override void OnResume()         {              Log.Info("W2", "OnResume");             base.OnResume();         } 
    }
}
