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
        public NhaCungCap GetById(string maNCC)
        {
            using (var context = new PhuTungContextDB())
            {
                return context.NhaCungCaps.Find(maNCC);
            }
        }
        public void Add(NhaCungCap nhaCungCap)
        {
            using (var context = new PhuTungContextDB())
            {
                context.NhaCungCaps.Add(nhaCungCap);
                context.SaveChanges();
            }
        }
        public void Update(NhaCungCap nhaCungCap)
        {
            using (var context = new PhuTungContextDB())
            {
                context.Entry(nhaCungCap).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(string maNCC)
        {
            using (var context = new PhuTungContextDB())
            {
                var nhaCungCap = context.NhaCungCaps.Find(maNCC);
                if (nhaCungCap != null)
                {
                    context.NhaCungCaps.Remove(nhaCungCap);
                    context.SaveChanges();
                }
            }
        }
        public List<NhaCungCap> SearchByName(string keyword)
        {
            using (var context = new PhuTungContextDB())
            {
                return context.NhaCungCaps
                    .Where(ncc => ncc.TenNCC.Contains(keyword) ||
                                  ncc.MaNCC.Contains(keyword) ||
                                  ncc.DienThoai.Contains(keyword))
                    .ToList();
            }
        }
    }
}