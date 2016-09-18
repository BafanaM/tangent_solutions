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
        private Button mSignInButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mSignInButton = FindViewById<Button>(Resource.Id.sign_in_btn);

            mSignUpButton = FindViewById<Button>(Resource.Id.register_account_btn);

            mSignUpButton.Click += (object sender, EventArgs args) => {

                //Call Dialog Sign Up
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                DialogSignUp signUpDialog = new DialogSignUp();
                signUpDialog.Show(transaction, "Dialog Sign Up");

            };

            mSignInButton.Click += (object sender, EventArgs args) => {

                //Call Dialog Sign Up
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                DialogSignIn signInDialog = new DialogSignIn();
                signInDialog.Show(transaction, "Dialog Sign In");

            };

        }
    }
}

