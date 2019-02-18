﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Hospital.Models;
using Hospital.ViewModels;

namespace Hospital.Util

{
    public class CustomPasswordValidator : IPasswordValidator<User>
    {
        public int RequiredLength { get; set; } //минимальная длина

        public CustomPasswordValidator(int length)
        {
            RequiredLength = length;
        }

        public Task<IdentityResult> ValidateAsync
            (UserManager<User> manager, User user, string password)
        {
            List<IdentityError> errors = new List<IdentityError>();
            if (string.IsNullOrEmpty(password) || password.Length < RequiredLength)
            {
                errors.Add(new IdentityError
                {
                    Description = string.Format("Минимальная длина пароля равна {0}", RequiredLength)
                });
            }
            string pattern = "^[0-9]+$";

            if (!Regex.IsMatch(password, pattern))
            {
                errors.Add(new IdentityError
                {
                    Description = "Пароль должен состоять только из цифр"
                });
            }
            return Task.FromResult(errors.Count == 0 ?
                IdentityResult.Success : IdentityResult.Failed(errors.ToArray()));
        }


    }
}
