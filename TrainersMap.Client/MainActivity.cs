using System;
using System.Threading.Tasks;
using Android.App;
using Android.Widget;
using Android.OS;
using RestSharp;
using TrainersMap.RestClient;

namespace TrainersMap.Client
{
    [Activity(Label = "TrainersMap.Client", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            button.Click += delegate { OperateOnButton(button); };
        }

        private void OperateOnButton(Button button)
        {
            TrainersMapRestClient trainersMapRestClient = new TrainersMapRestClient();
            button.Text = trainersMapRestClient.GetVersion().Result;
        }
    }
}

