using Đồ_án.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án.Controllers
{
    class LoginController
    {
        public static bool checkExistLanhDao(string mald, string mk)
        {
            using (var _context = new DoanLTWEntities())
            {
                var ld = from u in _context.LanhDaos
                         where u.TaiKhoan == mald && u.MatKhau == mk
                         select u;
                if (ld.Count() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
