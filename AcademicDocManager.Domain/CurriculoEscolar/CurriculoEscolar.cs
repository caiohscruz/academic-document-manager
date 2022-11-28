namespace AcademicDocManager.Domain.CurriculoEscolar
{
    internal class CurriculoEscolar
    {
        public string CodigoCurriculo { get; }

        public System.DateTime DataCurriculo { get; }

        public uint MinutosRelogioDaHoraAula { get; }

        public string NomeParaAreas { get; }

        public CurriculoEscolar(string codigoCurriculo)
        {
            CodigoCurriculo = codigoCurriculo;
        }
    }
}
