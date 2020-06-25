using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_ScrollView_Aula
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Galeria();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
