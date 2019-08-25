using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Green_for_the_Earth.Data;

namespace Green_for_the_Earth.Migrations
{
    [DbContext(typeof(GreenContext))]
    [Migration("20190825100855_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.6");

            modelBuilder.Entity("Green_for_the_Earth.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Carne");

                    b.Property<double>("Co2Total");

                    b.Property<double>("Co2Vuelos");

                    b.Property<double>("Co2semanal");

                    b.Property<double>("Electricidad");

                    b.Property<double>("EmisionCarro");

                    b.Property<double>("EmisionGas");

                    b.Property<double>("EmisionGasTotal");

                    b.Property<double>("KmCamion");

                    b.Property<double>("KmCamionTotal");

                    b.Property<double>("KmCarro");

                    b.Property<double>("KmCarroTotal");

                    b.Property<double>("KmTaxi");

                    b.Property<double>("KmTaxiTotal");

                    b.Property<double>("KmVuelos");

                    b.Property<double>("KwhTotal");

                    b.Property<string>("ModeloCarro");

                    b.Property<string>("Nombre");

                    b.Property<string>("Pais");

                    b.Property<string>("Password");

                    b.Property<int>("Pescado");

                    b.Property<int>("Pollo");

                    b.Property<int>("Puerco");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });
        }
    }
}
