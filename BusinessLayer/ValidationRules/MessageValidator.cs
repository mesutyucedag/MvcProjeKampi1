using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator: AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("E-posta adresi boş olamaz.").EmailAddress().WithMessage("Geçersiz e-posta adresi."); RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Alanını Boş Geçemezsiniz!");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj Alanını Boş Geçemezsiniz!");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Lütfen en fazla 100 karakterlik giriş yapınız");
        }
    }
}
