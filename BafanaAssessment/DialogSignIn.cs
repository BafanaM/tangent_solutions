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

namespace BafanaAssessment
{
    class DialogSignIn : DialogFragment
    {

        //private EditText mFirstName;
        //private EditText mEmail;
        //private EditText mPassword;
        private Button mSignIn;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.DialogSignInLayout, container, false);

            mSignIn = view.FindViewById<Button>(Resource.Id.dialog_signin_btn);

            //mFirstName = view.FindViewById<EditText>(Resource.Id.first_name_ed);
            //mEmail = view.FindViewById<EditText>(Resource.Id.email_ed);
            //mPassword = view.FindViewById<EditText>(Resource.Id.password_ed);
            //mSignUp = view.FindViewById<Button>(Resource.Id.create_account_btn);

            //mSignUp.Click += mSignUp_Click;

            //mSignUp.Click += (object sender, EventArgs args) => {

            //var intent = new Intent(this.Activity, typeof(HomeActivity));
            //StartActivity(intent);

            // };

            mSignIn.Click += (object sender, EventArgs args) => {

                var intent = new Intent(this.Activity, typeof(HomeActivity));
                StartActivity(intent);

            };



            return view;
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            //Removes title bar
            Dialog.Window.RequestFeature(WindowFeatures.NoTitle);

            base.OnActivityCreated(savedInstanceState);

            //Calls the animation style
            Dialog.Window.Attributes.WindowAnimations = Resource.Style.dialog_animation;
        }
    }
}