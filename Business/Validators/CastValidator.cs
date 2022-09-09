using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validators
{
    public class CastValidator: AbstractValidator<CastKadro>
    {
        public CastValidator()
        {
            RuleFor(c => c.unvan).MaximumLength(20).WithMessage("Maximum 20 karakter olabılır");
            RuleFor(c => c.unvan).NotEmpty().WithMessage("Unvan adı bos gecılemez.");
            RuleFor(c => c.ad).MaximumLength(20).WithMessage("Maximum 20 karakter olabılır");
            RuleFor(c => c.soyad).MaximumLength(20).WithMessage("Maximum 20 karakter olabılır");
            RuleFor(c => c.aciklama).MaximumLength(61).WithMessage("Maximum 61 karakter olabılır");
        }
    }
}
