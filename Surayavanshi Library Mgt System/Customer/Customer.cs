// See https://aka.ms/new-console-template for more information



//authorInfo.GetAllAuthor();











class Customer
{
    private int _customerId;
    private string _name;
    private string _email;
    private string _phone;
    private string _address;
    private bool _isSelected;

    public Customer(int customerId, string name, string email, string phone, string address, bool isSelected=true)
    {
        CustomerId = customerId;
        Name = name;
        Email = email;
        Phone = phone;
        Address = address;
        IsSelected = _isSelected;
    }

    public int CustomerId { get => _customerId; set => _customerId = value; }
    public string Name { get => _name; set => _name = value; }
    public string Email { get => _email; set => _email = value; }
    public string Phone { get => _phone; set => _phone = value; }
    public string Address { get => _address; set => _address = value; }
    public bool IsSelected { get => _isSelected; set => _isSelected = value; }
}
