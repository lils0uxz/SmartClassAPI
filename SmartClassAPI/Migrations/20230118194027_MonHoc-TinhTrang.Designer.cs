﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartClassAPI.Data;

namespace SmartClassAPI.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230118194027_MonHoc-TinhTrang")]
    partial class MonHocTinhTrang
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SmartClassAPI.Data.DevicesData", b =>
                {
                    b.Property<int>("IdDevice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeviceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeviceTpye")
                        .HasColumnType("int");

                    b.Property<int?>("IdPhongHoc")
                        .HasColumnType("int");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("MieuTaCongDung")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDevice");

                    b.HasIndex("IdPhongHoc");

                    b.HasIndex("IdUser");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("SmartClassAPI.Data.LoaiUserData", b =>
                {
                    b.Property<int>("IdLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MotaLoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLoai");

                    b.ToTable("LoaiUser");
                });

            modelBuilder.Entity("SmartClassAPI.Data.LopHoc", b =>
                {
                    b.Property<int>("IdLopHoc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaLopHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.HasKey("IdLopHoc");

                    b.ToTable("LopHoc");
                });

            modelBuilder.Entity("SmartClassAPI.Data.MonHoc", b =>
                {
                    b.Property<int>("IdMonHoc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdLopHoc")
                        .HasColumnType("int");

                    b.Property<int?>("IdPhongHoc")
                        .HasColumnType("int");

                    b.Property<int?>("IdTinhTrang")
                        .HasColumnType("int");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoTiet")
                        .HasColumnType("int");

                    b.Property<string>("TenMonHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMonHoc");

                    b.HasIndex("IdLopHoc");

                    b.HasIndex("IdPhongHoc");

                    b.HasIndex("IdTinhTrang");

                    b.HasIndex("IdUser");

                    b.ToTable("MonHoc");
                });

            modelBuilder.Entity("SmartClassAPI.Data.PhongHocData", b =>
                {
                    b.Property<int>("IdPhongHoc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenPhongHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPhongHoc");

                    b.ToTable("PhongHoc");
                });

            modelBuilder.Entity("SmartClassAPI.Data.TTMonDT", b =>
                {
                    b.Property<int>("IdTinhTrang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTinhTrang")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTinhTrang");

                    b.ToTable("TinhTrangMonHoc");
                });

            modelBuilder.Entity("SmartClassAPI.Data.TaiLieuHocTap", b =>
                {
                    b.Property<int>("IdTaiLieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdMonHoc")
                        .HasColumnType("int");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("TenTaiLieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlTaiLieu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTaiLieu");

                    b.HasIndex("IdMonHoc");

                    b.HasIndex("IdUser");

                    b.ToTable("TaiLieuHocTap");
                });

            modelBuilder.Entity("SmartClassAPI.Data.TkbData", b =>
                {
                    b.Property<int>("IdLopHoc")
                        .HasColumnType("int");

                    b.Property<int>("IdPhongHoc")
                        .HasColumnType("int");

                    b.Property<int>("IdMonHoc")
                        .HasColumnType("int");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayThan")
                        .HasColumnType("datetime2");

                    b.Property<int>("SangChieu")
                        .HasColumnType("int");

                    b.Property<string>("Thu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TinhTrang")
                        .HasColumnType("int");

                    b.HasKey("IdLopHoc", "IdPhongHoc", "IdMonHoc");

                    b.HasIndex("IdMonHoc");

                    b.HasIndex("IdPhongHoc");

                    b.HasIndex("IdUser");

                    b.ToTable("ThoiKhoaBieu");
                });

            modelBuilder.Entity("SmartClassAPI.Data.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("Nvarchar(200)");

                    b.Property<int?>("IdHocSinh")
                        .HasColumnType("int");

                    b.Property<int?>("IdLoai")
                        .HasColumnType("int");

                    b.Property<int?>("IdLopHoc")
                        .HasColumnType("int");

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdUser");

                    b.HasIndex("IdLoai");

                    b.HasIndex("IdLopHoc");

                    b.ToTable("User");
                });

            modelBuilder.Entity("SmartClassAPI.Data.DevicesData", b =>
                {
                    b.HasOne("SmartClassAPI.Data.PhongHocData", "PhongHocData")
                        .WithMany()
                        .HasForeignKey("IdPhongHoc");

                    b.HasOne("SmartClassAPI.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser");

                    b.Navigation("PhongHocData");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartClassAPI.Data.MonHoc", b =>
                {
                    b.HasOne("SmartClassAPI.Data.LopHoc", "LopHoc")
                        .WithMany("MonHocs")
                        .HasForeignKey("IdLopHoc");

                    b.HasOne("SmartClassAPI.Data.PhongHocData", "PhongHoc")
                        .WithMany("MonHocs")
                        .HasForeignKey("IdPhongHoc");

                    b.HasOne("SmartClassAPI.Data.TTMonDT", "TinhTrangMH")
                        .WithMany()
                        .HasForeignKey("IdTinhTrang");

                    b.HasOne("SmartClassAPI.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser");

                    b.Navigation("LopHoc");

                    b.Navigation("PhongHoc");

                    b.Navigation("TinhTrangMH");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartClassAPI.Data.TaiLieuHocTap", b =>
                {
                    b.HasOne("SmartClassAPI.Data.MonHoc", "MonHoc")
                        .WithMany()
                        .HasForeignKey("IdMonHoc");

                    b.HasOne("SmartClassAPI.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser");

                    b.Navigation("MonHoc");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartClassAPI.Data.TkbData", b =>
                {
                    b.HasOne("SmartClassAPI.Data.LopHoc", "LopHoc")
                        .WithMany("TkbDatas")
                        .HasForeignKey("IdLopHoc")
                        .HasConstraintName("FK_Tkb_LopHoc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartClassAPI.Data.MonHoc", "MonHoc")
                        .WithMany("TkbDatas")
                        .HasForeignKey("IdMonHoc")
                        .HasConstraintName("FK_Tkb_MonHoc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartClassAPI.Data.PhongHocData", "PhongHocData")
                        .WithMany("TkbDatas")
                        .HasForeignKey("IdPhongHoc")
                        .HasConstraintName("FK_Tkb_PhongHoc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartClassAPI.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser");

                    b.Navigation("LopHoc");

                    b.Navigation("MonHoc");

                    b.Navigation("PhongHocData");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartClassAPI.Data.User", b =>
                {
                    b.HasOne("SmartClassAPI.Data.LoaiUserData", "LoaiUserData")
                        .WithMany()
                        .HasForeignKey("IdLoai");

                    b.HasOne("SmartClassAPI.Data.LopHoc", "LopHoc")
                        .WithMany("Users")
                        .HasForeignKey("IdLopHoc");

                    b.Navigation("LoaiUserData");

                    b.Navigation("LopHoc");
                });

            modelBuilder.Entity("SmartClassAPI.Data.LopHoc", b =>
                {
                    b.Navigation("MonHocs");

                    b.Navigation("TkbDatas");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("SmartClassAPI.Data.MonHoc", b =>
                {
                    b.Navigation("TkbDatas");
                });

            modelBuilder.Entity("SmartClassAPI.Data.PhongHocData", b =>
                {
                    b.Navigation("MonHocs");

                    b.Navigation("TkbDatas");
                });
#pragma warning restore 612, 618
        }
    }
}
