﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2;
using WebApplication2.DataBase;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(QuestionsContext))]
    [Migration("20211012205635_Quest")]
    partial class Quest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication2.Questions", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_Quest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Var_Answ1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Var_Answ2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Var_Answ3")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}