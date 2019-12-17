﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication11.Models;

namespace WebApplication11.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication11.Models.Questions", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsMandatory")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMultiSelection")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNotified")
                        .HasColumnType("bit");

                    b.Property<bool>("IsScored")
                        .HasColumnType("bit");

                    b.Property<int>("MaxScore")
                        .HasColumnType("int");

                    b.Property<int>("Scored")
                        .HasColumnType("int");

                    b.Property<int?>("TemplateId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("TypeOfResponse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.HasIndex("TemplateId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("WebApplication11.Models.Template", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TemplateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Templates");
                });

            modelBuilder.Entity("WebApplication11.Models.Questions", b =>
                {
                    b.HasOne("WebApplication11.Models.Template", "Template")
                        .WithMany("Questions")
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
