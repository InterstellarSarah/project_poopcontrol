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

namespace prototipococo01
{
    [Activity(Label = "Inicio")]
    public class Inicio : Activity
    {
        Button entrar, cad, nocad;
        ImageView imagem01;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetContentView(Resource.Layout.Inicio);

            entrar = FindViewById<Button>(Resource.Id.bt);

        }
    }
}