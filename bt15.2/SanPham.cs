using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

// Lớp trừu tượng SanPham
abstract class SanPham
{
    private string maSanPham;

public string MaSanPham
{
    get {return maSanPham;}
    set
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            Console.WriteLine("Mã sản phẩm không thể rỗng.");
            return;
        }
        maSanPham = value;
    }
}
   private string tenSanPham;
private double giaGoc;

public string TenSanPham
{
    get { return tenSanPham; }
    set
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            Console.WriteLine("Tên sản phẩm không thể rỗng.");
            return;
        }
        tenSanPham = value;
    }
}

public double GiaGoc
{
    get { return giaGoc; }
    set
    {
        if (value < 0)
        {
            Console.WriteLine("Giá gốc không thể nhỏ hơn 0.");
            return;
        }
        giaGoc = value;
    }
}

    public abstract double TinhGiaBan();

    public virtual void HienThiThongTin()
    {
        Console.WriteLine($"Mã sản phẩm: {MaSanPham}, Tên sản phẩm: {TenSanPham}, Giá gốc: {GiaGoc:C}, Giá bán: {TinhGiaBan():C}");
    }
}

// Lớp DienTu
class DienTu : SanPham
{
    public double ThueBaoHanh { get; set; }

    public override double TinhGiaBan()
    {
        return GiaGoc + ThueBaoHanh;
    }
}

// Lớp ThoiTrang
class ThoiTrang : SanPham
{
    public double GiamGia { get; set; }

    public override double TinhGiaBan()
    {
        return GiaGoc - GiamGia;
    }
}

// Lớp ThucPham
class ThucPham : SanPham
{
    public double PhiVanChuyen { get; set; }

    public override double TinhGiaBan()
    {
        return GiaGoc + PhiVanChuyen;
    }
}

// Lớp quản lý sản phẩm
class QuanLySanPham
{
    private List<SanPham> danhSachSanPham = new List<SanPham>();

    public void ThemSanPham(SanPham sp)
    {
        danhSachSanPham.Add(sp);
        Console.WriteLine("Sản phẩm đã được thêm thành công!");
    }

    public void HienThiSanPham()
    {
        if (danhSachSanPham.Count == 0)
        {
            Console.WriteLine("Danh sách sản phẩm trống.");
            return;
        }

        foreach (var sp in danhSachSanPham)
        {
            sp.HienThiThongTin();
        }
    }

    public void XoaSanPham(string maSanPham)
    {
        var sp = danhSachSanPham.FirstOrDefault(p => p.MaSanPham == maSanPham);
        if (sp != null)
        {
            danhSachSanPham.Remove(sp);
            Console.WriteLine("Sản phẩm đã được xóa.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy sản phẩm với mã đã nhập.");
        }
    }

    public void TinhTongDoanhThu()
    {
        double tongDoanhThu = danhSachSanPham.Sum(sp => sp.TinhGiaBan());
        Console.WriteLine($"Tổng doanh thu dự kiến: {tongDoanhThu:C}");
    }
}
