using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace UserManager.Models
{
    public class User
    {
        public int ID { get; set; }

        //độ dài tên
        [StringLength(60, MinimumLength = 3)]
        public string FirstName { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string LastName { get; set; }

        //format birthday
        [Display(Name = "BirthDay")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime BirthDay { get; set; }

        //format password
        [StringLength(30, MinimumLength = 3)]
        public string Job { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Address { get; set; }
    }

    public class UserDataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}