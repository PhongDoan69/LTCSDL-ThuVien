using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LTCSDL_WebThuVien.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDon = new HashSet<HoaDon>();
        }

        public string MaNv { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public string Cmnd { get; set; }

        public virtual ICollection<HoaDon> HoaDon { get; set; }
    }
}
