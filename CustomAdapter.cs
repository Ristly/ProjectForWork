using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectForWork;

public class CustomAdapter : BaseAdapter
{

    Context context;
    List<string> items;

    public CustomAdapter(Context context, List<string> items)
    {
        this.context = context;
        this.items = items;
    }


    public override Java.Lang.Object GetItem(int position)
    {
        return items[position];
    }

    public override long GetItemId(int position)
    {
        return position;
    }

    public override View GetView(int position, View convertView, ViewGroup parent)
    {
        var view = convertView;
        CustomAdapterViewHolder holder = null;

        if (view != null)
            holder = view.Tag as CustomAdapterViewHolder;

        if (holder == null)
        {
            holder = new CustomAdapterViewHolder();
            var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
            //replace with your item and your holder items
            //comment back in
            view = inflater.Inflate(Resource.Layout.text_view, parent, false);
            holder.Content = view.FindViewById<TextView>(Resource.Id.itemTextView);
            view.Tag = holder;
        }


        //fill in your items
        holder.Content.Text = items[position];

        return view;
    }

    //Fill in cound here, currently 0
    public override int Count
    {
        get
        {
            return items.Count;
        }
    }

}

internal class CustomAdapterViewHolder : Java.Lang.Object
{
    //Your adapter views to re-use
    public TextView Content { get; set; }
}