using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace CollectionsExample
{
    [Activity(Label = "CollectionsExample", Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            ListView lvLista = this.FindViewById(Resource.Id.lvLista)
                                   as ListView;

            var lista = this.generateDummy(20);
            ListViewAdapter adapter = new ListViewAdapter(lista);

            lvLista.Adapter = adapter;

            lvLista.ItemClick += 
                (object sender, 
                 AdapterView.ItemClickEventArgs e) => {

                     ListView lv = sender as ListView;

                     ListViewAdapter adapt = (ListViewAdapter)lv.Adapter;

                     CancionModel song = (CancionModel)adapt.GetItem(e.Position);

                System.Diagnostics.
                      Debug.WriteLine("Presionó: " + song);

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

