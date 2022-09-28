using System;
using Microsoft.EntityFrameworkCore;
using NhanVienAPI.Models;

namespace NhanVienAPI.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder _builder;

        public DbInitializer(ModelBuilder builder)
        {
            _builder = builder;
        }

        public void Seed()
        {
            _builder.Entity<NhanVien>(b =>
            {
                b.HasData(new NhanVien
                {
                    MaNV = "A222",
                    HoTen = "Harry Potter",
                    GioiTinh = "Fe",
                    NgaySinh = new DateTime(1952, 05, 20),
                    SoCMND = "123456789",
                    Ngaybatdau = new DateTime(2022, 05, 20),
                    Hesoluong = 5,
                    Chucvu = "Sale",
                    Trinhdohocvan = "123456789",
                    Nguoiquanly = "nam",
                    Maduan = "P001",

                });
                b.HasData(new NhanVien
                {
                    MaNV = "A999",
                    HoTen = "Potter",
                    GioiTinh = "M",
                    NgaySinh = new DateTime(1992, 05, 20),
                    SoCMND = "123456789",
                    Ngaybatdau = new DateTime(2022, 01, 20),
                    Hesoluong = 5,
                    Chucvu = "Sale",
                    Trinhdohocvan = "Dai hoc",
                    Nguoiquanly = "nam",
                    Maduan = "P002",
                });
                b.HasData(new NhanVien
                {
                    MaNV = ("A333"),
                    HoTen = "Harry",
                    GioiTinh = "M",
                    NgaySinh = new DateTime(1982, 05, 20),
                    SoCMND = "123456789",
                    Ngaybatdau = new DateTime(2022, 01, 20),
                    Hesoluong = 5,
                    Chucvu = "Dev",
                    Trinhdohocvan = "12",
                    Nguoiquanly = "nam",
                    Maduan = "P003",
                });
            });
        }
    }
}

