using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LTCSDL_WebThuVien.Models
{
    public partial class Sach
    {
        public Sach()
        {
            ChiTietHoaDon = new HashSet<ChiTietHoaDon>();
        }
        [Key]
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string DonViTinh { get; set; }
        public double? GiaTien { get; set; }
        public string NhaXuatBan { get; set; }
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }
        public string MaLoaiSach { get; set; }

        public virtual LoaiSach MaLoaiSachNavigation { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }
    }
}
