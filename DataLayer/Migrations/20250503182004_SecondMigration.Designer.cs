﻿// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataLayer.Migrations
{
    [DbContext(typeof(CatalogforMoviesDBContext))]
    [Migration("20250503182004_SecondMigration")]
    partial class SecondMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BusinessLayer.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("BusinessLayer.Movie", b =>
                {
                    b.Property<string>("MovieAdress")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int?>("RankingID")
                        .HasColumnType("int");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<decimal>("Review")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MovieAdress");

                    b.HasIndex("GenreId");

                    b.HasIndex("RankingID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("BusinessLayer.Ranking", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ViewersID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ViewersID");

                    b.ToTable("Rankings");
                });

            modelBuilder.Entity("BusinessLayer.Viewer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Viewers");
                });

            modelBuilder.Entity("BusinessLayer.Movie", b =>
                {
                    b.HasOne("BusinessLayer.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessLayer.Ranking", null)
                        .WithMany("Movies")
                        .HasForeignKey("RankingID");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("BusinessLayer.Ranking", b =>
                {
                    b.HasOne("BusinessLayer.Viewer", "Viewers")
                        .WithMany()
                        .HasForeignKey("ViewersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Viewers");
                });

            modelBuilder.Entity("BusinessLayer.Genre", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("BusinessLayer.Ranking", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
