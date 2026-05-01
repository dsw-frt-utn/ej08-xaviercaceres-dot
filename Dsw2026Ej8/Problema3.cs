using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Product
    {
        private string description;

        public string GetDescription() => description;

        public void SetDescription(string description)
        {
            this.description = description;
        }
    }
    internal class Problema3
    {
        public string CompararCopia(int originalValue, Product product)
        {
            int copiaOriginal = originalValue;
            copiaOriginal++;

            Product productCopia = product;

            productCopia.SetDescription("Nueva Description");

            return $"{originalValue}-{productCopia}-{product.GetDescription()}";
        }
    }
}
