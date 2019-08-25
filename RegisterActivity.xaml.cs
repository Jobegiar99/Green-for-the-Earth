using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Green_for_the_Earth.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Green_for_the_Earth
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegisterActivity : Page
    {

        struct Pregunta
        {
            public string pregunta { get; set; }
            public List<string> respuestas;
            public List<double> respuestasValor;
        }
        List<Pregunta> Preguntas = new List<Pregunta>();
        public RegisterActivity()
        {
            Usuario user = new Usuario();

            Pregunta pregunta1 = new Pregunta();
            pregunta1.respuestas = new  List<string>();
            pregunta1.pregunta = "Did you take a plane last week? How long was the flight?";
            pregunta1.respuestas.Add("I did not take a plane");
            pregunta1.respuestas.Add("One hour or less");
            pregunta1.respuestas.Add("2-5 hours");
            pregunta1.respuestas.Add("6-8 hours");
            pregunta1.respuestas.Add("9 hours or more");
            //user.addKmVuelos(x);

            Pregunta pregunta2 = new Pregunta();
            pregunta2.respuestas = new List<string>();
            pregunta2.pregunta = "Household monthly electricity usage:";
            pregunta2.respuestas.Add("Less than 700 kWh");
            pregunta2.respuestas.Add("From 700 to 1000 kWh");
            pregunta2.respuestas.Add("From 1000 to 1300 kWh");
            pregunta2.respuestas.Add("From 1300 to 1600 kWh");
            pregunta2.respuestas.Add("Over 1600 kWh");
            //user.addElectricidad(x);

            
            Pregunta pregunta3 = new Pregunta();
            pregunta3.respuestas = new List<string>();
            pregunta3.pregunta = "How many hours did you spend driving last week?";
            pregunta3.respuestas.Add("2 hours or less");
            pregunta3.respuestas.Add("3 to 5 hours");
            pregunta3.respuestas.Add("6 to 8 hours");
            pregunta3.respuestas.Add("9 or more hours");
            //user.addKmCarro(x);

            Pregunta pregunta4 = new Pregunta();
            pregunta4.respuestas = new List<string>();
            pregunta4.pregunta = "How many hours did you spend in public transportation last week?";
            pregunta4.respuestas.Add("Half an hour or less");
            pregunta4.respuestas.Add("One hour");
            pregunta4.respuestas.Add("One hour and a half");
            pregunta4.respuestas.Add("Two hours or more");
            //user.addKmCamion(x);

            Pregunta pregunta5 = new Pregunta();
            pregunta5.respuestas = new List<string>();
            pregunta5.pregunta = "In a week, how many times do you eat beef?";
            pregunta5.respuestas.Add("Zero");
            pregunta5.respuestas.Add("Less than 3");
            pregunta5.respuestas.Add("4 to 8");
            pregunta5.respuestas.Add("9 to 12");
            pregunta5.respuestas.Add("13 to 16");
            pregunta5.respuestas.Add("More than 16");
            //user.setCarne(x);

            Pregunta pregunta6 = new Pregunta();
            pregunta6.respuestas = new List<string>();
            pregunta6.pregunta = "How many times did you eat chicken last week?";
            pregunta6.respuestas.Add("Zero");
            pregunta6.respuestas.Add("Less than 3");
            pregunta6.respuestas.Add("4 to 6");
            pregunta6.respuestas.Add("More than 6");
            //user.setPollo(x);

            Pregunta pregunta7 = new Pregunta();
            pregunta7.respuestas = new List<string>();
            pregunta7.pregunta = "How many times did you eat pork last week?";
            pregunta7.respuestas.Add("Zero");
            pregunta7.respuestas.Add("One");
            pregunta7.respuestas.Add("2 to 4");
            pregunta7.respuestas.Add("5 or more");
            //user.setPuerco(x);

            Pregunta pregunta8 = new Pregunta();
            pregunta8.respuestas = new List<string>();
            pregunta8.pregunta = "How many times did you eat fish last week?";
            pregunta8.respuestas.Add("Zero");
            pregunta8.respuestas.Add("One");
            pregunta8.respuestas.Add("2 to 4");
            pregunta8.respuestas.Add("5 or more");
            //user.setPescado(x);
            //comboBox_answers.SelectedIndex; te da la respuesta de answers

            Pregunta pregunta9 = new Pregunta();
            pregunta9.respuestas = new List<string>();
            pregunta9.respuestasValor = new List<double>();
            pregunta9.pregunta = "How many times did you eat pork last week?";
            pregunta9.respuestas.Add("Zero");
            pregunta9.respuestas.Add("One");
            pregunta9.respuestas.Add("2 to 4");
            pregunta9.respuestas.Add("5 or more");
            //user.setPuerco(x);

            Pregunta pregunta10 = new Pregunta();
            pregunta10.pregunta = "How many times did you eat fish last week?";
            pregunta10.respuestas = new List<string>();
            pregunta10.respuestasValor = new List<double>();
            pregunta10.respuestas.Add("Zero");
            pregunta10.respuestas.Add("One");
            pregunta10.respuestas.Add("2 to 4");
            pregunta10.respuestas.Add("5 or more");
            //user.setPescado(x);
            //comboBox_answers.SelectedIndex; te da la respuesta de answers

            this.InitializeComponent();

            Box_Category.Items.Add(pregunta1.pregunta);
            Box_Category.Items.Add(pregunta2.pregunta);
            Box_Category.Items.Add(pregunta3.pregunta);
            Box_Category.Items.Add(pregunta4.pregunta);
            Box_Category.Items.Add(pregunta5.pregunta);
            Box_Category.Items.Add(pregunta6.pregunta);
            Box_Category.Items.Add(pregunta7.pregunta);
            Box_Category.Items.Add(pregunta8.pregunta);

            Preguntas.Add(pregunta1);
            Preguntas.Add(pregunta2);
            Preguntas.Add(pregunta3);
            Preguntas.Add(pregunta4);
            Preguntas.Add(pregunta5);
            Preguntas.Add(pregunta6);
            Preguntas.Add(pregunta7);
            Preguntas.Add(pregunta8);

        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UserMenu));
        }

        private void Box_Category_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (Box_Category.SelectedIndex)
            {
                case 0:
                    foreach(string s in Preguntas[0].respuestas)
                    {
                        Box_Answer.Items.Add(s);
                    }
                    break;
                case 1:
                    foreach (string s in Preguntas[1].respuestas)
                    {
                        Box_Answer.Items.Add(s);
                    }
                    break;
                case 2:
                    foreach (string s in Preguntas[2].respuestas)
                    {
                        Box_Answer.Items.Add(s);
                    }
                    break;
                case 3:
                    foreach (string s in Preguntas[3].respuestas)
                    {
                        Box_Answer.Items.Add(s);
                    }
                    break;
                case 4:
                    foreach (string s in Preguntas[4].respuestas)
                    {
                        Box_Answer.Items.Add(s);
                    }
                    break;
                case 5:
                    foreach (string s in Preguntas[5].respuestas)
                    {
                        Box_Answer.Items.Add(s);
                    }
                    break;
                case 6:
                    foreach (string s in Preguntas[6].respuestas)
                    {
                        Box_Answer.Items.Add(s);
                    }
                    break;
                case 7:
                    foreach (string s in Preguntas[7].respuestas)
                    {
                        Box_Answer.Items.Add(s);
                    }
                    break;
                case 8:
                    foreach (string s in Preguntas[8].respuestas)
                    {
                        Box_Answer.Items.Add(s);
                    }
                    break;
                case 9:
                    foreach (string s in Preguntas[9].respuestas)
                    {
                        Box_Answer.Items.Add(s);
                    }
                    break;
            }
       
        }

        private void Box_Activity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //switch
        }

        private void Button_register_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
