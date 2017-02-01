using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace TestApp
{
	[Activity(Label = "TestApp", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			MobileCenter.Start("368bb191-b474-441c-b4eb-346e617804e5",
					typeof(Analytics), typeof(Crashes));

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.MyButton);

			button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
		}
	}
}

