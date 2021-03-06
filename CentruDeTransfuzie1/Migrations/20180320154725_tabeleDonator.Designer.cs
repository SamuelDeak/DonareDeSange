﻿// <auto-generated />
using CentruDeTransfuzie1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CentruDeTransfuzie1.Migrations
{
    [DbContext(typeof(CTContext))]
    [Migration("20180320154725_tabeleDonator")]
    partial class tabeleDonator
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Donator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataNastere");

                    b.Property<string>("Domiciliu");

                    b.Property<string>("Email");

                    b.Property<float>("Greutate");

                    b.Property<bool>("InterventiiUltimele6Luni");

                    b.Property<string>("Judet");

                    b.Property<string>("JudetResedinta");

                    b.Property<string>("Localitate");

                    b.Property<string>("LocalitateResedinta");

                    b.Property<string>("Nume");

                    b.Property<string>("Prenume");

                    b.Property<int>("Puls");

                    b.Property<string>("Resedinta");

                    b.Property<string>("Sex");

                    b.Property<bool>("SubTratament");

                    b.Property<string>("Telefon");

                    b.Property<int>("Tensiune");

                    b.Property<int?>("UserDonatorId");

                    b.HasKey("Id");

                    b.HasIndex("UserDonatorId")
                        .IsUnique()
                        .HasFilter("[UserDonatorId] IS NOT NULL");

                    b.ToTable("Donator");
                });

            modelBuilder.Entity("Medic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cnp");

                    b.Property<string>("Email");

                    b.Property<string>("Nume");

                    b.Property<string>("Prenume");

                    b.Property<string>("Telefon");

                    b.Property<int?>("UserMedicId");

                    b.HasKey("Id");

                    b.HasIndex("UserMedicId")
                        .IsUnique()
                        .HasFilter("[UserMedicId] IS NOT NULL");

                    b.ToTable("Medic");
                });

            modelBuilder.Entity("UserDonator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Parola");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("UserDonator");
                });

            modelBuilder.Entity("UserMedic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Parola");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("UserMedic");
                });

            modelBuilder.Entity("Donator", b =>
                {
                    b.HasOne("UserDonator", "UserDonator")
                        .WithOne("Donator")
                        .HasForeignKey("Donator", "UserDonatorId");
                });

            modelBuilder.Entity("Medic", b =>
                {
                    b.HasOne("UserMedic", "UserMedic")
                        .WithOne("Medic")
                        .HasForeignKey("Medic", "UserMedicId");
                });
#pragma warning restore 612, 618
        }
    }
}
