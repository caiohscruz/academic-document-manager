using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicDocManager.Domain.Entitities
{
    public class IESEmissora
    {
        public string Nome { get; }
        public uint CodigoMEC { get; }
        public string CNPJ { get; }
        public TEndereco Endereco { get; }
        public TAtoRegulatorioComOuSemEMEC Credenciamento { get; }
        public TAtoRegulatorioComOuSemEMEC Recredenciamento { get; }
        public TAtoRegulatorioComOuSemEMEC RenovacaoDeRecredenciamento { get; }
        public TDadosIesEmissoraMantenedora Mantenedora { get; }






    }
}
