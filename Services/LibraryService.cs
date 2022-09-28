using System;
using Microsoft.EntityFrameworkCore;
using NhanVienAPI.Data;
using NhanVienAPI.Models;

namespace NhanVienAPI.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly AppDBContext _db;

        public LibraryService(AppDBContext db)
        {
            _db = db;
        }

        #region NhanVien

        public async Task<List<NhanVien>> GetNhanViensAsync()
        {
            try
            {
                return await _db.nhanvienrikkei.ToListAsync();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<NhanVien> GetNhanVienAsync(NhanVien id)
        {
            try
            {
                return await _db.nhanvienrikkei.FindAsync(id.MaNV);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<NhanVien> AddNhanVienAsync(NhanVien nhanvien)
        {
            try
            {
                await _db.nhanvienrikkei.AddAsync(nhanvien);
                await _db.SaveChangesAsync();
                return await _db.nhanvienrikkei.FindAsync(nhanvien.MaNV); // Auto ID from DB
            }
            catch (Exception ex)
            {
                return null; // An error occured
            }
        }

        public async Task<NhanVien> UpdateNhanVienAsync(NhanVien nhanvien)
        {
            try
            {
                _db.Entry(nhanvien).State = EntityState.Modified;
                await _db.SaveChangesAsync();

                return nhanvien;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<(bool, string)> DeleteNhanVienAsync(NhanVien nhanvien)
        {
            try
            {
                var dbNhanVien = await _db.nhanvienrikkei.FindAsync(nhanvien.MaNV);

                if (dbNhanVien == null)
                {
                    return (false, "NhanVien could not be found.");
                }

                _db.nhanvienrikkei.Remove(nhanvien);
                await _db.SaveChangesAsync();

                return (true, "NhanVien got deleted.");
            }
            catch (Exception ex)
            {
                return (false, $"An error occured. Error Message: {ex.Message}");
            }
        }

        #endregion NhanVien
    }
}

