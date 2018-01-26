using Android.App;
using Android.Widget;
using Android.OS;

namespace MyFirstApp
{
    [Activity(Label = "MyFirstApp", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Referencias de los outlets

            TextView tvOutput = (TextView)this.FindViewById(Resource.Id.tvOutput);
            EditText etInput = this.FindViewById(Resource.Id.etInput) as EditText;
            Button btnPress = this.FindViewById<Button>(Resource.Id.btnCambia);

            //Uso
            tvOutput.Text = "Hola Mundo desde Xamarin.Android!";

            btnPress.Click += (sender, e) => {
                System.Diagnostics.Debug.
                      WriteLine("Hola Mundo desde Xamarin.Android!");
            };

        }
    }
}

