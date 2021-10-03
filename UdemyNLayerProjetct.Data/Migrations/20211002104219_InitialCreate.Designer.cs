﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UdemyNLayerProjetct.Data;

namespace UdemyNLayerProjetct.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211002104219_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UdemyNLayerProjetct.Core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Sebze"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Ev malzemeleri"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Kırtasiye"
                        });
                });

            modelBuilder.Entity("UdemyNLayerProjetct.Core.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("InnerBarcode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            IsDeleted = false,
                            Name = "kiraz",
                            Price = 2.50m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            IsDeleted = false,
                            Name = "beyaz çamaşır tozu",
                            Price = 65m,
                            Stock = 15
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            IsDeleted = false,
                            Name = "çilek",
                            Price = 3.50m,
                            Stock = 250
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            IsDeleted = false,
                            Name = "cay bardagı",
                            Price = 15m,
                            Stock = 6
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            IsDeleted = false,
                            Name = "defter",
                            Price = 7.50m,
                            Stock = 15
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            IsDeleted = false,
                            Name = "kalem",
                            Price = 5m,
                            Stock = 20
                        });
                });

            modelBuilder.Entity("UdemyNLayerProjetct.Core.Models.Product", b =>
                {
                    b.HasOne("UdemyNLayerProjetct.Core.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("UdemyNLayerProjetct.Core.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
