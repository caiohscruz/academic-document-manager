using System;

public class CurriculoEscolar
{
	public string CodigoCurriculo { get; }

    public System.DateTime DataCurriculo { get; }

    public uint MinutosRelogioDaHoraAula { get; }

    public string NomeParaAreas { get; }


    public CurriculoEscolar(string codigoCurriculo)
	{
		CodigoCurriculo= codigoCurriculo;
	}
}
