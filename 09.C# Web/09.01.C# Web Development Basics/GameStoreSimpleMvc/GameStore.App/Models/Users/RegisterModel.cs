﻿namespace GameStore.App.Models.Users
{
    using GameStore.App.Infrastructure.Validation.Users;
    using Infrastructure.Validation;

    public class RegisterModel
    {
        [Required]
        [Email]
        public string Email { get; set; }

        public string Name { get; set; }

        [Required]
        [Password]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }
    }
}