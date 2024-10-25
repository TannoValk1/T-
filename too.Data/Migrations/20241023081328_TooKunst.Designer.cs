﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using too.Data;

#nullable disable

namespace too.Data.Migrations
{
    [DbContext(typeof(DatabaseTaskDbContext))]
    [Migration("20241023081328_TooKunst")]
    partial class TooKunst
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("too.Core.Domain.KunstiOmanik", b =>
                {
                    b.Property<string>("OmanikuNimi")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("KunstiOmanikuVanus")
                        .HasColumnType("int");

                    b.HasKey("OmanikuNimi");

                    b.ToTable("KunstiOmanik");
                });

            modelBuilder.Entity("too.Core.Domain.Kunstiteosed", b =>
                {
                    b.Property<int>("KunstiteoseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KunstiteoseID"));

                    b.Property<string>("Kunstnik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaalimiseAasta")
                        .HasColumnType("int");

                    b.Property<string>("TeoseNimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KunstiteoseID");

                    b.ToTable("Kunstiteosed");
                });

            modelBuilder.Entity("too.Core.Domain.Kunstityyp", b =>
                {
                    b.Property<string>("skulptuur")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("skulptuur");

                    b.ToTable("Kunstityyp");
                });

            modelBuilder.Entity("too.Core.Domain.Kunstnik", b =>
                {
                    b.Property<int>("KunstnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KunstnikId"));

                    b.Property<string>("KunstiTyyp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KunstnikuNimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Vanus")
                        .HasColumnType("int");

                    b.HasKey("KunstnikId");

                    b.ToTable("Kunstnik");
                });
#pragma warning restore 612, 618
        }
    }
}
