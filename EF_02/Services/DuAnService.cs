using EF_02.Entity;
using EF_02.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02.Services
{
    public class DuAnService : IDuAnService
    {
        private readonly AppDbContext DbContext;

        public DuAnService()
        {
            DbContext = new AppDbContext();
        }
        public void SuaDuAn()
        {
            Console.WriteLine("Nhập dự án ID: ");
            int duAnId = int.Parse(Console.ReadLine());
            var duAn = DbContext.DuAn.Find(duAnId);
            if(duAn != null )
            {
                Console.WriteLine("Tên dự án mới: ");
                string tenDuAn = Console.ReadLine();
                Console.WriteLine("Mô tả mới: ");
                string moTa = Console.ReadLine();
                Console.WriteLine("Ghi chú mới: ");
                string ghiChu = Console.ReadLine();

                DuAn duAnNew = new DuAn
                {
                    DuAnId = duAnId,
                    TenDuAn = tenDuAn,
                    MoTa = moTa,
                    GhiChu = ghiChu,
                };
                DbContext.Add(duAnNew);
                DbContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("Không tồn tại dự án");
            }
        }
    }
}
