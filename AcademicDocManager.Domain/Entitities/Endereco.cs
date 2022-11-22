using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicDocManager.Domain.Entitities
{
    public class Endereco
    {
        public string Logradouro { get; }
        public string Numero { get; }
        public string Complemento { get; }
        public string Bairro { get; }
        public string CodigoMunicipio { get; }
        public string NomeMunicipio { get; }
        public Uf Uf { get; }
        public string NomeMunicipioEstrangeiro { get; }
        public string Cep { get; }
    }

    public enum Uf
    {
        AC,
        AL,
        AM,
        AP,
        BA,
        CE,
        DF,
        ES,
        GO,
        MA,
        MG,
        MS,
        MT,
        PA,
        PB,
        PE,
        PI,
        PR,
        RJ,
        RN,
        RO,
        RR,
        RS,
        SC,
        SE,
        SP,
        TO,
    }
}
