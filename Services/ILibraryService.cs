using System;
using NhanVienAPI.Models;

namespace NhanVienAPI.Services
{
    public interface ILibraryService
    {
        // NhanVien Services
        Task<List<NhanVien>> GetNhanViensAsync(); // GET All NhanVien
        Task<NhanVien> GetNhanVienAsync(NhanVien id); // Get Single NhanVien
        Task<NhanVien> AddNhanVienAsync(NhanVien nhanvien); // POST New NhanVien
        Task<NhanVien> UpdateNhanVienAsync(NhanVien nhanvien); // PUT NhanVien
        Task<(bool, string)> DeleteNhanVienAsync(NhanVien nhanvien); // DELETE NhanVien
    }
}

