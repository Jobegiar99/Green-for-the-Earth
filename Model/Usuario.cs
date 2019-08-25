using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_for_the_Earth.Model
{

  
    public class Usuario
    {
        
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string[] carros = { "Toyota Yaris", "Toyota Corolla", "Nissan Versa", "Nissan March", "Chevrolet Aveo", "Toyota Prius", "Toyota Rav4", "Honda CR-V", "Volkswagen Jetta", "Volkswagen Vento", "Ford Expedition" };
        public double[] emPorModelo = { 0.154, 0.175, 0.167, 0.17, 0.161, 0.147, 0.209, 0.229, 0.205, 0.186, 0.404 };
        public int familiares;
        public string ModeloCarro { get; set; }
        public double EmisionCarro { get; set; }
        public double KmVuelos { get; set; }
        public double KmCarro { get; set; }
        public double KmCamion { get; set; }
        public double KmTaxi { get; set; }
        public double KmCarroTotal { get; set; }
        public double KmCamionTotal { get; set; }
        public double KmTaxiTotal { get; set; }
        public double Co2Vuelos { get; set; }
        public double Electricidad { get; set; }
        public double Co2semanal { get; set; }
        public double Co2Total { get; set; }
        public double KwhTotal { get; set; }
        public double EmisionGas { get; set; }
        public double EmisionGasTotal { get; set; }
        public int Carne { get; set; }
        public int Pollo { get; set; }
        public int Puerco { get; set; }
        public int Pescado { get; set; }
        public int ImprovCarne { get; set; }
        public int ImprovCarro { get; set; }

        public Usuario()
        {
            carros = new string[11] { "Toyota Yaris", "Toyota Corolla", "Nissan Versa", "Nissan March", "Chevrolet Aveo", "Toyota Prius", "Toyota Rav4", "Honda CR-V", "Volkswagen Jetta", "Volkswagen Vento", "Ford Expedition" };
            emPorModelo = new double[11] { 0.154, 0.175, 0.167, 0.17, 0.161, 0.147, 0.209, 0.229, 0.205, 0.186, 0.404 };
            Nombre = "Usuario";
            Pais = "Mexico";
            familiares = 0;
            ModeloCarro = carros[0];
            EmisionCarro = emPorModelo[0];
            KmCarro = 0;
            KmCamion = 0;
            KmTaxi = 0;
            KmCarroTotal = 0;
            KmCamionTotal = 0;
            KmTaxiTotal = 0;
            KmVuelos = 0;
            Electricidad = 0;
            KwhTotal = 0;
            EmisionGas = 0;
            EmisionGasTotal = 0;
            Co2semanal = 0;
            Co2Total = 0;

        }
        ~Usuario() { }
        public void setNombre(String nombre)
        {
            this.Nombre = nombre;
        }
        public void setPais(String pais)
        {
            this.Pais = pais;
        }
        public void setFamiliares(int familiares)
        {
            this.familiares = familiares;
        }

        public void setModelo(String modelo)
        {
            ModeloCarro = modelo;
            for (int i = 0; i < 4; i++)
            {
                if (ModeloCarro == carros[i])
                {
                    EmisionCarro = emPorModelo[i];
                }
            }
        }
        //Se ingresan los datos y se suman al total semanal
        public void addKmCarro(double horas, int minutos)
        {
            horas = horas + minutos / 60;
            double km = horas * 11.3;
            KmCarro += km;
            Co2semanal += km * EmisionCarro;
        }
        public void addKmCamion(int horas, int minutos)
        {
            horas = horas + minutos / 60;
            double km = horas * 9.1;
            KmCamion += km;
            Co2semanal += km * 0.7 / 50;
        }
        public void addKmTaxi(int horas, int minutos)
        {
            horas = horas + minutos / 60;
            double km = horas * 11.3;
            KmTaxi += km;
            Co2semanal += km * 0.188;
        }
        //de una ciudad a otra
        public void addKmVuelos(int horas, int minutos)
        {
            horas = horas + minutos / 60;
            double km = horas * 900;
            KmVuelos += km;
            Co2semanal += km * 0.25;
        }

        public void addElectricidad(double kwh)
        {
            Electricidad += kwh;
            Co2semanal += kwh * 2.15 * 0.7 / 10.65;
        }

        public void addEmisionGas(double gas)
        {
            EmisionGas += gas * 2.15;
        }

        public double comoVas()
        {
            //si es positivo estas por encima del promedio, si es negativo estas por abajo
            return Co2semanal - 76.92;
        }
        public void setCarne(int carne)
        {
            //pide porciones
            this.Carne = carne;
            Co2semanal += carne * 4.05;
        }
        public void setPollo(int pollo)
        {
            //pide porciones
            this.Pollo = pollo;
            Co2semanal += pollo * 0.234;
        }
        public void setPuerco(int puerco)
        {
            //pide porciones
            this.Puerco = puerco;
            Co2semanal += puerco * 0.55;
        }
        public void setPescado(int pescado)
        {
            //pide porciones
            this.Pescado = pescado;
            Co2semanal += pescado * 0.0495;
        }

        //Total de la semana, se borran los datos semanales y se guardan en total
        public void weekend()
        {
            Co2Total += Co2semanal;
            KmCarroTotal += KmCarro;
            KmCamionTotal += KmCamion;
            KmTaxiTotal += KmTaxi;
            KwhTotal += (Electricidad * 0.37) / familiares;
            EmisionGasTotal += EmisionGas;
            KmCamion = 0;
            KmCarro = 0;
            KmTaxi = 0;
            KmVuelos = 0;
            Electricidad = 0;
            Co2semanal = 0;
            EmisionGas = 0;
        }
        public double getImprovCarne()
        {
            //si comieras 30% menos carne
            //como cambiaria tu huella
            double menorCo2 = Co2semanal - Carne * 4.05 * 0.3;
            double dif = Co2semanal - menorCo2;
            double percent = dif * 100 / Co2semanal;
            ImprovCarne = (int)percent;
            return percent;
        }
        public double getImprovRaite()
        {
            double menorCo2 = Co2semanal - KmCarro * EmisionCarro;
            double dif = Co2semanal - menorCo2;
            double percent = dif * 100 / Co2semanal;
            ImprovCarro = (int)percent;
            return percent;
        }


    }
}
