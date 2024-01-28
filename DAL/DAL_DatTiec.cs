using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DatTiec : DataProvider
    {
        public DAL_DatTiec() { }

        public List<DTO_DatTiec> GetAll()
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                return context.DatTiecs
                    .Where(c => c.TrangThai != "Da Xoa" || c.TrangThai == null)
                    .Select(c => new DTO_DatTiec
                    {
                        MaTiec = c.MaTiec,
                        LoaiHinhTiec = c.LoaiHinhTiec,
                        NgayDatTiec = c.NgayDatTiec,
                        NgayToChuc = c.NgayToChuc,
                        ThoiGianToChuc = c.ThoiGianToChuc,
                        SoLuongBanChinhThuc = c.SoLuongBanChinhThuc,
                        SoLuongBanTang = c.SoLuongBanTang,
                        SoLuongBanChay = c.SoLuongBanChay,
                        SoLuongBanDuPhong=c.SoLuongBanDuPhong,
                        TongBanSetup=c.TongBanSetup,
                        LoaiBan= c.LoaiBan,
                        PhiDichVu = (float)c.PhiDichVu,
                        TongTienDuKien=(float)c.TongTienDuKien,
                        TongTienGiam =(float)c.TongTienGiam,
                        TongTienPhaiTra = (float)c.TongTienPhaiTra,
                        TienCocLan1=(float)c.TienCocLan1,
                        TienCocLan2=(float)c.TienCocLan2,
                        GhiChu=c.GhiChu,
                        MaKhachHang=c.MaKhachHang,
                        TrangThai=c.TrangThai,

                    }).ToList();
            }
        }
        public DTO_DatTiec GetByID(string ma)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.DatTiecs.FirstOrDefault(c => c.MaTiec == ma);
                if (item != null)
                {
                    DTO_DatTiec dto = new DTO_DatTiec(item.MaTiec,
                        item.LoaiHinhTiec,
                        item.NgayDatTiec,
                        item.NgayToChuc,
                        item.ThoiGianToChuc,
                        item.SoLuongBanChinhThuc,
                        item.SoLuongBanTang,
                        item.SoLuongBanChay,
                        item.SoLuongBanDuPhong,
                        item.TongBanSetup,
                        item.LoaiBan,
                        (float)item.PhiDichVu,
                        (float)item.TongTienDuKien,
                        (float)item.TongTienGiam,
                        (float)item.TongTienPhaiTra,
                        (float)item.TienCocLan1,
                        (float)item.TienCocLan2,
                        item.GhiChu,
                        item.MaKhachHang,
                        item.TrangThai);
                    return dto;
                }
                return null;
            }
        }

        public bool KiemTraID(string ma)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.DatTiecs.FirstOrDefault(c => c.MaTiec == ma);
                if (item != null)
                {
                    return true;
                }
                return false;
            }
        }

        public void Add(DTO_DatTiec dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = new DatTiec
                {
                    MaTiec = dto.MaTiec,
                    LoaiHinhTiec = dto.LoaiHinhTiec,
                    NgayDatTiec = (DateTime)dto.NgayDatTiec,
                    NgayToChuc = dto.NgayToChuc,
                    ThoiGianToChuc = dto.ThoiGianToChuc,
                    SoLuongBanChinhThuc = (int)dto.SoLuongBanChinhThuc,
                    SoLuongBanTang = (int)dto.SoLuongBanTang,
                    SoLuongBanChay = (int)dto.SoLuongBanChay,
                    SoLuongBanDuPhong = (int)dto.SoLuongBanDuPhong,
                    TongBanSetup = (int)dto.TongBanSetup,
                    LoaiBan = dto.LoaiBan,
                    PhiDichVu = (float)dto.PhiDichVu,
                    TongTienDuKien = (float)dto.TongTienDuKien,
                    TongTienGiam = (float)dto.TongTienGiam,
                    TongTienPhaiTra = (float)dto.TongTienPhaiTra,
                    TienCocLan1 = (float)dto.TienCocLan1,
                    TienCocLan2 = (float)dto.TienCocLan2,
                    GhiChu = dto.GhiChu,
                    MaKhachHang = dto.MaKhachHang,
                    TrangThai = dto.TrangThai,
                };

                context.DatTiecs.InsertOnSubmit(item);
                context.SubmitChanges();
            }
        }

        public void Update(DTO_DatTiec dto)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.DatTiecs.SingleOrDefault(c => c.MaTiec == dto.MaTiec);
                if (item != null)
                {
                    item.MaTiec = dto.MaTiec;
                    item.LoaiHinhTiec = dto.LoaiHinhTiec;
                    item.NgayDatTiec = (DateTime)dto.NgayDatTiec;
                    item.NgayToChuc = dto.NgayToChuc;
                    item.ThoiGianToChuc = dto.ThoiGianToChuc;
                    item.SoLuongBanChinhThuc = (int)dto.SoLuongBanChinhThuc;
                    item.SoLuongBanTang = (int)dto.SoLuongBanTang;
                    item.SoLuongBanChay = (int)dto.SoLuongBanChay;
                    item.SoLuongBanDuPhong = (int)dto.SoLuongBanDuPhong;
                    item.TongBanSetup = (int)dto.TongBanSetup;
                    item.LoaiBan = dto.LoaiBan;
                    item.PhiDichVu = (float)dto.PhiDichVu;
                    item.TongTienDuKien = (float)dto.TongTienDuKien;
                    item.TongTienGiam = (float)dto.TongTienGiam;
                    item.TongTienPhaiTra = (float)dto.TongTienPhaiTra;
                    item.TienCocLan1 = (float)dto.TienCocLan1;
                    item.TienCocLan2 = (float)dto.TienCocLan2;
                    item.GhiChu = dto.GhiChu;
                    item.MaKhachHang = dto.MaKhachHang;
                    item.TrangThai = dto.TrangThai;
                    context.SubmitChanges();
                }
            }
        }

        public void Delete(string ma)
        {
            using (var context = new DB_WeddingRestaurantDataContext(connectionString))
            {
                var item = context.DatTiecs.SingleOrDefault(c => c.MaTiec == ma);
                if (item != null)
                {
                    item.TrangThai = "Da Xoa";
                    context.SubmitChanges();
                }
            }
        }
    }
}

