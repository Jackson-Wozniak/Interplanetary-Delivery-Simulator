﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using interplanetary_delivery_simulator.Data;

#nullable disable

namespace interplanetary_delivery_simulator.Migrations
{
    [DbContext(typeof(LunarLogisticsDbContext))]
    partial class LunarLogisticsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("interplanetary_delivery_simulator.planetary_resources.Entities.Planet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Planets");
                });

            modelBuilder.Entity("interplanetary_delivery_simulator.planetary_resources.Entities.Planet", b =>
                {
                    b.OwnsOne("interplanetary_delivery_simulator.planetary_resources.Entities.OrbitTelemetry", "Orbit", b1 =>
                        {
                            b1.Property<long>("PlanetId")
                                .HasColumnType("bigint");

                            b1.Property<double>("EarthMasses")
                                .HasColumnType("double");

                            b1.Property<long>("OrbitsAroundId")
                                .HasColumnType("bigint");

                            b1.Property<double>("XCoordinate")
                                .HasColumnType("double");

                            b1.Property<double>("YCoordinate")
                                .HasColumnType("double");

                            b1.HasKey("PlanetId");

                            b1.HasIndex("OrbitsAroundId");

                            b1.ToTable("Planets");

                            b1.HasOne("interplanetary_delivery_simulator.planetary_resources.Entities.Planet", "OrbitsAround")
                                .WithMany()
                                .HasForeignKey("OrbitsAroundId")
                                .OnDelete(DeleteBehavior.Restrict)
                                .IsRequired();

                            b1.WithOwner()
                                .HasForeignKey("PlanetId");

                            b1.Navigation("OrbitsAround");
                        });

                    b.OwnsOne("interplanetary_delivery_simulator.planetary_resources.Entities.PlanetInformation", "Information", b1 =>
                        {
                            b1.Property<long>("PlanetId")
                                .HasColumnType("bigint");

                            b1.Property<long>("PersonCapacity")
                                .HasColumnType("bigint");

                            b1.Property<long>("PersonCount")
                                .HasColumnType("bigint");

                            b1.Property<int>("Type")
                                .HasColumnType("int");

                            b1.HasKey("PlanetId");

                            b1.ToTable("Planets");

                            b1.WithOwner()
                                .HasForeignKey("PlanetId");
                        });

                    b.Navigation("Information")
                        .IsRequired();

                    b.Navigation("Orbit")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
