using Đồ_án.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án.Controllers
{
    public class SinhVienController
    {

        public static bool ThemSV(SinhVien sinhvien)
        {


            using (var _context = new DoanLTWEntities())
            {
                
                
                _context.SinhViens.Add(sinhvien);
                _context.SaveChanges();
                return true;
            }


        }
        public static List<SinhVien> danhsachSV()
        {
            using (var _context = new DoanLTWEntities())
            {
                var sinhvien = (from sv in _context.SinhViens.AsEnumerable()
                                select sv)
                            .Select(x => new SinhVien
                            {
                                MaSV = x.MaSV,
                                HoTen = x.HoTen,
                                GioiTinh = x.GioiTinh,
                                SDT = x.SDT,
                                Email = x.Email,
                                Khoa = x.Khoa,
                                LopHoc = x.LopHoc,
                                NgaySinh = x.NgaySinh,
                                DiaChi = x.DiaChi,
                                MaDT = x.MaDT,
                                DeTai = x.DeTai,
                                MatKhau = x.MatKhau
                            }).ToList();
                return sinhvien;
            }
        }
        public static List<SinhVien> danhsachSV(string svSearch)
        {
            using (var _context = new DoanLTWEntities())
            {
                var sinhvien = (from sv in _context.SinhViens.AsEnumerable()
                                where sv.MaSV.Contains(svSearch)
                                select sv)
                            .Select(x => new SinhVien
                            {
                                MaSV = x.MaSV,
                                HoTen = x.HoTen,
                                GioiTinh = x.GioiTinh,
                                SDT = x.SDT,
                                Email = x.Email,
                                Khoa = x.Khoa,
                                LopHoc = x.LopHoc,
                                NgaySinh = x.NgaySinh,
                                DiaChi = x.DiaChi,
                                MaDT = x.MaDT,
                                DeTai = x.DeTai,
                                MatKhau = x.MatKhau

                            }).ToList();
                return sinhvien;
            }
        }
        public static bool UpdateSinhVien(SinhVien sinhvien)
        {
            try
            {
                using (var _context = new DoanLTWEntities())
                {
                    _context.SinhViens.AddOrUpdate(sinhvien);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool checkExistSV(string masv)
        {
            using (var _context = new DoanLTWEntities())
            {
                var sv = from u in _context.SinhViens
                         where u.MaSV == masv
                         select u;
                if (sv.Count() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool checkExistSV(string masv,string mk)
        {
            using (var _context = new DoanLTWEntities())
            {
                var sv = from u in _context.SinhViens
                         where u.MaSV == masv && u.MatKhau == mk
                         select u;
                if (sv.Count() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static SinhVien getExistSV(string masv)
        {
            using (var _context = new DoanLTWEntities())
            {
                return _context.SinhViens.Find(masv);
            }
        }
        public static DeTai danhsach(string masv)
        {
            using (var _context = new DoanLTWEntities())
            {
                var sinhvien = (from u in _context.SinhViens
                             where u.MaSV == masv
                             select u).Single();
                return sinhvien.DeTai;
            }
        }

        public static bool Deletesinhvien(SinhVien sinhvien)
        {
            using (var _context = new DoanLTWEntities())
            {
                //Xóa sinh viên
                var dbsinhvien = (from u in _context.SinhViens
                                  where u.MaSV == sinhvien.MaSV
                                  select u).SingleOrDefault();

                _context.SinhViens.Remove(dbsinhvien);
                _context.SaveChanges();

                return true;
            }
        }
        public static List<SinhVien> TimKiemSV(string svSearchMaSV, string svSearchHoTen, string svSearchKhoa, string svSearchLop)
        {
            using (var _context = new DoanLTWEntities())
            {
                var sinhvien = (from sv in _context.SinhViens.AsEnumerable()
                                where sv.MaSV.Contains(svSearchMaSV) && sv.HoTen.Contains(svSearchHoTen) && sv.Khoa.Contains(svSearchKhoa) && sv.LopHoc.Contains(svSearchLop)
                                select sv)
                            .Select(x => new SinhVien
                            {
                                MaSV = x.MaSV,
                                HoTen = x.HoTen,
                                GioiTinh = x.GioiTinh,
                                SDT = x.SDT,
                                Email = x.Email,
                                Khoa = x.Khoa,
                                LopHoc = x.LopHoc,
                                NgaySinh = x.NgaySinh,
                                DiaChi = x.DiaChi,
                                MaDT = x.MaDT,
                                DeTai = x.DeTai,
                                MatKhau = x.MatKhau

                            }).ToList();
                return sinhvien;
            }
        }
        

    }
}
