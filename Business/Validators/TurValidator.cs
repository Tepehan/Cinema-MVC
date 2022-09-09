using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validators
{
    public class TurValidator: AbstractValidator<Tur>
    {
        public TurValidator()
        {
            RuleFor(t=>t.turIsim).MaximumLength(20).WithMessage("Maximum 20 karakter olabılır");           
        }
    }
}
