using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhanVienAPI.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "nhanvienrikkei",
                columns: table => new
                {
                    MaNV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoCMND = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ngaybatdau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hesoluong = table.Column<float>(type: "real", nullable: true),
                    Chucvu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trinhdohocvan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nguoiquanly = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maduan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanvienrikkei", x => x.MaNV);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "nhanvienrikkei");
        }
    }
}
