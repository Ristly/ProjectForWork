using Android.Content;
using Android.Content.PM;
using Android.Views;

namespace ProjectForWork;

[Activity(Label = "@string/app_name", MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait)]
public class MainActivity : Activity, ListView.IOnItemClickListener
{
    ShopDataManager request = new ShopDataManager();

    public void OnItemClick(AdapterView? parent, View? view, int position, long id)
    {
        
        TextView textView = (TextView)view;
        if (string.IsNullOrEmpty(textView.Text) || string.IsNullOrWhiteSpace(textView.Text))
            return;

        Intent intent = new Intent(this, typeof(OfferActivity));
        intent.PutExtra("offer", request.GetOfferByIdAsync(textView.Text));
        StartActivity(intent);
    }

    protected override async void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        
        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);
        
        await request.SetShopData();

        var data = request.GetOffersIds();

        var adapter = new CustomAdapter(this, data); 

        ListView list = FindViewById<ListView>(Resource.Id.listView1);

        list.OnItemClickListener = this;
        list.Adapter = adapter;
    }


    


}