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
   

    public sealed partial class ClimateChangeTest : Page
    {
        
        struct Pregunta
        {
            public string pregunta { get; set; }
            public List<string> respuestas;
            public List<double> respuestasValor;
       
        }
        List<Pregunta> preguntaControl = new List<Pregunta>();
        Usuario user = new Usuario();
        int numeroDePregunta = 0;
        public ClimateChangeTest()
        {
            
            Pregunta pregunta1 = new Pregunta();
            pregunta1.respuestas = new List<string>();
            pregunta1.respuestasValor = new List<double>();
            pregunta1.pregunta = "Number of housemates (including yourself):";
            pregunta1.respuestas.Add("1");
            pregunta1.respuestas.Add("2");
            pregunta1.respuestas.Add("3");
            pregunta1.respuestas.Add("4");
            pregunta1.respuestas.Add("5");
            for (int i = 1; i < 6; i++)
            {
                pregunta1.respuestasValor.Add(i);
            }
            //user.setFamiliares(milochomil);

            Pregunta pregunta2 = new Pregunta();
            pregunta2.pregunta = "Household monthly electricity usage:";
            pregunta2.respuestas = new List<string>();
            pregunta2.respuestasValor = new List<double>();
            pregunta2.respuestas.Add("Less than 700 kWh");
            pregunta2.respuestas.Add("From 700 to 1000 kWh");
            pregunta2.respuestas.Add("From 1000 to 1300 kWh");
            pregunta2.respuestas.Add("From 1300 to 1600 kWh");
            pregunta2.respuestas.Add("Over 1600 kWh");
            //user.addElectricidad(x);

            Pregunta pregunta3 = new Pregunta();
            pregunta3.respuestas = new List<string>();
            pregunta3.respuestasValor = new List<double>();
            pregunta3.pregunta = "Car model:";
            for (int i = 0; i < 11; i++)
            {
                pregunta3.respuestas.Add(user.carros[i]);
            }
            //user.addModelo(x);
            //en la pregunta 3, repuestas[x] es el parametro que va en user.setModelo();
            Pregunta pregunta4 = new Pregunta();
            pregunta4.respuestas = new List<string>();
            pregunta4.respuestasValor = new List<double>();
            pregunta4.pregunta = "How many hours did you spend driving last week?";
            pregunta4.respuestas.Add("2 hours or less");
            pregunta4.respuestas.Add("3 to 5 hours");
            pregunta4.respuestas.Add("6 to 8 hours");
            pregunta4.respuestas.Add("9 or more hours");
            //user.addKmCarro(x);

            Pregunta pregunta5 = new Pregunta();
            pregunta5.respuestas = new List<string>();
            pregunta5.respuestasValor = new List<double>();
            pregunta5.pregunta = "How many hours did you spend in public transportation last week?";
            pregunta5.respuestas.Add("Half an hour or less");
            pregunta5.respuestas.Add("One hour");
            pregunta5.respuestas.Add("One hour and a half");
            pregunta5.respuestas.Add("Two hours or more");
            //user.addKmCamion(x);

            Pregunta pregunta6 = new Pregunta();
            pregunta6.respuestas = new List<string>();
            pregunta6.respuestasValor = new List<double>();
            pregunta6.pregunta = "Did you took a plane last week? How long was the flight?";
            pregunta6.respuestas.Add("I did not take a plane");
            pregunta6.respuestas.Add("One hour or less");
            pregunta6.respuestas.Add("2-5 hours");
            pregunta6.respuestas.Add("6-8 hours");
            pregunta6.respuestas.Add("9 hours or more");
            //user.addKmVuelos(x);

            Pregunta pregunta7 = new Pregunta();
            pregunta7.respuestas = new List<string>();
            pregunta7.respuestasValor = new List<double>();
            pregunta7.pregunta = "In a week, how many times do you eat beef?";
            pregunta7.respuestas.Add("Zero");
            pregunta7.respuestas.Add("Less than 3");
            pregunta7.respuestas.Add("4 to 8");
            pregunta7.respuestas.Add("9 to 12");
            pregunta7.respuestas.Add("13 to 16");
            pregunta7.respuestas.Add("More than 16");
            //user.setCarne(x);

            Pregunta pregunta8 = new Pregunta();
            pregunta8.respuestas = new List<string>();
            pregunta8.respuestasValor = new List<double>();
            pregunta8.pregunta = "How many times did you eat chicken last week?";
            pregunta8.respuestas.Add("Zero");
            pregunta8.respuestas.Add("Less than 3");
            pregunta8.respuestas.Add("4 to 6");
            pregunta8.respuestas.Add("More than 6");
            //user.setPollo(x);

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
            pregunta10.respuestas = new List<string>();
            pregunta10.respuestasValor = new List<double>();
            pregunta10.pregunta = "How many times did you eat fish last week?";
            pregunta10.respuestas.Add("Zero");
            pregunta10.respuestas.Add("One");
            pregunta10.respuestas.Add("2 to 4");
            pregunta10.respuestas.Add("5 or more");
            //user.setPescado(x);
            //comboBox_answers.SelectedIndex; te da la respuesta de answers
            
            preguntaControl.Add(pregunta1);
            preguntaControl.Add(pregunta2);
            preguntaControl.Add(pregunta3);
            preguntaControl.Add(pregunta4);
            preguntaControl.Add(pregunta5);
            preguntaControl.Add(pregunta6);
            preguntaControl.Add(pregunta7);
            preguntaControl.Add(pregunta8);
            preguntaControl.Add(pregunta9);
            preguntaControl.Add(pregunta10);
            this.InitializeComponent();
            txt_DropDownQuestion.Text = preguntaControl[0].pregunta;
            foreach (string s in preguntaControl[0].respuestas) 
            {
                comboBox_answers.Items.Add(s);
            }
           
            
        }



        private void Button_finish_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UserMenu));
        }

        private void Button_ComboBox_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox_answers.SelectedIndex != -1)
            {
                switch (numeroDePregunta)
                {
                    case 0:
                        user.setFamiliares(comboBox_answers.SelectedIndex - 1);
                        break;
                    case 1:
                        int electricity = 0;
                        switch (comboBox_answers.SelectedIndex)
                        {
                            case 0:
                                electricity = 500;
                                break;
                            case 1:
                                electricity = 900;
                                break;
                            case 2:
                                electricity = 1200;
                                break;
                            case 3:
                                electricity = 1500;
                                break;
                            case 4:
                                electricity = 1800;
                                break;
                        }
                        user.addElectricidad(electricity);
                        break;
                    case 2:
                        user.setModelo(comboBox_answers.SelectedItem.ToString());
                        break;
                    case 3:
                        byte carValue = 0;
                        switch (comboBox_answers.SelectedIndex)
                        {
                            case 0:
                                carValue = 2;
                                break;
                            case 1:
                                carValue = 5;
                                break;
                            case 2:
                                carValue = 8;
                                break;
                            case 3:
                                carValue = 9;
                                break;
                        }
                        user.addKmCarro(carValue, 0);
                        break;
                    case 4:

                        switch (comboBox_answers.SelectedIndex)
                        {
                            case 0:
                                user.addKmCamion(0, 30);
                                break;
                            case 1:
                                user.addKmCamion(1, 0);
                                break;
                            case 2:
                                user.addKmCamion(1, 30);
                                break;
                            case 3:
                                user.addKmCamion(2, 0);
                                break;
                        }

                        break;
                    case 5:
                        switch (comboBox_answers.SelectedIndex)
                        {
                            case 0:
                                user.addKmVuelos(0, 0);
                                break;
                            case 1:
                                user.addKmVuelos(1, 0);
                                break;
                            case 2:
                                user.addKmVuelos(3, 0);
                                break;
                            case 3:
                                user.addKmVuelos(6, 0);
                                break;
                            case 4:
                                user.addKmVuelos(9, 0);
                                break;

                        }
                        break;
                    case 6:
                        switch (comboBox_answers.SelectedIndex)
                        {
                            case 0:
                                user.setCarne(0);
                                break;
                            case 1:
                                user.setCarne(2);
                                break;
                            case 2:
                                user.setCarne(6);
                                break;
                            case 3:
                                user.setCarne(11);
                                break;
                            case 4:
                                user.setCarne(14);
                                break;
                            case 5:
                                user.setCarne(17);
                                break;

                        }

                        break;
                    case 7:
                        switch (comboBox_answers.SelectedIndex)
                        {
                            case 0:
                                user.setPollo(0);
                                break;
                            case 1:
                                user.setPollo(2);
                                break;
                            case 2:
                                user.setPollo(5);
                                break;
                            case 3:
                                user.setPollo(7);
                                break;
                        }

                        break;
                    case 8:
                        switch (comboBox_answers.SelectedIndex)
                        {
                            case 0:
                                user.setPuerco(0);
                                break;
                            case 1:
                                user.setPuerco(1);
                                break;
                            case 2:
                                user.setPuerco(3);
                                break;
                            case 3:
                                user.setPuerco(5);
                                break;
                        }
                        break;
                    case 9:
                        switch (comboBox_answers.SelectedIndex)
                        {
                            case 0:
                                user.setPescado(0);
                                break;
                            case 1:
                                user.setPuerco(1);
                                break;
                            case 2:
                                user.setPuerco(3);
                                break;
                            case 3:
                                user.setPuerco(5);
                                break;
                        }

                        break;
                }
                comboBox_answers.Items.Clear();

                if (numeroDePregunta < 8)
                {
                    numeroDePregunta++;
                    foreach (string s in preguntaControl[numeroDePregunta].respuestas)
                    {
                        comboBox_answers.Items.Add(s);
                    }
                    txt_DropDownQuestion.Text = preguntaControl[numeroDePregunta].pregunta;
                }
                else
                {
                    txt_DropDownQuestion.Visibility = Visibility.Collapsed;
                    comboBox_answers.Visibility = Visibility.Collapsed;
                    button_finish.Opacity = 1;
                   
                }
            }
           
        }
    }
}
