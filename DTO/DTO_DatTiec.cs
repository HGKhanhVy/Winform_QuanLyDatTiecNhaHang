using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DatTiec
    {
        public string? MaTiec { get; set; }
        public string? LoaiHinhTiec { get; set; }
        public DateTime? NgayDatTiec { get; set; }
        public string? NgayToChuc { get; set; }
        public string? ThoiGianToChuc { get; set; }
        public int? SoLuongBanChinhThuc { get; set; }
        public int? SoLuongBanTang { get; set; }
        public int? SoLuongBanChay { get; set; }
        public int? SoLuongBanDuPhong { get; set; }
        public int? TongBanSetup { get; set; }
        public string? LoaiBan { get; set; }
        public float PhiDichVu { get; set; }
        public float? TongTienDuKien { get; set; }
        public float? TongTienGiam { get; set; }
        public float? TongTienPhaiTra { get; set; }
        public float? TienCocLan1 { get; set; }
        public float? TienCocLan2 { get; set; }
        public string? GhiChu { get; set; }
        public string? MaKhachHang { get; set; }
        public string? TrangThai { get; set; }

        public DTO_DatTiec()
        {
            
        }

        public DTO_DatTiec(string? maTiec, string? loaiHinhTiec, DateTime? ngayDatTiec, string? ngayToChuc, string? thoiGianToChuc, int? soLuongBanChinhThuc, int? soLuongBanTang, int? soLuongBanChay, int? soLuongBanDuPhong, int? tongBanSetup, string? loaiBan, float phiDichVu, float? tongTienDuKien, float? tongTienGiam, float? tongTienPhaiTra, float? tienCocLan1, float? tienCocLan2, string? ghiChu, string? maKhachHang, string? trangThai)
        {
            MaTiec = maTiec;
            LoaiHinhTiec = loaiHinhTiec;
            NgayDatTiec = ngayDatTiec;
            NgayToChuc = ngayToChuc;
            ThoiGianToChuc = thoiGianToChuc;
            SoLuongBanChinhThuc = soLuongBanChinhThuc;
            SoLuongBanTang = soLuongBanTang;
            SoLuongBanChay = soLuongBanChay;
            SoLuongBanDuPhong = soLuongBanDuPhong;
            TongBanSetup = tongBanSetup;
            LoaiBan = loaiBan;
            PhiDichVu = phiDichVu;
            TongTienDuKien = tongTienDuKien;
            TongTienGiam = tongTienGiam;
            TongTienPhaiTra = tongTienPhaiTra;
            TienCocLan1 = tienCocLan1;
            TienCocLan2 = tienCocLan2;
            GhiChu = ghiChu;
            MaKhachHang = maKhachHang;
            TrangThai = trangThai;
        }
    }
}
