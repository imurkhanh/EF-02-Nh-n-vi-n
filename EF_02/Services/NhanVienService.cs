using EF_02.Entity;
using EF_02.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02.Services
{
    public class NhanVienService : INhanVienService
    {
        private readonly AppDbContext DbContext;

        public NhanVienService()
        {
            DbContext = new AppDbContext();
        }
        public void ThemNhanVien()
        {
            Console.WriteLine("Họ tên: ");
            string hoTen = Console.ReadLine();
            Console.WriteLine("Số điện thoại: ");
            string sDT = Console.ReadLine();
            Console.WriteLine("Địa chỉ: ");
            string diaChi = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Hệ số lương: ");
            double heSoLuong = double.Parse(Console.ReadLine());

            var themNhanVien = new NhanVien
            {
                HoTen=hoTen,
                SDT=sDT,
                DiaChi=diaChi,
                Email=email,
                HeSoLuong=heSoLuong,
            };
            DbContext.Add(themNhanVien);
            DbContext.SaveChanges();
        }

        public void XoaNhanVien()
        {
            Console.WriteLine("Nhập nhân viên ID cần xóa: ");
            int nhanVienId = int.Parse(Console.ReadLine());
            var nhanVien = DbContext.NhanVien.Find(nhanVienId);
            if( nhanVien != null )
            {
                DbContext.Remove(nhanVien);
                DbContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("Không tồn tại nhân viên cần xóa");
            }
        }
    }
}
