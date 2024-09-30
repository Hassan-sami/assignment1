﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using assignment6.context;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(RouteContext))]
    partial class RouteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("assignment6.context.entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("Crs_Id");

                    b.Property<int?>("Duration")
                        .HasColumnType("int")
                        .HasColumnName("Crs_Duration");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Crs_Name");

                    b.Property<int?>("TopicId")
                        .HasColumnType("int")
                        .HasColumnName("Top_Id");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Course", (string)null);
                });

            modelBuilder.Entity("assignment6.context.entities.Department", b =>
                {
                    b.Property<int>("DeptId")
                        .HasColumnType("int")
                        .HasColumnName("Dept_Id");

                    b.Property<string>("DeptDesc")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Dept_Desc");

                    b.Property<string>("DeptLocation")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Dept_Location");

                    b.Property<int?>("DeptManagerId")
                        .HasColumnType("int")
                        .HasColumnName("Dept_Manager");

                    b.Property<string>("DeptName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Dept_Name");

                    b.Property<DateTime?>("ManagerHiredate")
                        .HasColumnType("date")
                        .HasColumnName("Manager_hiredate");

                    b.HasKey("DeptId");

                    b.HasIndex("DeptManagerId");

                    b.HasIndex(new[] { "ManagerHiredate" }, "hireIndex");

                    b.ToTable("Department", (string)null);
                });

            modelBuilder.Entity("assignment6.context.entities.InsCourse", b =>
                {
                    b.Property<int>("InsId")
                        .HasColumnType("int")
                        .HasColumnName("Ins_Id");

                    b.Property<int>("CrsId")
                        .HasColumnType("int")
                        .HasColumnName("Crs_Id");

                    b.Property<string>("Evaluation")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("InsId", "CrsId");

                    b.HasIndex("CrsId");

                    b.ToTable("Ins_Course", (string)null);
                });

            modelBuilder.Entity("assignment6.context.entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("Ins_Id");

                    b.Property<string>("Degree")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Ins_Degree");

                    b.Property<int?>("DeptId")
                        .HasColumnType("int")
                        .HasColumnName("Dept_Id");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Ins_Name");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.ToTable("Instructor", (string)null);
                });

            modelBuilder.Entity("assignment6.context.entities.StudCourse", b =>
                {
                    b.Property<int>("CrsId")
                        .HasColumnType("int")
                        .HasColumnName("Crs_Id");

                    b.Property<int>("StId")
                        .HasColumnType("int")
                        .HasColumnName("St_Id");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.HasKey("CrsId", "StId");

                    b.HasIndex("StId");

                    b.ToTable("Stud_Course", (string)null);
                });

            modelBuilder.Entity("assignment6.context.entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("St_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 2L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("St_Address");

                    b.Property<int?>("Age")
                        .HasColumnType("int")
                        .HasColumnName("St_Age");

                    b.Property<int?>("DeptId")
                        .HasColumnType("int")
                        .HasColumnName("Dept_Id");

                    b.Property<string>("Fname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("St_Fname");

                    b.Property<string>("Lname")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("St_Lname")
                        .IsFixedLength();

                    b.Property<int?>("StSuperId")
                        .HasColumnType("int")
                        .HasColumnName("St_super");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.HasIndex("StSuperId");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("assignment6.context.entities.Topic", b =>
                {
                    b.Property<int>("TopId")
                        .HasColumnType("int")
                        .HasColumnName("Top_Id");

                    b.Property<string>("TopName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Top_Name");

                    b.HasKey("TopId");

                    b.ToTable("Topic", (string)null);
                });

            modelBuilder.Entity("assignment6.context.entities.Course", b =>
                {
                    b.HasOne("assignment6.context.entities.Topic", "Topic")
                        .WithMany("Courses")
                        .HasForeignKey("TopicId")
                        .HasConstraintName("FK_Course_Topic");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("assignment6.context.entities.Department", b =>
                {
                    b.HasOne("assignment6.context.entities.Instructor", "DeptManager")
                        .WithMany("Departments")
                        .HasForeignKey("DeptManagerId")
                        .HasConstraintName("FK_Department_Instructor");

                    b.Navigation("DeptManager");
                });

            modelBuilder.Entity("assignment6.context.entities.InsCourse", b =>
                {
                    b.HasOne("assignment6.context.entities.Course", "Crs")
                        .WithMany("InsCourses")
                        .HasForeignKey("CrsId")
                        .IsRequired()
                        .HasConstraintName("FK_Ins_Course_Course");

                    b.HasOne("assignment6.context.entities.Instructor", "Ins")
                        .WithMany("InsCourses")
                        .HasForeignKey("InsId")
                        .IsRequired()
                        .HasConstraintName("FK_Ins_Course_Instructor");

                    b.Navigation("Crs");

                    b.Navigation("Ins");
                });

            modelBuilder.Entity("assignment6.context.entities.Instructor", b =>
                {
                    b.HasOne("assignment6.context.entities.Department", "Dept")
                        .WithMany("Instructors")
                        .HasForeignKey("DeptId")
                        .HasConstraintName("FK_Instructor_Department");

                    b.Navigation("Dept");
                });

            modelBuilder.Entity("assignment6.context.entities.StudCourse", b =>
                {
                    b.HasOne("assignment6.context.entities.Course", "Crs")
                        .WithMany("StudCourses")
                        .HasForeignKey("CrsId")
                        .IsRequired()
                        .HasConstraintName("FK_Stud_Course_Course");

                    b.HasOne("assignment6.context.entities.Student", "St")
                        .WithMany("StudCourses")
                        .HasForeignKey("StId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Stud_Course_Student");

                    b.Navigation("Crs");

                    b.Navigation("St");
                });

            modelBuilder.Entity("assignment6.context.entities.Student", b =>
                {
                    b.HasOne("assignment6.context.entities.Department", "Dept")
                        .WithMany("Students")
                        .HasForeignKey("DeptId")
                        .HasConstraintName("FK_Student_Department");

                    b.HasOne("assignment6.context.entities.Student", "StSuper")
                        .WithMany("Students")
                        .HasForeignKey("StSuperId")
                        .HasConstraintName("FK_Student_Student");

                    b.Navigation("Dept");

                    b.Navigation("StSuper");
                });

            modelBuilder.Entity("assignment6.context.entities.Course", b =>
                {
                    b.Navigation("InsCourses");

                    b.Navigation("StudCourses");
                });

            modelBuilder.Entity("assignment6.context.entities.Department", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("assignment6.context.entities.Instructor", b =>
                {
                    b.Navigation("Departments");

                    b.Navigation("InsCourses");
                });

            modelBuilder.Entity("assignment6.context.entities.Student", b =>
                {
                    b.Navigation("StudCourses");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("assignment6.context.entities.Topic", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
