using FluentValidation;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen görsel seçiniz!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Açıklama bilgisi en az 50 karakter olmalıdır!");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Açıklama bilgisi en fazla 2000 karakter olmalıdır!");
        }
    }
}
