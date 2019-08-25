using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Green_for_the_Earth.Data;

namespace Green_for_the_Earth.Migrations
{
    [DbContext(typeof(GreenContext))]
    [Migration("20190825085223_added-Emision")]
    partial class addedEmision
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.6");

            modelBuilder.Entity("Green_for_the_Earth.Model.Use", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Casa");

                    b.Property<double>("Comida");

                    b.Property<string>("Password");

                    b.Property<double>("Transporte");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Uses");
                });
        }
    }
}
