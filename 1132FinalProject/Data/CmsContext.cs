using Microsoft.EntityFrameworkCore;
using _1132FinalProject.Models;
using System;
namespace _1132FinalProject.Data
{
    public class CmsContext : DbContext
    {
        public CmsContext(DbContextOptions<CmsContext> options) : base(options) { }

        //不同資料表就再複製一行修改
        public DbSet<NewMembersModel> Table_s1121768_NewMembers { get; set; }
        public DbSet<ContactCommitteesModel> Table_s1121768_CommitteeMembers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 以下開始修改專案為本機DB, 先呼叫 base，保持EF Core
            base.OnModelCreating(modelBuilder);

            // 新生資料假資料
            modelBuilder.Entity<NewMembersModel>().HasData(
                new NewMembersModel
                {
                    StuId = "1191700",
                    Name = "小王",
                    NickName = "Alex",
                    Department = "資管系",
                    Section = "Locking",
                    IG_Account = "@Wang_1700",
                    RegisteredAt = new DateTime(2024, 01, 01)
                },
                new NewMembersModel
                {
                    StuId = "1191701",
                    Name = "小李",
                    NickName = "Bob",
                    Department = "資工系",
                    Section = "Popping",
                    IG_Account = "@Lee_1700",
                    RegisteredAt = new DateTime(2024, 01, 02)
                },
                new NewMembersModel
                {
                    StuId = "1191702",
                    Name = "查理",
                    NickName = "Charlie",
                    Department = "企管系",
                    Section = "Breaking",
                    IG_Account = "@Char_1700",
                    RegisteredAt = new DateTime(2024, 01, 03)
                }
            );

            // 幹部假資料
            modelBuilder.Entity<ContactCommitteesModel>().HasData(
                new ContactCommitteesModel
                {
                    CommitteeId = 1181700,
                    NickName = "Pizza",
                    Position = "教學長",
                    Section = "Locking",
                    IG_Account = "dancer_pizza",
                    PhotoUrl = "~/Images/CommitteeCard/Spongebob.png"
                },
                new ContactCommitteesModel
                {
                    CommitteeId = 1181701,
                    NickName = "章魚哥",
                    Position = "社長",
                    Section = "Locking",
                    IG_Account = "@SquidWard",
                    PhotoUrl = "~/Images/CommitteeCard/Squidward.png"
                },
                new ContactCommitteesModel
                {
                    CommitteeId = 1181702,
                    NickName = "珊迪",
                    Position = "教學長",
                    Section = "Jazz",
                    IG_Account = "@Sandy",
                    PhotoUrl = "/Images/CommitteeCard/Sandy.png"
                },
                new ContactCommitteesModel
                {
                    CommitteeId = 1181703,
                    NickName = "派大星",
                    Position = "活動長",
                    Section = "Popping",
                    IG_Account = "@Patrick",
                    PhotoUrl = "/Images/CommitteeCard/Patrick.png"
                },
                new ContactCommitteesModel
                {
                    CommitteeId = 1181704,
                    NickName = "皮老闆",
                    Position = "副社長",
                    Section = "Breaking",
                    IG_Account = "@Plankton",
                    PhotoUrl = "~/Images/CommitteeCard/Plankton.png"
                },
                new ContactCommitteesModel
                {
                    CommitteeId = 1181705,
                    NickName = "蟹老闆",
                    Position = "總務長",
                    Section = "hiphop",
                    IG_Account = "@Mr_Krab",
                    PhotoUrl = "~/Images/CommitteeCard/Krab.png"
                }
            );
        }
    }
}
