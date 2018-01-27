using System;
using System.Collections.Generic;
using Android.Views;
using Android.Widget;

namespace CollectionsExample
{
    public class ListViewAdapter : BaseAdapter
    {

        private IList<CancionModel> canciones;

        public ListViewAdapter(IList<CancionModel> canciones)
        {
            
            this.canciones = canciones;

        }

        public override int Count
        {
            get
            {
                return this.canciones.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return this.GetItem(position).GetHashCode();
        }

        public override Java.Lang.Object GetItem(int position)
        {

            return this.canciones[position];

        }

        public override Android.Views.View GetView(int position,
                                                   Android.Views.View reusableView,
                                                   Android.Views.ViewGroup parent)
        {

            if (reusableView == null)
            {

                var inflater = LayoutInflater.From(parent.Context);

                reusableView = inflater.Inflate(Resource.Layout.ItemLayout,
                                               parent,
                                                false);

            }

            CancionModel song = (CancionModel)this.GetItem(position);

            TextView tvTitle = (TextView)reusableView.FindViewById(Resource.Id.tvTitle);
            TextView tvSubTitle = reusableView.FindViewById(Resource.Id.tvSubtitle)
                                              as TextView;

            tvTitle.Text = song.Title;

            tvSubTitle.Text = song.Subtitle;

            return reusableView;

        }

    }
}
