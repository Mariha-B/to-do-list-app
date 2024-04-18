using System;
using System.Diagnostics;

using Xamarin.Forms;

namespace ToDoListApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            try
            {
                ToDoList.ItemsSource = await App.Database.GetItemsAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error fetching items: {ex.Message}");
            }
        }
    }
}
