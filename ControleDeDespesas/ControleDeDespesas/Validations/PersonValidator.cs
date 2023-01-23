using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeDespesas.Domain.Models;
using FluentValidation;

namespace ControleDeDespesas.Validations
{
    public class PersonValidator : AbstractValidator<Person>
    {
        PersonValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Document).NotEmpty();
            RuleFor(x => x.Document).Must(IsValidCPF);
        }

        private bool IsValidCPF(string document){
            ///
            return true;
        }
    }
}