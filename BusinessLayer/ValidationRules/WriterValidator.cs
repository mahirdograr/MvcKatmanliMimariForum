using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar Adını Ve Soyadını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda Kısmını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Kategori isminin minimum uzunluğu 2 olmalı.");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Kategori isminin maksimum uzunluğu 50 olmalı.");
            RuleFor(x => x.WriterAbout).Must(x => x != null && x.ToUpper().Contains("A")).WithMessage("Hakkında kısmında en az bir a harfi içermelidir");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar Maili Boş Geçemezsiniz.");


        }
    }
}
