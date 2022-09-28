using System;
using System.ComponentModel.DataAnnotations;

namespace NhanVienAPI.Models
{
    public class NhanVien
    {
        [Key]
        public string? MaNV { get; set; }
        public string? HoTen { get; set; }
        public string? GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
//        public Genre? Genre { get; set; }
        public string? SoCMND { get; set; }
        public DateTime Ngaybatdau { get; set; }
        public float? Hesoluong { get; set; }
        public string? Chucvu { get; set; }
        public string? Trinhdohocvan { get; set; }
        public string? Nguoiquanly { get; set; }
        public string? Maduan { get; set; }
    }
}

