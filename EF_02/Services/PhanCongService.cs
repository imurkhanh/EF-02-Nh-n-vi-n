using EF_02.Entity;
using EF_02.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02.Services
{
    public class PhanCongService : IPhanCongService
    {
        private readonly AppDbContext DbContext;

        public PhanCongService()
        {
            DbContext = new AppDbContext();
        }
        public double TinhLuong()
        {
            Console.WriteLine("Nhập nhân viên ID cần tính lương: ");
            int nhanVienId = int.Parse(Console.ReadLine());
            var nhanVien = DbContext.NhanVien.Find(nhanVienId);
            double result = 0;
            if (nhanVien != null)
            {
                var phanCong = DbContext.PhanCong.Find(nhanVienId);
                result += SoGioLamCua1DuAn(phanCong.NhanVienId) * nhanVien.HeSoLuong * 15;
            }
            return result;
        }
        private int SoGioLamCua1DuAn(int nVId)
        {
            var sum = DbContext.PhanCong.Where(x => x.NhanVienId == nVId).Sum(x => x.SoGioLam);
            return sum;
        }
    }
}
