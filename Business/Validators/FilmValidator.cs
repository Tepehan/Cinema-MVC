using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validators
{
    public class FilmValidator:AbstractValidator<Film>
    {
        public FilmValidator()
        {
            RuleFor(f => f.filmIsim).MaximumLength(20).WithMessage("Maximum 20 karakter olabılır");
            RuleFor(f => f.filmIsim).NotEmpty().WithMessage("Boş gecilmez");
            RuleFor(f => f.ozet).MaximumLength(400).WithMessage("Maximum 400 karakter olabılır");
            RuleFor(f => f.ozet).MinimumLength(15).WithMessage("Minimum 15 karakter olabılır");
            RuleFor(f => f.ozet).NotEmpty().WithMessage("Boş gecilmez");
            RuleFor(f => f.dil).MaximumLength(13).WithMessage("Maximum 13 karakter olabılır");
            RuleFor(f => f.dil).NotEmpty().WithMessage("Boş gecilmez");
            RuleFor(f => f.sure).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(f => f.vizyonTarihi).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(f => f.destekledigiTeknolojiler).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(f => f.destekledigiTeknolojiler).MaximumLength(50).WithMessage("Maximum 50 karakter olabılır");
            RuleFor(f => f.butce).NotEmpty().WithMessage("Boş geçilemez");
           
           
           
            RuleFor(f => f.durum).NotEmpty().WithMessage("Boş geçilemez");
        }
    }
}
