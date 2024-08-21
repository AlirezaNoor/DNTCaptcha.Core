﻿using System.ComponentModel.DataAnnotations;

namespace DNTCaptcha.Persistence.Dto;

public class AccountViewModel
{
    [Display(Name = "User name")]
    [Required(ErrorMessage = "User name is empty")]
    public string Username { get; set; }

    [Display(Name = "Password")]
    [Required(ErrorMessage = "Password is empty")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}