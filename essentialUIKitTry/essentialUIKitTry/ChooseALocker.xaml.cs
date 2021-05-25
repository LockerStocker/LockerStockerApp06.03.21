using essentialUIKitTry.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CounterFunctions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;






namespace essentialUIKitTry
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChooseALocker : ContentPage
    {

        private List<Locker> myList; //your list here

        public ChooseALocker()
        {
            InitializeComponent();
            MyButtons.Children.Clear(); //just in case so you can call this code several times np..
            SetLockerList();

            foreach (var item in myList)
            {
                Button btn = new Button()
                {
                    Text = "Locker " + item.Id, //Whatever prop you wonna put as title;
                    StyleId = "" + item.Id //use a property from event as id to be passed to handler
                };
                if ( item.available)
                {
                    btn.BackgroundColor = Color.Green; 
                } else
                {
                    btn.BackgroundColor = Color.Red; 
                }
                btn.Clicked += Locker1_ClickedAsync;
                MyButtons.Children.Add(btn);
            }
        }


        async void SetLockerList()
        {
            Locker locker1 = await AzureApi.GetLocker(1);
            Locker locker2 = await AzureApi.GetLocker(2);
            Locker locker3 = await AzureApi.GetLocker(3);
            myList = new List<Locker>(); //your list here
            myList.Add(locker1);
            myList.Add(locker2);
            myList.Add(locker3);
        }

        async void Locker1_ClickedAsync(object sender, System.EventArgs e)
        {
            var available = await AzureApi.IsAvailableAsync(1);

            if (available)
            {
                AzureApi.SetOccupy(1, "userKey");
                await Navigation.PushAsync(new Locker1OrderedSuccess());
            }
            else
            {
                await Navigation.PushAsync(new Locker2OrderFailed("1"));  //FIXME: should be failed
            }
        }
        async void Locker2_Clicked(object sender, System.EventArgs e)
        {
            var available = await AzureApi.IsAvailableAsync(2);

            if (available)
            {
                AzureApi.SetOccupy(2, "userKey");
                await Navigation.PushAsync(new Locker1OrderedSuccess());
            }
            else
            {
                await Navigation.PushAsync(new Locker2OrderFailed("2"));  //FIXME: should be failed
            }
        }
        async void Locker3_Clicked(object sender, System.EventArgs e)
        {
            var available = await AzureApi.IsAvailableAsync(3);

            if (available)
            {
                AzureApi.SetOccupy(3, "userKey");
                await Navigation.PushAsync(new Locker1OrderedSuccess());
            }
            else
            {
                await Navigation.PushAsync(new Locker2OrderFailed("3"));  //FIXME: should be failed
            }
        }
    }
}