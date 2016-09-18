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
using SupportActionDrawer = Android.Support.V7.App.ActionBarDrawerToggle;
using Android.Support.V7.App;
using Android.Support.V4.Widget;

namespace BafanaAssessment
{
    class ActionBarDrawerToggle : SupportActionDrawer
    {

        private ActionBarActivity mHostActivity;
        private int mOpened;
        private int mClosed;
        public ActionBarDrawerToggle(ActionBarActivity host, DrawerLayout drawerLayout, int opened,int closed ) :
            base(host,drawerLayout,opened,closed)
        {

            mHostActivity = host;
            mOpened = opened;
            mClosed = closed;

        }

        public ActionBarDrawerToggle(Activity activity, DrawerLayout drawerLayout, int openDrawerContentDescRes, int closeDrawerContentDescRes) : base(activity, drawerLayout, openDrawerContentDescRes, closeDrawerContentDescRes)
        {
        }

        public override void OnDrawerOpened(View drawerView)
        {
            base.OnDrawerOpened(drawerView);
        }
        public override void OnDrawerClosed(View drawerView)
        {
            base.OnDrawerClosed(drawerView);
        }

        public override void OnDrawerSlide(View drawerView, float slideOffset)
        {
            base.OnDrawerSlide(drawerView, slideOffset);
        }
    }
}