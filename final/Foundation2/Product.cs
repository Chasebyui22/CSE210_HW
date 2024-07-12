class Product{
    private string _productName;
    private string _productId;
    private float _pricePerUnit;
    private int _quantity;
    public float _totalPrice {
        get {
            return _pricePerUnit * _quantity;
        }
    }
    public Product(string productName, string productId, float pricePerUnit, int quantity) {
        _productName = productName;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }
    public string ProductName {
        get {
            return _productName;
        }
    }
    public string ProductId {
        get {
            return _productId;
        }
    }
    public int Quantity {
        get {
        return _quantity;
    }
}
}