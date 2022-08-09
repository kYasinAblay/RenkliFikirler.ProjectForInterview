using System.ComponentModel.DataAnnotations;

namespace RenkliFikirler.MainProject.ViewModels
{
    public class RoleViewModel
    {
        [Display(Name = "Role ismi")]
        [Required(ErrorMessage = "Role ismi gereklidir")]
        public string Name { get; set; }

        public string Id { get; set; }
    }
}