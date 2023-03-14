using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    class CreditCardValidator : AbstractValidator<Card>
    {
        public CreditCardValidator()
        {
            RuleFor(c => c.CVV).Length(3);
            RuleFor(c => c.CardNumber).Length(12);
            RuleFor(c => c.CardDate).Must(SonKullanimKontrol).WithMessage("Son kullanım tarih formatını kontrol ediniz. mm/yyyy şeklinde olmalı");
        }
        private bool SonKullanimKontrol(DateTime sonKullanim)
        {
            try
            {
                var currentDate = DateTime.Now;
                if (sonKullanim > currentDate)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return false;
        }
    }

}
