﻿// <auto-generated />
using CodeFirsTEFapp.Infrastructure.Appdbcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CodeFirsTEFapp.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbcontext))]
    partial class AppDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CodeFirsTEFapp.Domain.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("CodeFirsTEFapp.Domain.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("Salary")
                        .HasColumnType("integer")
                        .HasColumnName("hello");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("CodeFirsTEFapp.Domain.Models.TeacherSubject", b =>
                {
                    b.Property<int>("SubjectID")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherID")
                        .HasColumnType("integer");

                    b.HasKey("SubjectID", "TeacherID");

                    b.HasIndex("TeacherID");

                    b.ToTable("TeacherSubjects");
                });

            modelBuilder.Entity("CodeFirsTEFapp.Domain.Models.TeacherSubject", b =>
                {
                    b.HasOne("CodeFirsTEFapp.Domain.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirsTEFapp.Domain.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });
#pragma warning restore 612, 618
        }
    }
}
