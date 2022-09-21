using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validators
{
    public class SalonValidator : AbstractValidator<Salon>
    {
        public SalonValidator()
        {
            RuleFor(f => f.salonAd).MaximumLength(20).WithMessage("Maximum 20 karakter olabılır");
            RuleFor(f => f.salonAd).NotEmpty().WithMessage("Boş gecilmez");
            RuleFor(f => f.konum).MaximumLength(20).WithMessage("Maximum 20 karakter olabılır");
            RuleFor(f => f.konum).NotEmpty().WithMessage("Boş gecilmez");
            RuleFor(f => f.kapasite).NotEmpty().WithMessage("Boş gecilmez");
            RuleFor(f => f.destekledigiTeknoloji).MaximumLength(20).WithMessage("Maximum 20 karakter olabılır");
            RuleFor(f => f.durum).NotEmpty().WithMessage("Boş gecilmez");
        }
    }
}
