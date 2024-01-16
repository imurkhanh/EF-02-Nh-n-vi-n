using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02.Entity
{
    public class NhanVien
    {
        public int NhanVienId { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public double HeSoLuong { get; set; }
    }
}
