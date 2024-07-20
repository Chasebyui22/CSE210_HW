class Order {
    private List<Product> _products;
    private Customer _customer;
    public Order(Customer customer,List<Product> products) {
        _products = products;
        _customer = customer;
    }
    public float GetTotalPrice() {
        float totalPrice = 0;
        foreach (Product product in _products) {
            totalPrice += product._totalPrice;
        }
        totalPrice += _customer.LivesInUSA() ? 5 : 35;
        return totalPrice;
    }
    public string GetPackingLabel() {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products) {
            packingLabel += $"{product.ProductName} (ID: {product.ProductId}) - Quantity: {product.Quantity}\n";
        }
        return packingLabel;
}
    public string GetShippingLabel() {
        return $"Shipping Label:\n{_customer._name}\n{_customer._address.GetfullAddress}";
    }
}