// <auto-generated />
using System;
using HyperSloopApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HyperSloopApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("HyperSloopApp.Models.Events", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("EventType")
                        .HasColumnType("int");

                    b.Property<int>("SlideId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("EventId");

                    b.HasIndex("SlideId");

                    b.HasIndex("UserId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("HyperSloopApp.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("HyperSloopApp.Models.Sensor", b =>
                {
                    b.Property<int>("SensorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EventType")
                        .HasColumnType("int");

                    b.Property<string>("ExternalDeviceId")
                        .HasColumnType("longtext");

                    b.Property<int>("SlideId")
                        .HasColumnType("int");

                    b.HasKey("SensorId");

                    b.HasIndex("SlideId");

                    b.ToTable("Sensors");
                });

            modelBuilder.Entity("HyperSloopApp.Models.SensorEvent", b =>
                {
                    b.Property<int>("SensorEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("SensorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime(6)");

                    b.HasKey("SensorEventId");

                    b.HasIndex("SensorId");

                    b.ToTable("SensorEvents");
                });

            modelBuilder.Entity("HyperSloopApp.Models.Slide", b =>
                {
                    b.Property<int>("SlideId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EndingFloor")
                        .HasColumnType("int");

                    b.Property<double>("HeightInFeet")
                        .HasColumnType("double");

                    b.Property<string>("HexColor")
                        .HasColumnType("longtext");

                    b.Property<double>("LengthInFeet")
                        .HasColumnType("double");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("StartingFloor")
                        .HasColumnType("int");

                    b.HasKey("SlideId");

                    b.HasIndex("LocationId");

                    b.ToTable("Slides");
                });

            modelBuilder.Entity("HyperSloopApp.Models.SlideEvent", b =>
                {
                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("ScanDuration")
                        .HasColumnType("double")
                        .HasColumnName("Scan Duration");

                    b.Property<DateTime>("ScanTime")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("SlideDuration")
                        .HasColumnType("double")
                        .HasColumnName("Slide Duration");

                    b.Property<string>("SlideEventId")
                        .HasColumnType("longtext");

                    b.Property<int>("SlideId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasIndex("SlideId");

                    b.HasIndex("UserId");

                    b.ToView("slideevents");
                });

            modelBuilder.Entity("HyperSloopApp.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HyperSloopApp.Models.Events", b =>
                {
                    b.HasOne("HyperSloopApp.Models.Slide", "Slide")
                        .WithMany()
                        .HasForeignKey("SlideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HyperSloopApp.Models.User", "User")
                        .WithMany("Events")
                        .HasForeignKey("UserId");

                    b.Navigation("Slide");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HyperSloopApp.Models.Sensor", b =>
                {
                    b.HasOne("HyperSloopApp.Models.Slide", "Slide")
                        .WithMany()
                        .HasForeignKey("SlideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Slide");
                });

            modelBuilder.Entity("HyperSloopApp.Models.SensorEvent", b =>
                {
                    b.HasOne("HyperSloopApp.Models.Sensor", "Sensor")
                        .WithMany("SensorEvents")
                        .HasForeignKey("SensorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sensor");
                });

            modelBuilder.Entity("HyperSloopApp.Models.Slide", b =>
                {
                    b.HasOne("HyperSloopApp.Models.Location", "Location")
                        .WithMany("Slides")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("HyperSloopApp.Models.SlideEvent", b =>
                {
                    b.HasOne("HyperSloopApp.Models.Slide", "Slide")
                        .WithMany()
                        .HasForeignKey("SlideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HyperSloopApp.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Slide");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HyperSloopApp.Models.Location", b =>
                {
                    b.Navigation("Slides");
                });

            modelBuilder.Entity("HyperSloopApp.Models.Sensor", b =>
                {
                    b.Navigation("SensorEvents");
                });

            modelBuilder.Entity("HyperSloopApp.Models.User", b =>
                {
                    b.Navigation("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
