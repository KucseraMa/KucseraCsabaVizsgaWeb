using System;
using System.Collections.Generic;

namespace KucseraCsabaVizsgaWeb;

public partial class Hibajelento
{
    public int Id { get; set; }

    public string? Iranyszam { get; set; }

    public string? Varos { get; set; }

    public string? Cim { get; set; }

    public DateTime? Datum { get; set; }
}
