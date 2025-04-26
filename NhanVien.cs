namespace DangVanTai.Models
{
    public class NhanVien
    {
        public int MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public int MaPhongBan { get; set; }
        public PhongBan PhongBan { get; set; }
    }
}