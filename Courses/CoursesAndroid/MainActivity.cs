using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System;

namespace CoursesAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        Button btnPrev;
        Button btnNext;
        TextView txtTitle, txtDescription;
        ImageView imgCourse;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            btnNext = FindViewById<Button>(Resource.Id.btnNext);
            btnPrev = FindViewById<Button>(Resource.Id.btnPrev);

            txtTitle = FindViewById<TextView>(Resource.Id.txtTitle);
            txtDescription = FindViewById<TextView>(Resource.Id.txtDescription);

            imgCourse = FindViewById<ImageView>(Resource.Id.imgCourse);

            btnNext.Click += btnNext_Click;
            btnPrev.Click += btnPrev_Click;

        }

        private void btnPrev_Click(object sender, EventArgs e) {

            txtTitle.Text = "Previous Clicked";
            txtDescription.Text = "The description that appears on Previous clicked";
            imgCourse.SetImageResource(Resource.Drawable.p1);

        }

        private void btnNext_Click(object sender, EventArgs e) {

            txtTitle.Text = "Next Clicked";
            txtDescription.Text = "The description that appears on Next clicked";
            imgCourse.SetImageResource(Resource.Drawable.p2);


        }
    }
}

