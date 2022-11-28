using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicDocManager.Domain.Enums
{
    public static class Ato
    {
        public static string Parecer { get; } = "Parecer";
        public static string Resolucao { get; } = "Resolução";
        public static string Decreto { get; } = "Decreto";
        public static string Portaria { get; } = "Portaria";
        public static string Deliberacao { get; } = "Deliberação";
        public static string Despacho { get; } = "Despacho";
        public static string LeiFederal { get; } = "Lei Federal";
        public static string LeiEstadual { get; } = "Lei Estadual";
        public static string LeiMunicipal { get; } = "Lei Municipal";
        public static string AtoProprio { get; } = "Ato Próprio";
    }
}
