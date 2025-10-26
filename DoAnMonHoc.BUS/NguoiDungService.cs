using DoAnMonHoc.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnMonHoc.BUS
{
    public class NguoiDungService
    {
        private readonly PhuTungContextDB _context;

        public NguoiDungService()
        {
            _context = new PhuTungContextDB();
        }

        // Lấy tất cả người dùng
        public List<NguoiDung> GetAllNguoiDung()
        {
            return _context.NguoiDungs.ToList();
        }

        // Lấy người dùng theo mã
        public NguoiDung GetNguoiDungByMaND(string maND)
        {
            return _context.NguoiDungs.Find(maND);
        }

        // Kiểm tra đăng nhập
        public NguoiDung DangNhap(string maND, string matKhau)
        {
            return _context.NguoiDungs
                .FirstOrDefault(nd => nd.MaND == maND && nd.MatKhau == matKhau);
        }

        // Thêm người dùng mới
        public bool ThemNguoiDung(NguoiDung nguoiDung)
        {
            try
            {
                if (_context.NguoiDungs.Any(nd => nd.MaND == nguoiDung.MaND))
                    return false; // Mã người dùng đã tồn tại

                _context.NguoiDungs.Add(nguoiDung);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Cập nhật thông tin người dùng
        public bool CapNhatNguoiDung(NguoiDung nguoiDung)
        {
            try
            {
                var existing = _context.NguoiDungs.Find(nguoiDung.MaND);
                if (existing == null)
                    return false;

                // Cập nhật các trường (trừ MaND - không được sửa)
                existing.HoTen = nguoiDung.HoTen;
                existing.SDT = nguoiDung.SDT;
                existing.Email = nguoiDung.Email;
                existing.Admin = nguoiDung.Admin;

                // Chỉ cập nhật mật khẩu nếu có giá trị mới (không bắt buộc phải đổi mật khẩu)
                if (!string.IsNullOrEmpty(nguoiDung.MatKhau))
                    existing.MatKhau = nguoiDung.MatKhau;

                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Xóa người dùng (chỉ xóa nếu không có hóa đơn/phieu nhap liên quan)
        public bool XoaNguoiDung(string maND)
        {
            try
            {
                var nguoiDung = _context.NguoiDungs.Find(maND);
                if (nguoiDung == null)
                    return false;

                // Kiểm tra ràng buộc: nếu có hóa đơn hoặc phiếu nhập thì không cho xóa
                if (nguoiDung.HoaDons.Any() || nguoiDung.DonDatHangs.Any())
                    return false;

                _context.NguoiDungs.Remove(nguoiDung);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Tìm kiếm người dùng theo tên hoặc mã
        public List<NguoiDung> TimKiemNguoiDung(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
                return _context.NguoiDungs.ToList();

            return _context.NguoiDungs
                .Where(nd => nd.MaND.Contains(tuKhoa) ||
                             (nd.HoTen != null && nd.HoTen.Contains(tuKhoa)) ||
                             (nd.Email != null && nd.Email.Contains(tuKhoa)) ||
                             (nd.SDT != null && nd.SDT.Contains(tuKhoa)))
                .ToList();
        }

        // Lấy danh sách admin
        public List<NguoiDung> GetAdmins()
        {
            return _context.NguoiDungs.Where(nd => nd.Admin).ToList();
        }

        // Kiểm tra quyền admin
        public bool IsAdmin(string maND)
        {
            var nguoiDung = _context.NguoiDungs.Find(maND);
            return nguoiDung?.Admin ?? false;
        }

        // Giải phóng tài nguyên
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
