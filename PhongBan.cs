using System.ComponentModel.DataAnnotations;

namespace DangVanTai.Models
{
    public class PhongBan
    {
        [Key]
        public int MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }
    }
}
