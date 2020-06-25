using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_ScrollView_Aula
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercicio_ScrollView1 : ContentPage
    {
        public Exercicio_ScrollView1()
        {
            InitializeComponent();

            //var stack = new StackLayout();
            //stack.Spacing = 20;

            //StackLayout stack = new StackLayout();
            //stack.Spacing = 20;

            //StackLayout stack = new StackLayout
            //{
            //    Spacing = 10
            //};

            var stack = new StackLayout
            {
                Spacing = 10
            };

            for (int i = 0; i < 26; i++)
            {
                stack.Children.Add(new Button { Text="Button" + i, BackgroundColor = Color.Yellow});
            }

            //ScrollView scroll = new ScrollView
            //{
            //    Content = stack
            //};

            ScrollView scroll = new ScrollView();

            scroll.Content = stack;

            Content = scroll;
        }
    }
}









