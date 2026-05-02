using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema5
    {
        public decimal ObtenerImporteTotal(Sale sale)
        {
            return sale.CalculateTotal();
        }
    }

    internal class Sale
    {
        protected decimal importe;  
        public virtual decimal CalculateTotal()
        {
            return importe;
        }
        
    }

    internal class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return importe;
        }
    }

    internal class WholesaleSale : Sale
    {
        protected decimal descuento;
        public override decimal CalculateTotal()
        {
            descuento = importe * 0.1m;
            return importe - descuento;
        }
    }
}
