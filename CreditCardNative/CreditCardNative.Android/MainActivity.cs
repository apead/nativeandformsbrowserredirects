using System;

using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace CreditCardNative.Droid
{
	[Activity(Label = "Credit Card Native", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{

            base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

//		    var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
		    //Toolbar will now take on default Action Bar characteristics
//		    SetActionBar(toolbar);
		    //You can now use and reference the ActionBar
//		    ActionBar.Title = "Credit Card Native";

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {

			    Intent intent = new Intent(this, typeof(CreditCardPayment));
			    StartActivity(intent);

    };


		}
	}
}


