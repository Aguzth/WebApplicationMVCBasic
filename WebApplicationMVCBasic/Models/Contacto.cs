using System;
using System.Collections.Generic;

namespace WebApplicationMVCBasic.Models;

public partial class Contacto
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Telefono { get; set; }

    public string? CorreoElectronico { get; set; }
}
