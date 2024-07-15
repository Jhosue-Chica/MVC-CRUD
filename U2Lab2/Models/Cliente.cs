using System;
using System.Collections.Generic;

namespace U2Lab2.Models;

public partial class Cliente
{
    public int IdCli { get; set; }

    public string? NombreCli { get; set; }

    public string? CedulaCli { get; set; }

    public string? CorreoCli { get; set; }

    public DateOnly FechaNacimientoCli { get; set; }

    public string? ImagenUrlCli { get; set; }
}
