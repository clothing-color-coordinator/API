﻿// <auto-generated />
using ColorWheelAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ColorWheelAPI.Migrations
{
    [DbContext(typeof(ColorWheelDbContext))]
    [Migration("20190205001845_SeedTetradicPalettes")]
    partial class SeedTetradicPalettes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ColorWheelAPI.Models.Analogous", b =>
                {
                    b.Property<int>("ColorOneID");

                    b.Property<int>("ColorTwoID");

                    b.Property<int>("ColorThreeID");

                    b.Property<int>("ID");

                    b.HasKey("ColorOneID", "ColorTwoID", "ColorThreeID");

                    b.HasIndex("ID");

                    b.ToTable("AnalogousPalettes");

                    b.HasData(
                        new
                        {
                            ColorOneID = 1,
                            ColorTwoID = 2,
                            ColorThreeID = 12,
                            ID = 1
                        },
                        new
                        {
                            ColorOneID = 2,
                            ColorTwoID = 3,
                            ColorThreeID = 1,
                            ID = 2
                        },
                        new
                        {
                            ColorOneID = 3,
                            ColorTwoID = 4,
                            ColorThreeID = 2,
                            ID = 3
                        },
                        new
                        {
                            ColorOneID = 4,
                            ColorTwoID = 5,
                            ColorThreeID = 3,
                            ID = 4
                        },
                        new
                        {
                            ColorOneID = 5,
                            ColorTwoID = 6,
                            ColorThreeID = 4,
                            ID = 5
                        },
                        new
                        {
                            ColorOneID = 6,
                            ColorTwoID = 7,
                            ColorThreeID = 5,
                            ID = 6
                        },
                        new
                        {
                            ColorOneID = 7,
                            ColorTwoID = 8,
                            ColorThreeID = 6,
                            ID = 7
                        },
                        new
                        {
                            ColorOneID = 8,
                            ColorTwoID = 9,
                            ColorThreeID = 7,
                            ID = 8
                        },
                        new
                        {
                            ColorOneID = 9,
                            ColorTwoID = 10,
                            ColorThreeID = 8,
                            ID = 9
                        },
                        new
                        {
                            ColorOneID = 10,
                            ColorTwoID = 11,
                            ColorThreeID = 9,
                            ID = 10
                        },
                        new
                        {
                            ColorOneID = 11,
                            ColorTwoID = 12,
                            ColorThreeID = 10,
                            ID = 11
                        },
                        new
                        {
                            ColorOneID = 12,
                            ColorTwoID = 1,
                            ColorThreeID = 11,
                            ID = 12
                        });
                });

            modelBuilder.Entity("ColorWheelAPI.Models.Color", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColorName");

                    b.Property<string>("HexCode");

                    b.HasKey("ID");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ColorName = "Yellow",
                            HexCode = "#FEFE33"
                        },
                        new
                        {
                            ID = 2,
                            ColorName = "Yellow-Green",
                            HexCode = "#B2D732"
                        },
                        new
                        {
                            ID = 3,
                            ColorName = "Green",
                            HexCode = "#66B032"
                        },
                        new
                        {
                            ID = 4,
                            ColorName = "Blue-Green",
                            HexCode = "#347C98"
                        },
                        new
                        {
                            ID = 5,
                            ColorName = "Blue",
                            HexCode = "#0247FE"
                        },
                        new
                        {
                            ID = 6,
                            ColorName = "Blue-Violet",
                            HexCode = "#4424D6"
                        },
                        new
                        {
                            ID = 7,
                            ColorName = "Violet",
                            HexCode = "#8601AF"
                        },
                        new
                        {
                            ID = 8,
                            ColorName = "Red-Violet",
                            HexCode = "#C21460"
                        },
                        new
                        {
                            ID = 9,
                            ColorName = "Red",
                            HexCode = "#FE2712"
                        },
                        new
                        {
                            ID = 10,
                            ColorName = "Red-Orange",
                            HexCode = "#FC600A"
                        },
                        new
                        {
                            ID = 11,
                            ColorName = "Orange",
                            HexCode = "#FB9902"
                        },
                        new
                        {
                            ID = 12,
                            ColorName = "Yellow-Orange",
                            HexCode = "#FCCC1A"
                        });
                });

            modelBuilder.Entity("ColorWheelAPI.Models.Complimentary", b =>
                {
                    b.Property<int>("ColorOneID");

                    b.Property<int>("ColorTwoID");

                    b.Property<int>("ID");

                    b.HasKey("ColorOneID", "ColorTwoID");

                    b.HasIndex("ID");

                    b.ToTable("ComplimentaryPalettes");

                    b.HasData(
                        new
                        {
                            ColorOneID = 1,
                            ColorTwoID = 7,
                            ID = 1
                        },
                        new
                        {
                            ColorOneID = 2,
                            ColorTwoID = 8,
                            ID = 2
                        },
                        new
                        {
                            ColorOneID = 3,
                            ColorTwoID = 9,
                            ID = 3
                        },
                        new
                        {
                            ColorOneID = 4,
                            ColorTwoID = 10,
                            ID = 4
                        },
                        new
                        {
                            ColorOneID = 5,
                            ColorTwoID = 11,
                            ID = 5
                        },
                        new
                        {
                            ColorOneID = 6,
                            ColorTwoID = 12,
                            ID = 6
                        });
                });

            modelBuilder.Entity("ColorWheelAPI.Models.Monochromatic", b =>
                {
                    b.Property<int>("ColorOneID");

                    b.Property<int>("ColorTwoID");

                    b.Property<int>("ID");

                    b.HasKey("ColorOneID", "ColorTwoID");

                    b.HasIndex("ID");

                    b.ToTable("Monochromatic");
                });

            modelBuilder.Entity("ColorWheelAPI.Models.SplitComplimentary", b =>
                {
                    b.Property<int>("ColorOneID");

                    b.Property<int>("ColorTwoID");

                    b.Property<int>("ColorThreeID");

                    b.Property<int>("ID");

                    b.HasKey("ColorOneID", "ColorTwoID", "ColorThreeID");

                    b.HasIndex("ID");

                    b.ToTable("SplitComplimentaryPalettes");

                    b.HasData(
                        new
                        {
                            ColorOneID = 1,
                            ColorTwoID = 6,
                            ColorThreeID = 8,
                            ID = 1
                        },
                        new
                        {
                            ColorOneID = 2,
                            ColorTwoID = 7,
                            ColorThreeID = 9,
                            ID = 2
                        },
                        new
                        {
                            ColorOneID = 3,
                            ColorTwoID = 8,
                            ColorThreeID = 10,
                            ID = 3
                        },
                        new
                        {
                            ColorOneID = 4,
                            ColorTwoID = 9,
                            ColorThreeID = 11,
                            ID = 4
                        },
                        new
                        {
                            ColorOneID = 5,
                            ColorTwoID = 10,
                            ColorThreeID = 12,
                            ID = 5
                        },
                        new
                        {
                            ColorOneID = 6,
                            ColorTwoID = 11,
                            ColorThreeID = 1,
                            ID = 6
                        },
                        new
                        {
                            ColorOneID = 7,
                            ColorTwoID = 12,
                            ColorThreeID = 2,
                            ID = 7
                        },
                        new
                        {
                            ColorOneID = 8,
                            ColorTwoID = 1,
                            ColorThreeID = 3,
                            ID = 8
                        },
                        new
                        {
                            ColorOneID = 9,
                            ColorTwoID = 2,
                            ColorThreeID = 4,
                            ID = 9
                        },
                        new
                        {
                            ColorOneID = 10,
                            ColorTwoID = 3,
                            ColorThreeID = 5,
                            ID = 10
                        },
                        new
                        {
                            ColorOneID = 11,
                            ColorTwoID = 4,
                            ColorThreeID = 6,
                            ID = 11
                        },
                        new
                        {
                            ColorOneID = 12,
                            ColorTwoID = 5,
                            ColorThreeID = 7,
                            ID = 12
                        });
                });

            modelBuilder.Entity("ColorWheelAPI.Models.Tetradic", b =>
                {
                    b.Property<int>("ColorOneID");

                    b.Property<int>("ColorTwoID");

                    b.Property<int>("ColorThreeID");

                    b.Property<int>("ColorFourID");

                    b.Property<int>("ID");

                    b.HasKey("ColorOneID", "ColorTwoID", "ColorThreeID", "ColorFourID");

                    b.HasIndex("ID");

                    b.ToTable("TetradicPalettes");

                    b.HasData(
                        new
                        {
                            ColorOneID = 1,
                            ColorTwoID = 7,
                            ColorThreeID = 3,
                            ColorFourID = 9,
                            ID = 1
                        },
                        new
                        {
                            ColorOneID = 2,
                            ColorTwoID = 8,
                            ColorThreeID = 4,
                            ColorFourID = 10,
                            ID = 2
                        },
                        new
                        {
                            ColorOneID = 3,
                            ColorTwoID = 9,
                            ColorThreeID = 5,
                            ColorFourID = 11,
                            ID = 3
                        },
                        new
                        {
                            ColorOneID = 4,
                            ColorTwoID = 10,
                            ColorThreeID = 6,
                            ColorFourID = 12,
                            ID = 4
                        },
                        new
                        {
                            ColorOneID = 5,
                            ColorTwoID = 11,
                            ColorThreeID = 7,
                            ColorFourID = 1,
                            ID = 5
                        },
                        new
                        {
                            ColorOneID = 6,
                            ColorTwoID = 12,
                            ColorThreeID = 8,
                            ColorFourID = 2,
                            ID = 6
                        });
                });

            modelBuilder.Entity("ColorWheelAPI.Models.Triadic", b =>
                {
                    b.Property<int>("ColorOneID");

                    b.Property<int>("ColorTwoID");

                    b.Property<int>("ColorThreeID");

                    b.Property<int>("ID");

                    b.HasKey("ColorOneID", "ColorTwoID", "ColorThreeID");

                    b.HasIndex("ID");

                    b.ToTable("Triadic");
                });

            modelBuilder.Entity("ColorWheelAPI.Models.Analogous", b =>
                {
                    b.HasOne("ColorWheelAPI.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ColorWheelAPI.Models.Complimentary", b =>
                {
                    b.HasOne("ColorWheelAPI.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ColorWheelAPI.Models.Monochromatic", b =>
                {
                    b.HasOne("ColorWheelAPI.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ColorWheelAPI.Models.SplitComplimentary", b =>
                {
                    b.HasOne("ColorWheelAPI.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ColorWheelAPI.Models.Tetradic", b =>
                {
                    b.HasOne("ColorWheelAPI.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ColorWheelAPI.Models.Triadic", b =>
                {
                    b.HasOne("ColorWheelAPI.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
