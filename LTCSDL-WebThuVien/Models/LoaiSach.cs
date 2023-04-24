using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LTCSDL_WebThuVien.Models
{
    public partial class LoaiSach
    {
        public LoaiSach()
        {
            Sach = new HashSet<Sach>();
        }

        public string MaLoaiSach { get; set; }
        public string TenLoaiSach { get; set; }

        public virtual ICollection<Sach> Sach { get; set; }
    }
}
