using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;
        private const double USA_SHIPPING_COST = 5.00;
        private const double INTERNATIONAL_SHIPPING_COST = 35.00;
        public Order(Customer customer)
        {
            _products = new List<Product>();
            _customer = customer;
        }
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        private double GetSubtotal()
        {
            double total = 0;
            foreach (Product product in _products)
            {
                total += product.GetTotalCost();
            }
            return total;
        }
        private double GetShippingCost()
        {
            if (_customer.LivesInUSA())
            {
                return USA_SHIPPING_COST;
            }
            else
            {
                return INTERNATIONAL_SHIPPING_COST;
            }
        }
        public double GetTotalPrice()
        {
            return GetSubtotal() + GetShippingCost();
        }
        public string GetPackingLabel()
        {
            string label = "PACKING LABEL\n";
            label += "-------------\n";
            foreach (Product product in _products)
            {
                label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
            }
            return label;
        }
        public string GetShippingLabel()
        {
            string label = "SHIPPING LABEL\n";
            label += "---------------\n";
            label += $"{_customer.GetName()}\n";
            label += _customer.GetAddress().GetFullAddress();
            return label;
        }
        public void DisplayOrderSummary()
        {
            Console.WriteLine(GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine(GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Subtotal: ${GetSubtotal():F2}");
            Console.WriteLine($"Shipping: ${GetShippingCost():F2}");
            Console.WriteLine($"TOTAL: ${GetTotalPrice():F2}");
            Console.WriteLine(new string('-', 40));
        }
    }
}