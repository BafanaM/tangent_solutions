using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace BafanaAssessment
{
    [Activity(Label = "Assessment", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        private Button mSignUpButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mSignUpButton = FindViewById<Button>(Resource.Id.register_account_btn);

            mSignUpButton.Click += (object sender, EventArgs args) => {

                //Call Dialog Sign Up
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                DialogSignUp signUpDialog = new DialogSignUp();
                signUpDialog.Show(transaction, "Dialog Sign Up");

            };

        }
    }
}

