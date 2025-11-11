using System.ComponentModel.DataAnnotations;

namespace _1132FinalProject.Models
{
    public class BookingViewModel
    {
        [Display(Name = "場地")]
        public string Location { get; set; }

        [Display(Name = "時間")]
        public string Time { get; set; }

        [Display(Name = "組別")]
        public string Section { get; set; }
    }
}
