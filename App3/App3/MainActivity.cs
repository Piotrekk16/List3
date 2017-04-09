using Android.App;
using Android.OS;
using Android.Widget;

namespace App3
{
    [Activity(Label = "App3", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            ListAdapter = new ArrayAdapter<Item>(this, Android.Resource.Layout.SimpleListItem1, Item.items);
        }
    }
}

