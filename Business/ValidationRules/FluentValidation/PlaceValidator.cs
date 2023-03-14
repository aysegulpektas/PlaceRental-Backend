using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class PlaceValidator : AbstractValidator<Place>
    {
        public PlaceValidator()
        {
            RuleFor(p => p.PlaceName).NotEmpty();
            RuleFor(p => p.PlacePrice).NotEmpty();
            RuleFor(p => p.PlacePrice).GreaterThan(0);
        }
    }
}
