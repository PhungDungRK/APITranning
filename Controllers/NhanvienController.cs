using System;
using Microsoft.AspNetCore.Mvc;
using NhanVienAPI.Models;
using NhanVienAPI.Services;

namespace NhanVienAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NhanvienController : ControllerBase
    {
        private readonly ILibraryService _libraryService;

        public NhanvienController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetNhanViens()
        {
            var books = await _libraryService.GetNhanViensAsync();
            if (books == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, "No books in database.");
            }

            return StatusCode(StatusCodes.Status200OK, books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNhanViens([FromQuery]NhanVien maNV)
        {
            NhanVien nhanvien = await _libraryService.GetNhanVienAsync(maNV);

            if (nhanvien == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, $"No book found for id: {nhanvien}");
            }

            return StatusCode(StatusCodes.Status200OK, nhanvien);
        }

        [HttpPost]
        public async Task<ActionResult<NhanVien>> AddNhanVien(NhanVien book)
        {
            var dbBook = await _libraryService.AddNhanVienAsync(book);

            if (dbBook == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{book.HoTen} could not be added.");
            }

            return CreatedAtAction("GetBook", new { id = book.MaNV }, book);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNhanVien(string id, NhanVien nhanvien)
        {
            if (id != nhanvien.MaNV)
            {
                return BadRequest("MaNV mismatch");
            }

            NhanVien dbBook = await _libraryService.UpdateNhanVienAsync(nhanvien);

            if (dbBook == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{nhanvien.MaNV} could not be updated");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNhanVien(NhanVien nhanVien)
        {
            var nhanvien = await _libraryService.GetNhanVienAsync(nhanVien);
            (bool status, string message) = await _libraryService.DeleteNhanVienAsync(nhanVien);

            if (status == false)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, message);
            }

            return StatusCode(StatusCodes.Status200OK, nhanVien);
        }
    }
}

