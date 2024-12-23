﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicPlayerData.Data;

#nullable disable

namespace MusicPlayerData.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220624204736_add_CreationDate_on_playlists")]
    partial class add_CreationDate_on_playlists
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("MusicPlayerData.DataEntities.MediaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FilePath")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<int?>("PlayerlistId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PlayerlistId");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("MusicPlayerData.DataEntities.PlaylistEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("MusicPlayerData.DataEntities.MediaEntity", b =>
                {
                    b.HasOne("MusicPlayerData.DataEntities.PlaylistEntity", "Playerlist")
                        .WithMany("Songs")
                        .HasForeignKey("PlayerlistId");

                    b.Navigation("Playerlist");
                });

            modelBuilder.Entity("MusicPlayerData.DataEntities.PlaylistEntity", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
