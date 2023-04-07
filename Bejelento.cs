using System;
using System.Collections.Generic;

namespace KucseraCsabaVizsgaWeb;

public partial class Bejelento
{
    public int Id { get; set; }

    public string Iranyszam { get; set; } = null!;

    public string Varos { get; set; } = null!;

    public string Cim { get; set; } = null!;

    public DateTime Datum { get; set; }
}
