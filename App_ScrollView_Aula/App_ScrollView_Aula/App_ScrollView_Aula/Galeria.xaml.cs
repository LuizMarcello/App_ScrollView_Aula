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
    public partial class Galeria : ContentPage
    {
        public Galeria()
        {
            InitializeComponent();

            List<string> lista = GetImagens();

            StackLayout stack = new StackLayout();
            stack.Spacing = 10;

            for (int i = 0; i < lista.Count; i++)
            {
                stack.Children.Add(new Image
                {
                    Source = lista[i],
                    HeightRequest = 300,
                    WidthRequest = 300,
                    Aspect = Aspect.AspectFill
                });
            }

            ScrollView scroll = new ScrollView 
            {
                Content = stack
            };

            Content = scroll;
        }

        public List<string> GetImagens()
        {
            List<string> Lista = new List<string>();
            Lista.Add("http://www.macoratti.net/Imagens/cidades/cidade1.jpg");
            Lista.Add("http://www.macoratti.net/Imagens/cidades/cidade2.jpg");
            Lista.Add("http://www.macoratti.net/Imagens/cidades/cidade3.jpg");
            Lista.Add("http://www.macoratti.net/Imagens/cidades/cidade4.jpg");
            Lista.Add("http://www.macoratti.net/Imagens/cidades/paisagem1.jpg");
            Lista.Add("http://www.macoratti.net/Imagens/cidades/paisagem2.jpg");
            Lista.Add("http://www.macoratti.net/Imagens/cidades/paisagem3.jpg");

            return Lista;
        }
    }
}




