using System.ComponentModel.DataAnnotations;

namespace Lab_2.Models.ViewModels
{
    public class RoleViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Tên vai trò là bắt buộc.")]
        [StringLength(256, ErrorMessage = "Tên vai trò không được vượt quá 256 ký tự.")]
        public string Name { get; set; }
    }
}
