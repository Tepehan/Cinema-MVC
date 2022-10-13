using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validators
{
    public class MusteriValidator : AbstractValidator<Musteri>
    {
        public MusteriValidator()
        {
            RuleFor(f => f.ad).NotEmpty().WithMessage("Boş gecilmez");
            RuleFor(f => f.soyad).NotEmpty().WithMessage("Boş gecilmez");
            RuleFor(f => f.eMail).NotEmpty().WithMessage("Boş gecilmez");
            RuleFor(f => f.sifre).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(f => f.telefonNumara).NotEmpty().WithMessage("Boş geçilemez");
        }

    }
}
