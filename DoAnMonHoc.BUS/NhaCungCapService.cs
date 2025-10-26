using DoAnMonHoc.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnMonHoc.BUS
{
    public class NhaCungCapService
    {
        public List<NhaCungCap> GetAll()
        {
            using (var context = new PhuTungContextDB())
            {
                return context.NhaCungCaps.ToList();
            }
        }

        // Lấy theo mã NCC
        public NhaCungCap GetById(string maNCC)
        {
            using (var context = new PhuTungContextDB())
            {
                return context.NhaCungCaps.FirstOrDefault(n => n.MaNCC == maNCC);
            }
        }

        // Thêm NCC
        public bool Them(NhaCungCap ncc)
        {
            try
            {
                using (var context = new PhuTungContextDB())
                {
                    context.NhaCungCaps.Add(ncc);
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        // Cập nhật thông tin NCC
        public bool CapNhat(NhaCungCap ncc)
        {
            try
            {
                using (var context = new PhuTungContextDB())
                {
                    var existing = context.NhaCungCaps.FirstOrDefault(x => x.MaNCC == ncc.MaNCC);
                    if (existing == null) return false;

                    existing.TenNCC = ncc.TenNCC;
                    existing.DienThoai = ncc.DienThoai;
                    existing.Email = ncc.Email;

                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        // Xóa NCC
        public bool Xoa(string maNCC)
        {
            try
            {
                using (var context = new PhuTungContextDB())
                {
                    var ncc = context.NhaCungCaps.FirstOrDefault(x => x.MaNCC == maNCC);
                    if (ncc == null) return false;

                    context.NhaCungCaps.Remove(ncc);
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}