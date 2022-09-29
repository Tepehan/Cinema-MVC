using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validators
{
    public class MenuValidator : AbstractValidator<Menu>
    {
        public MenuValidator()
        {
           
            RuleFor(f => f.menuName).MaximumLength(50).WithMessage("Maximum 50 karakter olabılır");
            RuleFor(f => f.menuName).NotEmpty().WithMessage("Boş gecilmez");
            RuleFor(f => f.durum).NotEmpty().WithMessage("Boş gecilmez");



        }
    }
}
