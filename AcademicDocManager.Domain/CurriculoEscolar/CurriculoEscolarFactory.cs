using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AcademicDocManager.Domain.CurriculoEscolar
{
    public class CurriculoEscolarFactory
    {
        CurriculoEscolarValidator _curriculoValidator = new CurriculoEscolarValidator();
        
        public string CodigoCurriculo { get; set; }

        public CurriculoEscolarFactory()
        {

        }

        public static CurriculoEscolarFactory WithCodigoCurriculo (string codigoCurriculo)
        {
            return new CurriculoEscolarFactory();
        }

    }
}
