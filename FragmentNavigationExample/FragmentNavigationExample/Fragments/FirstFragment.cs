
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace FragmentNavigationExample.Fragments
{
    public class FirstFragment : Fragment
    {

        public static FirstFragment NewInstance(){

            FirstFragment fragment = new FirstFragment();

            fragment.Arguments = new Bundle();

            return fragment;

        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, 
                                          ViewGroup container,
                                          Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment

            return inflater.Inflate(Resource.Layout.FirstLayout,
                                    container,
                                    false);
                
        }

        public override void OnViewCreated(View view, 
                                           Bundle savedInstanceState)
        {

            EditText etInput = view.FindViewById<EditText>(Resource.Id.etName);

            Button btnAvanza = (Button)view.FindViewById(Resource.Id.btnAvanza);

            btnAvanza.Click += delegate {

                var fragment = SecondFragment.NewInstance(etInput.Text);

                //var manager = this.FragmentManager;

                var transaction = this.FragmentManager.BeginTransaction();

                transaction.Replace(Resource.Id.contenedor,
                                   fragment);

                transaction.AddToBackStack(null);

                transaction.Commit();

            };

        }

    }
}
