using EF_02.IServices;
using EF_02.Services;

void Main()
{
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    Console.InputEncoding = System.Text.Encoding.UTF8;
    IDuAnService duAnService = new DuAnService();
    INhanVienService nhanVienService = new NhanVienService();
    IPhanCongService phanCongService = new PhanCongService();

    Console.WriteLine("------------------------------QUẢN LÝ NHÂN VIÊN(EF-02)------------------------------");
    Console.WriteLine("1. Thêm nhân viên");
    Console.WriteLine("2. Sửa dự án");
    Console.WriteLine("3. Xóa nhân viên");
    Console.WriteLine("4. Tính lương cho nhân viên");
    Console.WriteLine("5. Thoát chương trình");
    Console.WriteLine();
    string choice;
    do
    {
        Console.WriteLine();
        Console.Write("Chọn chức năng(1-5): ");
        choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                nhanVienService.ThemNhanVien();
                break;
            case "2":
                duAnService.SuaDuAn();
                break;
            case "3":
                nhanVienService.XoaNhanVien();
                break;
            case "4":
                phanCongService.TinhLuong();
                break;
            case "5":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                break;
        }
    } while (choice != "5");
}
Main();