using System;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace UITestDemo
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            Item = new Item
            {
                Text = "Item name",
                Description = "This is an item description."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            //MessagingCenter.Send(this, "AddItem", Item);
            //await Navigation.PopToRootAsync();
            Crashes.GenerateTestCrash();
            object o2 = null;
            
            try
            {
                int i2 = (int)o2;
            }

            catch (Exception exception)
            {
                Crashes.TrackError(exception);
            }
        }
    }
}
