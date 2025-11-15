using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class PedidoItem
    {
       
            public int IdMedicamento { get; set; }
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public decimal Precio { get; set; }

            public override string ToString()
            {
                return $"{Nombre} x{Cantidad} (c/u {Precio:0.00})";
            }
        }
    }

