using System.ComponentModel.DataAnnotations;

namespace _1132FinalProject.Models
{
    public class ContactCommitteesModel
    {
        [Key] public int CommitteeId { get; set; }

        [Required]
        [Display(Name = "綽號")]
        public required string NickName { get; set; }

        [Display(Name = "職位")]
        public required string Position { get; set; }

        [Display(Name = "舞風")]
        public required string Section { get; set; }

        [Display(Name = "IG帳號")]
        public required string IG_Account { get; set; }

        // 人物卡照片檔名
        public required string PhotoUrl { get; set; }
    }
}
