using Microsoft.AspNetCore.Identity;
using System;

namespace RenkliFikirler.Repository;
public class AppUser : IdentityUser
    {public int Id { get; set; }
        public string City { get; set; }

        public string Picture { get; set; }
        public DateTime? BirthDay { get; set; }
        public int Gender { get; set; }
    }
