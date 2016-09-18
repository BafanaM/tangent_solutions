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
using SupportToolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.V7.App;
using Android.Support.V4.Widget;

namespace BafanaAssessment
{
    [Activity(Label = "Home Activity",Theme = "@style/navigation_drawer_theme")]
    public class HomeActivity : AppCompatActivity
    {

        private SupportToolbar mToolbar;
        private ActionBarDrawerToggle mDrawerToggle;
        private DrawerLayout mDrawerLayout;
        private ListView mListView;

  
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Home_Activity);

            mToolbar = FindViewById<SupportToolbar>(Resource.Id.toolbar);
            mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer);
            mListView = FindViewById<ListView>(Resource.Id.drawer_list);
            SetSupportActionBar(mToolbar);

            mDrawerToggle = new ActionBarDrawerToggle(

              this,
              mDrawerLayout,
              Resource.String.openDrawer,
              Resource.String.closeDrawer);

            mDrawerLayout.AddDrawerListener(mDrawerToggle);
            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetDisplayShowTitleEnabled(true);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
     
           // SupportActionBar.setHomeAsUpIndicator(R.drawable.ic_drawer);


            mDrawerToggle.SyncState(); 
        }


        public override bool OnOptionsItemSelected(IMenuItem item)
        {

            mDrawerToggle.OnOptionsItemSelected(item);
            return base.OnOptionsItemSelected(item);
        }
    }
}