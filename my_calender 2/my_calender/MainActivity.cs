using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Support.V7.App;
using Java.Util;
using Android.Graphics;
using static Android.App.DatePickerDialog;

namespace my_calender
{
    [Activity(Label = "my_calender", MainLauncher = true, Icon = "@drawable/icon", Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity,IOnDateSetListener
    {
        //int count = 1;
        EditText mDateEditText;
        Calendar mCurrentDate;
        //Bitmap mGeneratedDateIcon;

        public void OnDateSet(DatePicker view, int year, int month, int dayOfMonth)
        {
            mDateEditText.Text = $"{dayOfMonth} - {month + 1} - {year}";
            mCurrentDate.Set(year, month, dayOfMonth);
            //mGeneratedDateIcon = m
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.button0);
            button.Click += (sender, e) => 
            {
                Intent firstintent = new Intent(this, typeof(Asecondctivity));
                this.StartActivity(firstintent);
            };
            Button button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += (sender, e) =>
            {
                Intent secondintent = new Intent(this, typeof(ThirdActivity));
                this.StartActivity(secondintent);
            };

            // button.Click += delegate { button.Text = $"{count++} clicks!"; };
            mDateEditText = FindViewById<EditText>(Resource.Id.txtDateEntered);
            mDateEditText.Click += delegate
             {
                 mCurrentDate = Calendar.Instance;
                 int mYear = mCurrentDate.Get(CalendarField.Year);
                 int mMonth = mCurrentDate.Get(CalendarField.Month);
                 int mDay = mCurrentDate.Get(CalendarField.DayOfMonth);
                 DatePickerDialog mDate = new DatePickerDialog(this, this, mYear, mMonth, mDay);
                 mDate.Show();
             };




        }
    }
}

