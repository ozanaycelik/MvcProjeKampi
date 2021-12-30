using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules_Fluent_
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz");

            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz");

            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karekter girişi yapın");
            RuleFor(x => x.CategoryName).MaximumLength(51)
                .WithMessage("Lütfen 51 karakterden fazla değer girişi yapmayınız");


        }
    }
}
