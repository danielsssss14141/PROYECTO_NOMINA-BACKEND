﻿using System;
using System.Collections.Generic;

namespace NOMIN.Models;

public partial class Motivoscambioscargo
{
    public int Secuencia { get; set; }

    public int Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Vigenciascargo> Vigenciascargos { get; set; } = new List<Vigenciascargo>();
}
