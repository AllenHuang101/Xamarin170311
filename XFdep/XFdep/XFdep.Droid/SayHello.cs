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
using XFdep.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(SayHello))]
namespace XFdep.Droid
{
    public class SayHello : ISayHello
    {
        public string Hello()
        {
            return "Androi";
        }
    }
}