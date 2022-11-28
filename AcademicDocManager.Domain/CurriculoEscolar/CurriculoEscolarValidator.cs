using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicDocManager.Domain.CurriculoEscolar
{
    internal class CurriculoEscolarValidator : AbstractValidator<CurriculoEscolar>
    {
        public CurriculoEscolarValidator()
        {
            RuleFor(curriculo => curriculo.CodigoCurriculo).Length(1);
        }
    }
}
