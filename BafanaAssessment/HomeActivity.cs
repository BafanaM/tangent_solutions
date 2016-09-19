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
using System.Net;

namespace BafanaAssessment
{
    [Activity(Label = "Home Activity",Theme = "@style/navigation_drawer_theme")]
    public class HomeActivity : AppCompatActivity
    {

        private SupportToolbar mToolbar;
        private ActionBarDrawerToggle mDrawerToggle;
        private DrawerLayout mDrawerLayout;
        private ListView mListView;
        private ArrayAdapter mListAdapter;
        private List<string> mListDataSet;
        private WebClient mWebClient;
        private Uri mUrlProject;

  
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Home_Activity);

            mWebClient = new WebClient();
            mUrlProject = new Uri("http://projectservice.staging.tangentmicroservices.com:80/api/v1/projects/");
            mWebClient.DownloadDataAsync(mUrlProject);

            //Calls php file
           // mWebClient.DownloadDataCompleted += mWebClient_DownloadDataCompleted;

            mToolbar = FindViewById<SupportToolbar>(Resource.Id.toolbar);
            mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer);
            mListView = FindViewById<ListView>(Resource.Id.drawer_list);
            SetSupportActionBar(mToolbar);

            mListDataSet = new List<string>();
            mListDataSet.Add("Bafana");
            mListDataSet.Add("Mankahla");
            mListDataSet.Add("First");
            mListDataSet.Add("Xamarin");
            mListDataSet.Add("Project");

            mListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, mListDataSet);
            mListView.Adapter = mListAdapter;

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