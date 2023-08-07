using Android.Content.PM;

namespace ProjectForWork;

[Activity(Label = "OfferActivity", ScreenOrientation = ScreenOrientation.Portrait)]
public class OfferActivity : Activity
{
    protected override async void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Create your application here
        SetContentView(Resource.Layout.offer_data);
        TextView textView = FindViewById<TextView>(Resource.Id.offerData);
        textView.Text = Intent.GetStringExtra("offer");
    }
}