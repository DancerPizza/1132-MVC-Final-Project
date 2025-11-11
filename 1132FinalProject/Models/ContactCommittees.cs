using System.ComponentModel.DataAnnotations;

namespace _1132FinalProject.Models
{
        public class ContactCommitteesModel
        {
            [Key] public int CommitteeId { get; set; }

            [Required]
            [Display(Name = "綽號")]
            public string NickName { get; set; }

            [Display(Name = "職位")]
            public string Position { get; set; }

            [Display(Name = "舞風")]
            public string Section { get; set; }

            [Display(Name = "IG帳號")]
            public string IG_Account { get; set; }

            //人物卡照片路徑
            public string PhotoUrl { get; set; }
    }
}
