
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

namespace ActivityNavigationExample.Activities
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            this.SetContentView(Resource.Layout.Second);

            Intent intent = this.Intent;

            string extra1 = intent.GetStringExtra("EXTRA1");
            int extra2 = intent.GetIntExtra("EXTRA2",-1);

            System.Diagnostics.Debug.WriteLine("EXTRA1: "+extra1);
            System.Diagnostics.Debug.WriteLine("EXTRA2: " + extra2);

            Button btnBack = this.FindViewById<Button>(Resource.Id.btnBack);

            btnBack.Click += (object sender, EventArgs e) => {

                this.Finish();

            };
        }
    }
}
