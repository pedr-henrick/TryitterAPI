﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using TryitterWebAPI.Repository;

#nullable disable

namespace TryitterWebAPI.Migrations
{
    [DbContext(typeof(TryitterContext))]
    partial class AplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TryitterWebAPI.Models.Post", b =>
            {
                b.Property<int>("PostId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"));

                b.Property<string>("Text")
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("UrlImage")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("StudentId")
                    .HasColumnType("int");

                b.HasKey("PostId");

                b.HasIndex("StudentId");

                b.ToTable("Posts");
            });

            modelBuilder.Entity("TryitterWebAPI.Models.Student", b =>
            {
                b.Property<int>("StudentId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(200)");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("CurrentModule")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Status")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Password")
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnType("nvarchar(10)");

                b.HasKey("StudentId");

                b.ToTable("Students");
            });

            modelBuilder.Entity("TryitterWebAPI.Models.Post", b =>
            {
                b.HasOne("TryitterWebAPI.Models.Student", "Student")
                    .WithMany("Posts")
                    .HasForeignKey("StudentId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Student");
            });

            modelBuilder.Entity("TryitterWebAPI.Models.Student", b =>
            {
                b.Navigation("Posts");
            });
#pragma warning restore 612, 618
        }
    }
}