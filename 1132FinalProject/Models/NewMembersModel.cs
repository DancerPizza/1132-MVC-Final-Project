using System;
using System.ComponentModel.DataAnnotations;

namespace _1132FinalProject.Models
{
    public class NewMembersModel
    {
        [Required]
        [Display(Name = "學號")]
        [Key] public string StuId { get; set; }

        [Required]
        [Display(Name = "姓名")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "綽號")]
        public string NickName { get; set; }

        [Required]
        [Display(Name = "系所")]
        public string Department { get; set; }

        [Required]
        [Display(Name = "組別")]
        public string Section { get; set; }

        [Required]
        [Display(Name = "IG帳號")]
        public string IG_Account { get; set; }

        [Display(Name = "註冊時間")]
        public DateTime RegisteredAt { get; set; } //登記時間
    }
}
