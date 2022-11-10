﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1_DAL.Context;

#nullable disable

namespace _1_DAL.Migrations
{
    [DbContext(typeof(ManagerContext))]
    partial class ManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1_DAL.Models.ChatLieu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Ma" }, "UQ_ChatLieu")
                        .IsUnique();

                    b.ToTable("ChatLieu");
                });

            modelBuilder.Entity("_1_DAL.Models.ChiTietHangHoa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<decimal?>("GiaBan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("GiaNhap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)")
                        .HasDefaultValueSql("((0))");

                    b.Property<Guid?>("IdChatLieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdLoaiGiay")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdQuocGia")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSizeGiay")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdDongSP");

                    b.Property<Guid?>("IdSp")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdSP");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("NamBh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("NamBH")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("SoLuongTon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex("IdChatLieu");

                    b.HasIndex("IdLoaiGiay");

                    b.HasIndex("IdQuocGia");

                    b.HasIndex("IdSizeGiay");

                    b.HasIndex("IdSp");

                    b.ToTable("ChiTietSP");
                });

            modelBuilder.Entity("_1_DAL.Models.ChucVu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Ma" }, "UQ_ChucVu")
                        .IsUnique();

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("_1_DAL.Models.DanhMuc", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Ma" }, "UQ_DanhMuc")
                        .IsUnique();

                    b.ToTable("DanhMuc");
                });

            modelBuilder.Entity("_1_DAL.Models.HangHoa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<byte[]>("Anh")
                        .IsRequired()
                        .HasColumnType("image")
                        .HasColumnName("img");

                    b.Property<Guid?>("IdNsx")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdNsx");

                    b.HasIndex(new[] { "Ma" }, "UQ_SanPham")
                        .IsUnique();

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("_1_DAL.Models.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<Guid?>("IdKh")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdKH");

                    b.Property<Guid?>("IdNv")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdNV");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("NgayNhan")
                        .HasColumnType("date");

                    b.Property<DateTime?>("NgayShip")
                        .HasColumnType("date");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("date");

                    b.Property<DateTime?>("NgayThanhToan")
                        .HasColumnType("date");

                    b.Property<decimal>("Thue")
                        .HasMaxLength(50)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TinhTrang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex("IdKh");

                    b.HasIndex("IdNv");

                    b.HasIndex(new[] { "Ma" }, "UQ_HoaDon")
                        .IsUnique();

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("_1_DAL.Models.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("IdChiTietSp")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdChiTietSP");

                    b.Property<Guid>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("DonGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("SoLuong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("ThanhTien")
                        .HasColumnType("decimal(20,0)");

                    b.HasKey("IdChiTietSp", "IdHoaDon");

                    b.HasIndex("IdHoaDon");

                    b.ToTable("HoaDonChiTiet");
                });

            modelBuilder.Entity("_1_DAL.Models.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("DiemTichDiem")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("NamSinh")
                        .HasColumnType("date");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("SoCCCD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Ma" }, "UQ_KhachHang")
                        .IsUnique();

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("_1_DAL.Models.KieuDanhMuc", b =>
                {
                    b.Property<Guid?>("IdDanhMuc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdHangHoa")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenKieuDanhMuc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDanhMuc", "IdHangHoa");

                    b.HasIndex("IdHangHoa");

                    b.ToTable("KieuDanhMuc");
                });

            modelBuilder.Entity("_1_DAL.Models.LichSuDiemTieuDung", b =>
                {
                    b.Property<Guid>("IdLichSuDiem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgaySuDung")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoDiemTieuDung")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdLichSuDiem");

                    b.HasIndex("IdKhachHang");

                    b.ToTable("LichSuDiemTieuDung");
                });

            modelBuilder.Entity("_1_DAL.Models.LoaiGiay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Ma" }, "UQ_LoaiGiay")
                        .IsUnique();

                    b.ToTable("LoaiGiay");
                });

            modelBuilder.Entity("_1_DAL.Models.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<byte[]>("Anh")
                        .IsRequired()
                        .HasColumnType("image")
                        .HasColumnName("img");

                    b.Property<string>("CMND")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<Guid?>("IdCv")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdCV");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NamSinh")
                        .HasColumnType("date");

                    b.Property<string>("QueQuan")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("IdGuiBC");

                    b.HasKey("Id");

                    b.HasIndex("IdCv");

                    b.HasIndex(new[] { "Ma" }, "UQ_NhanVien")
                        .IsUnique();

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("_1_DAL.Models.Nsx", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Ma" }, "UQ_NSX")
                        .IsUnique();

                    b.ToTable("NSX");
                });

            modelBuilder.Entity("_1_DAL.Models.QuocGia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Ma" }, "UQ_QuocGia")
                        .IsUnique();

                    b.ToTable("QuocGia");
                });

            modelBuilder.Entity("_1_DAL.Models.SizeGiay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("SoSize")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(30)
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Ma" }, "UQ_SizeGiay")
                        .IsUnique();

                    b.ToTable("SizeGiay");
                });

            modelBuilder.Entity("_1_DAL.Models.ChiTietHangHoa", b =>
                {
                    b.HasOne("_1_DAL.Models.ChatLieu", "IdChatLieuNavigation")
                        .WithMany("ChiTietHangHoas")
                        .HasForeignKey("IdChatLieu");

                    b.HasOne("_1_DAL.Models.LoaiGiay", "IdMauSacNavigation")
                        .WithMany("ChiTietHangHoas")
                        .HasForeignKey("IdLoaiGiay");

                    b.HasOne("_1_DAL.Models.QuocGia", "IdQuocGiaNavigation")
                        .WithMany("HangHoaChiTiet")
                        .HasForeignKey("IdQuocGia");

                    b.HasOne("_1_DAL.Models.SizeGiay", "IdSizeNavigation")
                        .WithMany("ChiTietHangHoas")
                        .HasForeignKey("IdSizeGiay");

                    b.HasOne("_1_DAL.Models.HangHoa", "IdSpNavigation")
                        .WithMany("ChiTietSps")
                        .HasForeignKey("IdSp");

                    b.Navigation("IdChatLieuNavigation");

                    b.Navigation("IdMauSacNavigation");

                    b.Navigation("IdQuocGiaNavigation");

                    b.Navigation("IdSizeNavigation");

                    b.Navigation("IdSpNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.HangHoa", b =>
                {
                    b.HasOne("_1_DAL.Models.Nsx", "IdNsxNavigation")
                        .WithMany("HangHoas")
                        .HasForeignKey("IdNsx");

                    b.Navigation("IdNsxNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.HoaDon", b =>
                {
                    b.HasOne("_1_DAL.Models.KhachHang", "IdKhNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdKh");

                    b.HasOne("_1_DAL.Models.NhanVien", "IdNvNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdNv");

                    b.Navigation("IdKhNavigation");

                    b.Navigation("IdNvNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("_1_DAL.Models.ChiTietHangHoa", "IdChiTietSpNavigation")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdChiTietSp")
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.HoaDon", "IdHoaDonNavigation")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdHoaDon")
                        .IsRequired();

                    b.Navigation("IdChiTietSpNavigation");

                    b.Navigation("IdHoaDonNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.KieuDanhMuc", b =>
                {
                    b.HasOne("_1_DAL.Models.DanhMuc", "IdDanhMucNavigation")
                        .WithMany("KieuDanhMucs")
                        .HasForeignKey("IdDanhMuc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.HangHoa", "IdHangHoaNavigation")
                        .WithMany("KieuDanhMucs")
                        .HasForeignKey("IdHangHoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdDanhMucNavigation");

                    b.Navigation("IdHangHoaNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.LichSuDiemTieuDung", b =>
                {
                    b.HasOne("_1_DAL.Models.KhachHang", "IdKhachHangNavigation")
                        .WithMany()
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdKhachHangNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.NhanVien", b =>
                {
                    b.HasOne("_1_DAL.Models.ChucVu", "IdCvNavigation")
                        .WithMany("NhanViens")
                        .HasForeignKey("IdCv");

                    b.Navigation("IdCvNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.ChatLieu", b =>
                {
                    b.Navigation("ChiTietHangHoas");
                });

            modelBuilder.Entity("_1_DAL.Models.ChiTietHangHoa", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("_1_DAL.Models.ChucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("_1_DAL.Models.DanhMuc", b =>
                {
                    b.Navigation("KieuDanhMucs");
                });

            modelBuilder.Entity("_1_DAL.Models.HangHoa", b =>
                {
                    b.Navigation("ChiTietSps");

                    b.Navigation("KieuDanhMucs");
                });

            modelBuilder.Entity("_1_DAL.Models.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("_1_DAL.Models.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1_DAL.Models.LoaiGiay", b =>
                {
                    b.Navigation("ChiTietHangHoas");
                });

            modelBuilder.Entity("_1_DAL.Models.NhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1_DAL.Models.Nsx", b =>
                {
                    b.Navigation("HangHoas");
                });

            modelBuilder.Entity("_1_DAL.Models.QuocGia", b =>
                {
                    b.Navigation("HangHoaChiTiet");
                });

            modelBuilder.Entity("_1_DAL.Models.SizeGiay", b =>
                {
                    b.Navigation("ChiTietHangHoas");
                });
#pragma warning restore 612, 618
        }
    }
}
