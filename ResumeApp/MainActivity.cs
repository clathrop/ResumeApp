using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ResumeApp
{
	[Activity (MainLauncher=true, Label="@string/app_name", Theme="@android:style/Theme.NoTitleBar")]
	public class ResumeApp : TabActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);

			TabHost.TabSpec spec;     // Resusable TabSpec for each tab
			Intent intent;            // Reusable Intent for each tab

			// Create an Intent to launch an Activity for the tab (to be reused)
			intent = new Intent (this, typeof (AboutMeActivity));
			intent.AddFlags (ActivityFlags.NewTask);

			// Initialize a TabSpec for each tab and add it to the TabHost
			spec = TabHost.NewTabSpec ("aboutme");
			spec.SetIndicator ("AboutMe", Resources.GetDrawable (Resource.Drawable.ic_tab_AboutMe));
			spec.SetContent (intent);
			TabHost.AddTab (spec);

			// Do the same for the other tabs
			intent = new Intent (this, typeof (EducationActivity));
			intent.AddFlags (ActivityFlags.NewTask);

			spec = TabHost.NewTabSpec ("education");
			spec.SetIndicator ("Education", Resources.GetDrawable (Resource.Drawable.ic_tab_Education));
			spec.SetContent (intent);
			TabHost.AddTab (spec);

			intent = new Intent (this, typeof (WorkExperienceActivity));
			intent.AddFlags (ActivityFlags.NewTask);

			spec = TabHost.NewTabSpec ("workexperience");
			spec.SetIndicator ("Work Experience", Resources.GetDrawable (Resource.Drawable.ic_tab_Work));
			spec.SetContent (intent);
			TabHost.AddTab (spec);

			intent = new Intent (this, typeof (LeadershipActivity));
			intent.AddFlags (ActivityFlags.NewTask);

			spec = TabHost.NewTabSpec ("leadership");
			spec.SetIndicator ("Leadership", Resources.GetDrawable (Resource.Drawable.ic_tab_Leadership));
			spec.SetContent (intent);
			TabHost.AddTab (spec);

			TabHost.CurrentTab = 0;
		}



	
	[Activity]
	public class AboutMeActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

//			TextView textview = new TextView (this);
//			textview.Text = "This is About Me tab";
//			SetContentView (textview);
			//View view = inflater.Inflate (Resource.Layout.about, container, false);
			
			//TextView textView1 = FindViewById<TextView> (Resource.Id.sampleTextView);
			SetContentView (Resource.Layout.about);
		}
	}
	[Activity]
	public class EducationActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			int toggle0 = 0;
			int toggle1 = 0;
			int toggle2 = 0;
			int toggle3 = 0;

			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.education);

				TextView bmTextView = FindViewById<TextView> (Resource.Id.bmTextView);
				Button button1 = FindViewById<Button> (Resource.Id.button1);   
				button1.Click += (sender, e) => {
					if(toggle0 == 0){
						bmTextView.Text = "▼ Designed a product that incorporates an Xbox Kinect in order to function as a motion and gesture sensor to control aspects of a smart home. Gestures from a user interpreted by our software allow one to control various appliances and utilities from the lights of a room to the channels on the TV.";
						toggle0 = 1;
					}else if(toggle0 == 1){
						bmTextView.Text = "►";
						toggle0 = 0;
					}
				};

				TextView mmTextView = FindViewById<TextView> (Resource.Id.mmTextView);
				Button button2 = FindViewById<Button> (Resource.Id.button2);   
				button2.Click += (sender, e) => {
					if(toggle1 == 0){
						mmTextView.Text = "▼ Part of a team that created a music suggestion web app built upon data from the semantic web.  Users input artists, songs and genres that they like and MusicMachine queries data from the remote RDF store, MusicBrainz, to return relevant suggestions on other songs and/or artists they might like. App utilizes JSP, JavaScript, JQuery, HTML, CSS, SPARQL, and the Sesame API.";
						toggle1 = 1;
					}else if(toggle1 == 1){
						mmTextView.Text = "►";
						toggle1 = 0;
					}
				};

				TextView laTextView = FindViewById<TextView> (Resource.Id.laTextView);
				Button button3 = FindViewById<Button> (Resource.Id.button3);   
				button3.Click += (sender, e) => {
					if(toggle2 == 0){
						laTextView.Text = "▼ Constructed an entire airline ticketing system using relational database design techniques. Developed multiple user interfaces which allow customers to book flights, query the cheapest and shortest distance flights via layovers as well as allow administrators to cancel flights and edit reservations for customers and seat reservations for passengers.";
						toggle2 = 1;
					}else if(toggle2 == 1){
						laTextView.Text = "►";
						toggle2 = 0;
					}
				};

				TextView sgTextView = FindViewById<TextView> (Resource.Id.sgTextView);
				Button button4 = FindViewById<Button> (Resource.Id.button4);   
				button4.Click += (sender, e) => {
					if(toggle3 == 0){
						sgTextView.Text = "▼ Learned how to design web applications from the ground up, incorporating everything necessary to make a multi-user card game, Set, with PHP, JavaScript, HTML and CSS.";
						toggle3 = 1;
					}else if(toggle3 == 1){
						sgTextView.Text = "►";
						toggle3 = 0;
					}
				};

			}
		}

	[Activity]
	public class WorkExperienceActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			TextView textview = new TextView (this);
			textview.Text = "This is the Work Experience tab";
			SetContentView (textview);
		}
	}
	[Activity]
	public class LeadershipActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			TextView textview = new TextView (this);
			textview.Text = "This is the Leadership tab";
			SetContentView (textview);
		}
	}
}
}


