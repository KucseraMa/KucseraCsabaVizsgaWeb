using System;
using System.Collections.Generic;

namespace KucseraCsabaVizsgaWeb;

public partial class Bejelento2
{
    public int BejelentoId { get; set; }

    public string Varos { get; set; } = null!;

    public string? Cim { get; set; }

    public DateTime? Date { get; set; }

    public string Iranyszam { get; set; } = null!;

    public override string ToString()
    {
        return $"Sorszám: {BejelentoId} Cím: {Iranyszam} {Varos} {Cim}  Bejelentés dátuma: {Date}";
    }

}
