using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LTCSDL_WebThuVien.Models
{
    public partial class dbWebThuVienContext : DbContext
    {
        public dbWebThuVienContext()
        {
        }

        public dbWebThuVienContext(DbContextOptions<dbWebThuVienContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<LoaiSach> LoaiSach { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<Sach> Sach { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=KATANA;Database=dbWebThuVien;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHoaDon>(entity =>
            {
                entity.HasKey(e => new { e.MaHd, e.MaSach })
                    .HasName("PK_ChiTietDonHang");

                entity.Property(e => e.MaHd).HasColumnName("MaHD");

                entity.Property(e => e.MaSach)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.ChiTietHoaDon)
                    .HasForeignKey(d => d.MaHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTHD_HD");

                entity.HasOne(d => d.MaSachNavigation)
                    .WithMany(p => p.ChiTietHoaDon)
                    .HasForeignKey(d => d.MaSach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietHoaDon_MaSach");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHd);

                entity.Property(e => e.MaHd).HasColumnName("MaHD");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NgayGiao).HasColumnType("datetime");

                entity.Property(e => e.NgayLapHd)
                    .HasColumnName("NgayLapHD")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK_HoaDon_KhachHang");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK_HoaDon_NhanVien");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh);

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Ho).HasMaxLength(20);

                entity.Property(e => e.SoDienThoai).HasMaxLength(11);

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<LoaiSach>(entity =>
            {
                entity.HasKey(e => e.MaLoaiSach);

                entity.Property(e => e.MaLoaiSach)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TenLoaiSach)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv);

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Cmnd)
                    .HasColumnName("CMND")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.Ho)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.NgaySinh).HasMaxLength(50);

                entity.Property(e => e.SoDienThoai).HasMaxLength(50);

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.HasKey(e => e.MaSach);

                entity.Property(e => e.MaSach)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DonViTinh).HasMaxLength(50);

                entity.Property(e => e.MaLoaiSach)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NhaXuatBan).HasMaxLength(50);

                entity.Property(e => e.TenSach).HasMaxLength(100);

                entity.HasOne(d => d.MaLoaiSachNavigation)
                    .WithMany(p => p.Sach)
                    .HasForeignKey(d => d.MaLoaiSach)
                    .HasConstraintName("FK_Sach_MaLoaiSach");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
