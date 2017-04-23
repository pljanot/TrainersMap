using System;
using Android.App;
using Android.Widget;
using Android.OS;
using RestSharp;

namespace TrainersMap.Client
{
    [Activity(Label = "TrainersMap.Client", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        private string _apiHost = "http://www.preprod.trainersmap.com.hostingasp.pl/";

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
            var client = new RestClient(_apiHost);
            var request = new RestRequest("api/values/version", Method.GET);
            IRestResponse response = client.Execute(request);
            button.Text = $"Trainers.Map Api Version = {response.Content}";
        }
    }
}

