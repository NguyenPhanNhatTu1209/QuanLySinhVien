using Đồ_án.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án.Controllers
{
    class GiaoVienController
    {

        
        public static bool ThemGV (GiaoVien giaovien)
        {

            using (var _context = new DoanLTWEntities())
            {
                foreach (var detai in giaovien.DeTais)
                {
                    var dbdetai = (from u in _context.DeTais
                                   where u.MaDT == detai.MaDT
                                   select u).Single();
                    
                    dbdetai.GiaoVien = giaovien;
                }
                giaovien.DeTais.Clear();
                _context.GiaoViens.Add(giaovien);
                _context.SaveChanges();


                
                return true;

            }
            
        }
        public static bool UpdateGiaoVien(GiaoVien giaovien)
        {

            using (var _context = new DoanLTWEntities())
            {

                var giaoviendb = (from u in _context.GiaoViens
                                  where u.MaGV == giaovien.MaGV
                                  select u).Single();
                giaoviendb.DeTais.Clear();
                foreach (var i in giaovien.DeTais)
                {
                    var detai = (from u in _context.DeTais
                                 where u.MaDT == i.MaDT
                                 select u).Single();
                    giaoviendb.DeTais.Add(detai);
                }

                giaovien.DeTais.Clear();
                _context.GiaoViens.AddOrUpdate(giaovien);
                _context.SaveChanges();
                return true;
            }
        }
       
        public static List<GiaoVien> danhsachGV()
        {
            using (var _context = new DoanLTWEntities())
            {
                var giaovien = (from gv in _context.GiaoViens.AsEnumerable()
                            select gv)
                            .Select(x => new GiaoVien
                            {
                                MaGV = x.MaGV,
                                HoTen = x.HoTen,
                                GioiTinh = x.GioiTinh,
                                SDT = x.SDT,
                                Email = x.Email,
                                DeTais = x.DeTais,
                                MatKhau = x.MatKhau
                            }).ToList();
                return giaovien;
            }
        }
        
        
        public static bool checkExistGiaoVien(string magv)
        {
            using (var _context = new DoanLTWEntities())
            {
                var gv = from u in _context.GiaoViens
                            where u.MaGV == magv
                            select u;
                if (gv.Count() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool checkExistGiaoVien(string magv,string mk)
        {
            using (var _context = new DoanLTWEntities())
            {
                var gv = from u in _context.GiaoViens
                         where u.MaGV == magv && u.MatKhau == mk
                         select u;
                if (gv.Count() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }



        public static bool DeleteGiaoVien(GiaoVien giaovien)
        {
            using (var _context = new DoanLTWEntities())
            {
                //Xóa list giao vien
                var dbgiaovien = (from u in _context.GiaoViens
                                  where u.MaGV == giaovien.MaGV
                                  select u).SingleOrDefault();
                foreach (var detai in dbgiaovien.DeTais)
                {
                    var detaidb = (from u in _context.DeTais
                                   where u.MaDT == detai.MaDT
                                   select u).Single();
                }
                _context.GiaoViens.Remove(dbgiaovien);
                _context.SaveChanges();
                
                return true;
            }
        }
        public static int demdetai(string magv)
        {
            using (var _context = new DoanLTWEntities())
            {
                var giaovien = (from u in _context.GiaoViens
                             where u.MaGV == magv
                             select u).Single();
                if (giaovien.DeTais.Count() >= 1)
                {
                    return giaovien.DeTais.Count();
                }
                else
                {
                    return 0;
                }
            }
        }
        public static GiaoVien getExistGV(string magv)
        {
            using (var _context = new DoanLTWEntities())
            {
                var giaovien = from u in _context.GiaoViens
                            where u.MaGV == magv
                            select u;
                if (giaovien.Count() == 1)
                {
                    return giaovien.Single();
                }
                else
                {
                    return null;
                }
            }
        }
        
        public static List<DeTai> danhsach(string magv)
        {
            using (var _context = new DoanLTWEntities())
            {
                var giaovien = (from u in _context.GiaoViens
                             where u.MaGV == magv
                             select u).Single();
                if (giaovien.DeTais.Count() >= 1)
                {
                    return giaovien.DeTais.ToList();
                }
                else
                {
                    return null;
                }
            }
        }
        public static List<GiaoVien> TimKiemGV(string MaGVSearch, string TenGVSearch)
        {
            using (var _context = new DoanLTWEntities())
            {
                var giaovien = (from gv in _context.GiaoViens.AsEnumerable()
                                where gv.MaGV.Contains(MaGVSearch) && gv.HoTen.Contains(TenGVSearch)
                                select gv)
                            .Select(x => new GiaoVien
                            {
                                MaGV = x.MaGV,
                                HoTen = x.HoTen,
                                GioiTinh = x.GioiTinh,
                                SDT = x.SDT,
                                Email = x.Email,
                                DeTais = x.DeTais,
                                MatKhau = x.MatKhau
                            }).ToList();
                return giaovien;
            }
        }



    }
}
