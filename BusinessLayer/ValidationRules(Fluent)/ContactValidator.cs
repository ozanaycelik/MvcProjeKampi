using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules_Fluent_
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail adresini boş geçemezsiniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adını Boş Geçemezsiniz");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adını boş geçemezsiniz");

            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karekter girişi yapın");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Lütfen en az 3 karekter girişi yapın");
            RuleFor(x => x.Subject).MaximumLength(51)
                .WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayınız");


        }
    }
}
