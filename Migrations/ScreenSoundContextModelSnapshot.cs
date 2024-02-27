﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ScreenSound.DAL;

#nullable disable

namespace ScreenSound2._0.Migrations
{
    [DbContext(typeof(ScreenSoundContext))]
    partial class ScreenSoundContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.1.24081.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ScreenSound.Model.AlbumsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("BandId")
                        .HasColumnType("integer")
                        .HasColumnName("band_id");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("BandId");

                    b.ToTable("tb_albums", (string)null);
                });

            modelBuilder.Entity("ScreenSound.Model.BandsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DtRegistration")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dt_registration");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("tb_bands", (string)null);
                });

            modelBuilder.Entity("ScreenSound.Model.SongsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AlbumId")
                        .HasColumnType("integer")
                        .HasColumnName("album_id");

                    b.Property<int>("BandId")
                        .HasColumnType("integer")
                        .HasColumnName("band_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.HasIndex("BandId");

                    b.ToTable("tb_songs", (string)null);
                });

            modelBuilder.Entity("ScreenSound.Model.AlbumsModel", b =>
                {
                    b.HasOne("ScreenSound.Model.BandsModel", "Band")
                        .WithMany()
                        .HasForeignKey("BandId");

                    b.Navigation("Band");
                });

            modelBuilder.Entity("ScreenSound.Model.SongsModel", b =>
                {
                    b.HasOne("ScreenSound.Model.AlbumsModel", "Album")
                        .WithMany()
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ScreenSound.Model.BandsModel", "Band")
                        .WithMany()
                        .HasForeignKey("BandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Band");
                });
#pragma warning restore 612, 618
        }
    }
}
