using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}

 private void ToolbarItem_Clicked(object sender, EventArgs e)
{

    ToolbarItem current = (ToolbarItem)sender;
    if( current.Text == "Add")
    {
        Navigation,PushAsync(new NewItemPage)
    }
}
