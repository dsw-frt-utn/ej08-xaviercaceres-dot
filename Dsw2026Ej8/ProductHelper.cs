using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        private long code;
        private string description;
        private decimal price;

        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            return $"[{code}] {description} {Sepador} {price:C}";
        }
    }

    public partial class ProductHelper
    {
        public const string Sepador = "-";
    }
}
