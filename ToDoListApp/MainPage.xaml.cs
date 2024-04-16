using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToDoListApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void HandleTextChanged(object sender, TextChangedEventArgs e)
        {
            Console.WriteLine(e.NewTextValue);
        }

        public void HandleEnterPressed(object sender, EventArgs e)
        {
            Console.WriteLine("Enter Pressed");
            
        }
    }
}
