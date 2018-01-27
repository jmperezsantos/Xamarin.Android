
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

namespace CollectionsExample
{
    [Activity(Label = "GridViewActivity", MainLauncher = true)]
    public class GridViewActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            this.SetContentView(Resource.Layout.GridViewLayout);

            GridView grid = this.FindViewById(Resource.Id.gvCuadricula)
                                as GridView;

            var lista = this.generateDummy(50);
            grid.Adapter = new ListViewAdapter(lista);

            grid.ItemClick += (sender, e) => {

                var gGrid = sender as GridView;

                CancionModel song = 
                    (CancionModel)gGrid.Adapter.GetItem(e.Position);

                Toast.MakeText(this, 
                               "Presionó: " + song,
                               ToastLength.Short).Show();

            };

        }

        private IList<CancionModel> generateDummy(int count)
        {

            IList<CancionModel> lista = new List<CancionModel>();

            for (int i = 0; i < count; i = i + 1)
            {

                CancionModel song = new CancionModel();

                song.Title = "Title " + i;
                song.Subtitle = "Subtitle " + i;

                lista.Add(song);

            }

            return lista;

        }
    }
}
