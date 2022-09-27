using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validators
{
    public class SliderValidator : AbstractValidator<Slider>
    {
        public SliderValidator()
        {
            RuleFor(f => f.baslik).MaximumLength(20).WithMessage("Maximum 20 karakter olabılır");
            RuleFor(f => f.baslik).NotEmpty().WithMessage("Boş gecilmez");
            RuleFor(f => f.icerik).MaximumLength(100).WithMessage("Maximum 100 karakter olabılır");
            RuleFor(f => f.icerik).NotEmpty().WithMessage("Boş gecilmez");
            RuleFor(f => f.resimUrl).NotEmpty().WithMessage("Boş gecilmez");
          
        }



    }
}
