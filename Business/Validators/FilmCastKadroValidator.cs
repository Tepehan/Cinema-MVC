using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validators
{
    public class FilmCastKadroValidator : AbstractValidator<FilmCastKadro>
    {
        public FilmCastKadroValidator()
        {

            RuleFor(f => f.durum).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(f => f.tarih).NotEmpty().WithMessage("Tarih seçiniz...");

        }
    }
}
