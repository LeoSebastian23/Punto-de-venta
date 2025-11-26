namespace Punto_de_venta.Models
{
    public class SaleItem
    {
        public int Id { get; private set; }

        public int ProductId { get; private set; }
        public Product Product { get; private set; }

        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }

        public decimal Subtotal => Quantity * UnitPrice;

        public int SaleId { get; private set; }
        public Sale Sale { get; private set; }

        // Constructor protegido para EF
        protected SaleItem() { }

        // Constructor de dominio (solo lo usa la entidad Sale)
        internal SaleItem(Product product, int quantity, decimal unitPrice, Sale sale)
        {
            Product = product ?? throw new ArgumentNullException(nameof(product));
            ProductId = product.Id;

            if (quantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(quantity));

            Quantity = quantity;
            UnitPrice = unitPrice;

            Sale = sale ?? throw new ArgumentNullException(nameof(sale));
        }
    }
}
