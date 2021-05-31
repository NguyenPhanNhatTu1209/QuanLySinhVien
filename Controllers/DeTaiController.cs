using Đồ_án.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án.Controllers
{
    class DeTaiController
    {
        public static List<DeTai> danhsachDT()
        {
            using (var _context = new DoanLTWEntities())
            {
                var detai = (from dt in _context.DeTais.AsEnumerable()
                             select dt)
                            .Select(x => new DeTai
                            {
                                MaDT = x.MaDT,
                                TenDT = x.TenDT,
                                TienDoDT = x.TienDoDT,
                                NgayBatDau = x.NgayBatDau,
                                NgayKetThuc = x.NgayKetThuc,
                                MoTaDT = x.MoTaDT,
                                GiaoVien = x.GiaoVien,
                                SinhViens = x.SinhViens,
                                MaGV =x.MaGV,
                                NhanXet = x.NhanXet,
                                FileDeTai=x.FileDeTai
                            }).ToList();
                return detai;
            }
        }
        public static List<DeTai> danhsachDT(string dtSearch)
        {
            using (var _context = new DoanLTWEntities())
            {
                var detai = (from dt in _context.DeTais.AsEnumerable()
                             where dt.MaDT.Contains(dtSearch)
                             select dt)
                            .Select(x => new DeTai
                            {
                                MaDT = x.MaDT,
                                TenDT = x.TenDT,
                                TienDoDT = x.TienDoDT,
                                NgayBatDau = x.NgayBatDau,
                                NgayKetThuc = x.NgayKetThuc,
                                MoTaDT = x.MoTaDT,
                                GiaoVien = x.GiaoVien,
                                SinhViens = x.SinhViens,
                                MaGV = x.MaGV,
                                NhanXet = x.NhanXet,
                                FileDeTai = x.FileDeTai

                            }).ToList();
                return detai;
            }
        }
        
        public static bool ThemDT(DeTai detai)
        {
            using (var _context = new DoanLTWEntities())
            {
                foreach (var sinhvien in detai.SinhViens)
                {
                    var dbsinhvien = (from u in _context.SinhViens
                                   where u.MaSV == sinhvien.MaSV
                                   select u).Single();
                    dbsinhvien.DeTai = detai;
                }
                detai.SinhViens.Clear();
                _context.DeTais.Add(detai);
                _context.SaveChanges();
                return true;
            }

        }
        public static bool checkExistDeTai(string madt)
        {
            using (var _context = new DoanLTWEntities())
            {
                var dt = from u in _context.DeTais
                         where u.MaDT == madt
                         select u;
                if (dt.Count() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static int demsinhvien(string madt)
        {
            using (var _context = new DoanLTWEntities())
            {
                var detai = (from u in _context.DeTais
                             where u.MaDT == madt
                             select u).Single();
                if (detai.SinhViens.Count() >= 1)
                {
                    return detai.SinhViens.Count();
                }
                else
                {
                    return 0;
                }
            }
        }
        public static List<SinhVien> danhsach(string madt)
        {
            using (var _context = new DoanLTWEntities())
            {
                var detai = (from u in _context.DeTais
                                where u.MaDT == madt
                                select u).Single();
                if (detai.SinhViens.Count() >= 1)
                {
                    return detai.SinhViens.ToList();
                }
                else
                {
                    return null;
                }
            }

        }
        public static bool UpdateDeTai(DeTai detai)
        {

            using (var _context = new DoanLTWEntities())
            {

                var detaidb = (from u in _context.DeTais
                                  where u.MaDT == detai.MaDT
                                  select u).Single();
                detaidb.SinhViens.Clear();
                foreach (var i in detai.SinhViens)
                {
                    var sinhvien = (from u in _context.SinhViens
                                 where u.MaSV == i.MaSV
                                 select u).Single();
                    detaidb.SinhViens.Add(sinhvien);
                }

                detai.SinhViens.Clear();
                _context.DeTais.AddOrUpdate(detai);
                _context.SaveChanges();
                return true;
            }



        }
        public static bool DeleteDeTai(DeTai detai)
        {
            using (var _context = new DoanLTWEntities())
            {
                //Xóa list đề tài
                var dbdetai = (from u in _context.DeTais
                                  where u.MaDT == detai.MaDT
                                  select u).SingleOrDefault();
                foreach (var sinhvien in dbdetai.SinhViens)
                {
                    var sinhviendb = (from u in _context.SinhViens
                                   where u.MaSV == sinhvien.MaSV
                                   select u).Single();
                }
                _context.DeTais.Remove(dbdetai);
                _context.SaveChanges();

                return true;
            }
        }
        public static DeTai getExistDT(string madt)
        {
            using (var _context = new DoanLTWEntities())
            {
                var detai = from u in _context.DeTais
                               where u.MaDT == madt
                               select u;
                if (detai.Count() == 1)
                {
                    return detai.Single();
                }
                else
                {
                    return null;
                }
            }
        }
        public static List<DeTai> TimKiemDeTaiKhiKhongCheck(string dtSearchMaDT,string dtSearchTenDT)
        {
            using (var _context = new DoanLTWEntities())
            {
                var detai = (from dt in _context.DeTais.AsEnumerable()
                             where dt.MaDT.Contains(dtSearchMaDT) && dt.TenDT.Contains(dtSearchTenDT)
                             select dt)
                            .Select(x => new DeTai
                            {
                                MaDT = x.MaDT,
                                TenDT = x.TenDT,
                                TienDoDT = x.TienDoDT,
                                NgayBatDau = x.NgayBatDau,
                                NgayKetThuc = x.NgayKetThuc,
                                MoTaDT = x.MoTaDT,
                                GiaoVien = x.GiaoVien,
                                SinhViens = x.SinhViens,
                                MaGV = x.MaGV,
                                NhanXet = x.NhanXet,
                                FileDeTai = x.FileDeTai

                            }).ToList();
                return detai;
            }
        }
        public static List<DeTai> TimKiemDeTaiKhiCoCheck(string dtSearchMaDT, string dtSearchTenDT)
        {
            using (var _context = new DoanLTWEntities())
            {
                var detai = (from dt in _context.DeTais.AsEnumerable()
                             where dt.MaDT.Contains(dtSearchMaDT) && dt.TenDT.Contains(dtSearchTenDT) && dt.SinhViens.Count == 0
                             select dt)
                            .Select(x => new DeTai
                            {
                                MaDT = x.MaDT,
                                TenDT = x.TenDT,
                                TienDoDT = x.TienDoDT,
                                NgayBatDau = x.NgayBatDau,
                                NgayKetThuc = x.NgayKetThuc,
                                MoTaDT = x.MoTaDT,
                                GiaoVien = x.GiaoVien,
                                SinhViens = x.SinhViens,
                                MaGV = x.MaGV,
                                NhanXet = x.NhanXet,
                                FileDeTai = x.FileDeTai

                            }).ToList();
                return detai;
            }
        }
        public static List<DeTai> danhsachDTKhongCoSinhVien()
        {
            using (var _context = new DoanLTWEntities())
            {
                var detai = (from dt in _context.DeTais.AsEnumerable()
                             where dt.SinhViens.Count==0
                             select dt)
                            .Select(x => new DeTai
                            {
                                MaDT = x.MaDT,
                                TenDT = x.TenDT,
                                TienDoDT = x.TienDoDT,
                                NgayBatDau = x.NgayBatDau,
                                NgayKetThuc = x.NgayKetThuc,
                                MoTaDT = x.MoTaDT,
                                GiaoVien = x.GiaoVien,
                                SinhViens = x.SinhViens,
                                MaGV = x.MaGV,
                                NhanXet = x.NhanXet,
                                FileDeTai = x.FileDeTai
                            }).ToList();
                return detai;
            }
        }

    }
    
}
