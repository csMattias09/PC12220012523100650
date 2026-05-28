using System;
using System.Collections.Generic;

namespace PC12220012523100650.COREE.Core.Entities;

public partial class OrdenServicio
{
    public int Id { get; set; }

    public DateTime FechaIngreso { get; set; }

    public string? DescripcionProblema { get; set; }

    public decimal? CostoEstimado { get; set; }

    public string? Estado { get; set; }

    public int VehiculoId { get; set; }

    public int TipoServicioId { get; set; }

    public virtual TipoServicio TipoServicio { get; set; } = null!;

    public virtual Vehiculo Vehiculo { get; set; } = null!;
}
