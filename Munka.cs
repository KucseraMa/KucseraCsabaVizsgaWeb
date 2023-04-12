using System;
using System.Collections.Generic;

namespace KucseraCsabaVizsgaWeb;

public partial class Munka
{
    public int Id { get; set; }

    public string Tipus { get; set; } = null!;

    public string Munkatars { get; set; } = null!;

    public DateTime? Idotartam { get; set; }

    public string Allapot { get; set; }

    public int BejelentoId { get; set; }

    public virtual Bejelento2 Bejelento { get; set; } = null!;
}
