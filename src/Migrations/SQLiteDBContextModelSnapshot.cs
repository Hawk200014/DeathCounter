﻿// <auto-generated />
using System;
using DeathCounterHotkey.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DeathCounterHotkey.Migrations
{
    [DbContext(typeof(SQLiteDBContext))]
    partial class SQLiteDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("DeathCounterHotkey.Database.Models.DeathLocationModel", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Finish")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GameID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LocationId");

                    b.HasIndex("GameID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("DeathCounterHotkey.Database.Models.DeathModel", b =>
                {
                    b.Property<int>("DeathId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RecordingTime")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StreamTime")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("TEXT");

                    b.HasKey("DeathId");

                    b.HasIndex("LocationId");

                    b.ToTable("Deaths");
                });

            modelBuilder.Entity("DeathCounterHotkey.Database.Models.GameStatsModel", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("GameName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Prefix")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("GameId");

                    b.ToTable("GameStats");
                });

            modelBuilder.Entity("DeathCounterHotkey.Database.Models.MarkerModel", b =>
                {
                    b.Property<int>("MarkerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Categorie")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GameId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RecordingSession")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RecordingTime")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StreamSession")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StreamTime")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("TEXT");

                    b.HasKey("MarkerId");

                    b.HasIndex("GameId");

                    b.ToTable("Markers");
                });

            modelBuilder.Entity("DeathCounterHotkey.Database.Models.RecordingModel", b =>
                {
                    b.Property<int>("RecordingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("SessionCount")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("SessionDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RecordingId");

                    b.ToTable("Recordings");
                });

            modelBuilder.Entity("DeathCounterHotkey.Database.Models.SettingsModel", b =>
                {
                    b.Property<int>("SettingsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("SettingsName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SettingsValue")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SettingsId");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("DeathCounterHotkey.Database.Models.DeathLocationModel", b =>
                {
                    b.HasOne("DeathCounterHotkey.Database.Models.GameStatsModel", "Game")
                        .WithMany("Locations")
                        .HasForeignKey("GameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("DeathCounterHotkey.Database.Models.DeathModel", b =>
                {
                    b.HasOne("DeathCounterHotkey.Database.Models.DeathLocationModel", "Location")
                        .WithMany("Deaths")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("DeathCounterHotkey.Database.Models.MarkerModel", b =>
                {
                    b.HasOne("DeathCounterHotkey.Database.Models.GameStatsModel", "Game")
                        .WithMany("Markers")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("DeathCounterHotkey.Database.Models.DeathLocationModel", b =>
                {
                    b.Navigation("Deaths");
                });

            modelBuilder.Entity("DeathCounterHotkey.Database.Models.GameStatsModel", b =>
                {
                    b.Navigation("Locations");

                    b.Navigation("Markers");
                });
#pragma warning restore 612, 618
        }
    }
}
