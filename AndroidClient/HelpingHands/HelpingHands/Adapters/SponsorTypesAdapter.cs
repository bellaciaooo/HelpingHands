using Android.App;
using Android.Views;
using Android.Widget;
using HelpingHands.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelpingHands.Adapters
{
    internal class SponsorTypesAdapter : BaseAdapter<SponsorType>
    {
        List<SponsorType> Items;
        Activity Context;

        public SponsorTypesAdapter(Activity context, List<SponsorType> items) : base()
        {
            this.Context = context;
            this.Items = items;
        }

        public override SponsorType this[int position] => Items[position];

        public override int Count => Items.Count;

        public override long GetItemId(int position) => position;

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = Items[position];
            View view = convertView;
            if (view == null) // no view to re-use, create new
                view = Context.LayoutInflater.Inflate(Resource.Layout.interest_row, null);
            view.FindViewById<TextView>(Resource.Id.NumeBox).Text = item.Name;
            return view;
        }
    }
}