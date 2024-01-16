using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02.Entity
{
    public class PhanCong
    {
        public int PhanCongId { get; set; }
        public int NhanVienId { get; set; }
        public int DuAnId { get; set; }
        public int SoGioLam { get; set; }
        public NhanVien NhanVien { get; set; }
        public DuAn DuAn { get; set; }
    }
}
