using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LTCSDL_WebThuVien.Models
{
    public partial class ChiTietHoaDon
    {
        public int MaHd { get; set; }
        public string MaSach { get; set; }
        public short? SoLuong { get; set; }
        public float? DonGiaBan { get; set; }
        public float? GiamGia { get; set; }

        public virtual HoaDon MaHdNavigation { get; set; }
        public virtual Sach MaSachNavigation { get; set; }
    }
}
