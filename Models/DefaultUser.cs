﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace iBookStore.Models
{
    public class DefaultUser : IdentityUser
    {
        [PersonalData]
        [Required]
        public string FirstName { get; set; }

        [PersonalData]
        [Required]
        public string LastName { get; set; }

        [PersonalData]
        [Required]
        public string Address { get; set; }

        [PersonalData]
        [Required]
        public string ZipCode { get; set; }

        [PersonalData]
        [Required]
        public string City { get; set; }

        [PersonalData]
        [DataType(DataType.Date)]
        public DateTime UserCreationDate { get; set; } = DateTime.Now;
    }
}