﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DulceFacilSD.Infraestructura.AccesoDatos;

public partial class DetallePedidos
{
    public int DetalleID { get; set; }

    public int PedidoID { get; set; }

    public int ProductoID { get; set; }

    public int Cantidad { get; set; }

    public decimal PrecioUnitario { get; set; }

    public decimal Subtotal { get; set; }

    public virtual Pedidos Pedido { get; set; }

    public virtual Productos Producto { get; set; }
}