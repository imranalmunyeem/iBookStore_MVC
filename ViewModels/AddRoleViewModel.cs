﻿using System.ComponentModel.DataAnnotations;

namespace iBookStore.ViewModels
{
    public class AddRoleViewModel

        {
            [Required]
            [Display(Name = "Role")]
            public string RoleName { get; set; }
        }
    }
