using Android.App;
using Android.Widget;
using Android.OS;
using FragmentNavigationExample.Fragments;

namespace FragmentNavigationExample
{
    [Activity(Label = "FragmentNavigationExample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            if(savedInstanceState == null){

                //Se genera la instancia del fragment "inicial"
                Fragment first = FirstFragment.NewInstance();

                //Se obtiene una referencia del "FragmentManager"
                FragmentManager manager = this.FragmentManager;

                //Se inicia una transacción con ayuda del "FragmentManager"
                FragmentTransaction transaction = manager.BeginTransaction();

                //Se agrega el Fragment a la interfaz
                transaction.Add(Resource.Id.contenedor, first);

                //Se confirma la transacción ;P
                transaction.Commit();

            }


        }
    }
}

