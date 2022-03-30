// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


AuthorManagement authorManagement = new AuthorManagement(@"E:\Salim Shaikh Training\Training by Avinash\Surayavanshi Library Mgt System\Suryavanshi Mgt Sys\AuthorInfo.csv", "auhtorID,authorName,authorNotes\n");
//authorManagement.AddAuthor();
authorManagement.GetAllAuthor();

PublisherManagement publisherManagement = new PublisherManagement(@"E:\Salim Shaikh Training\Training by Avinash\Surayavanshi Library Mgt System\Suryavanshi Mgt Sys\PublisherInfo.csv", "publisher_ID, PublisherName, PublisherPhone, PublisherEmail , PublisherNotes\n");
//publisherManagement.GetAllPublisher();
publisherManagement.GetAllPublisher();
BookManagement bookManagement = new BookManagement(@"E:\Salim Shaikh Training\Training by Avinash\Surayavanshi Library Mgt System\Suryavanshi Mgt Sys\BookManagement.csv", "BookISBN,BookTitle,PublisherID, AuthorId ,IssueDate, IsDeleted\n");
//bookManagement.GetAllBook();
bookManagement.GetAllBook();
CustomerManagement customerManagement = new CustomerManagement(@"E:\Salim Shaikh Training\Training by Avinash\Surayavanshi Library Mgt System\Suryavanshi Mgt Sys\CustomerInfo.csv", "CustomerId,CustomerName,CustomerEmail, CustomerPhone ,CustomerAddress, _isSelected\n");
//customerManagement.AddCutomer();
customerManagement.GetAllCustomer();

//TransactionManagement transactionManagement = new TransactionManagement(@"E:\Salim Shaikh Training\Training by Avinash\Surayavanshi Library Mgt System\Suryavanshi Mgt Sys\TransactionInfo.csv", "TransactionId,BookId,CustomerId,DateOfIssue,DateOfReturn\n");
//transactionManagement.AddTransaction();

//class Menu
//{
//    public void ShowMenu(MenuManagement menuManagement)
//    {
//        DisplayMenu();
//      ConsoleKeyInfo keyInfo=  Console.ReadKey();



//    }
//    public void DisplayMenu()
//    {
//        Console.WriteLine("Menu");
//        Console.WriteLine("1.Create Author :");
//        Console.WriteLine("2.List Author :");

//        Console.WriteLine("3.Update Author");
//        Console.WriteLine("4.Delete Author :");
//        Console.WriteLine("5.Create Publisher :");

//        Console.WriteLine("6.List Publisher");
//        Console.WriteLine("7.Update Publisher :");
//        Console.WriteLine("8.Delete Publisher :");
//        Console.WriteLine("do You want Continue :");
//    }



//}

//class MenuManagement
//{
//    AuthorManagement authorManagement;
//    PublisherManagement publisherManagement;
//    BookManagement bookManagement;
//    CustomerManagement customerManagement;
//    TransactionManagement transactionManagement;
//    Menu m = new Menu();

//    public MenuManagement()
//    {
//        publisherManagement = new(@"E:\Salim Shaikh Training\Training by Avinash\Surayavanshi Library Mgt System\Suryavanshi Mgt Sys\PublisherInfo.csv", "publisher_ID, PublisherName, PublisherPhone, PublisherEmail , PublisherNotes\n");
//        authorManagement = new(@"E:\Salim Shaikh Training\Training by Avinash\Surayavanshi Library Mgt System\Suryavanshi Mgt Sys\AuthorInfo.csv", "Auhtor ID,Author Name,Notes\n");
//        bookManagement = new(@"E:\Salim Shaikh Training\Training by Avinash\Surayavanshi Library Mgt System\Suryavanshi Mgt Sys\BookManagement.csv", "BookISBN,BookTitle,PublisherID, AuthorId ,IssueDate, IsDeleted\n");
//        customerManagement = new(@"E:\Salim Shaikh Training\Training by Avinash\Surayavanshi Library Mgt System\Suryavanshi Mgt Sys\CustomerInfo.csv", "CustomerId,CustomerName,CustomerEmail, CustomerPhone ,CustomerAddress, _isSelected\n");
//        transactionManagement = new(@"E:\Salim Shaikh Training\Training by Avinash\Surayavanshi Library Mgt System\Suryavanshi Mgt Sys\TransactionInfo.csv", "TransactionId,BookId,CustomerId,DateOfIssue,DateOfReturn\n");

//    }

//    public void ShowMenu()
//    {
//        m.ShowMenu(this);
//    }

//    public void AddAuthor()
//    {
//        authorManagement.AddAuthor();
//    }

//    public void GetAllAuthor()
//    {
//        authorManagement.GetAllAuthor();
//    }

//    public void UpdatedAuthor()
//    {
//        // authorManagement.UpdateAuthor();

//    }

//    public void DeleteAutor()
//    {
//        // authorManagement.DeleteAuthor();
//    }

//    public void AddPublisher()
//    {
//        publisherManagement.AddPublisher();
//    }

//    public void GetAllPublisher()
//    {
//        publisherManagement.GetAllPublisher();
//    }

//    public void UpdatedPublisher()
//    {
//        // publisherManagement.UpdatePublisher();

//    }

//    public void DeletePublisher()
//    {
//        // publisherManagement.DeletePublisher();
//    }

//    public void AddBook()
//    {
//        bookManagement.AddBook();
//    }

//    public void GetAllBook()
//    {
//        bookManagement.GetAllBook();
//    }

//    public void UpdatedBook()
//    {
//        // bookManagement.UpdateBookByID();

//    }

//    public void DeleteBook()
//    {
//        // bookManagement.DeleteBookByID();
//    }



//    public void AddCutomer()
//    {
//        customerManagement.AddCutomer();

//    }

//    public void GetAllCustomer()
//    {
//        customerManagement.GetAllCustomer();
//    }

//    public void UpdateCutomer()
//    {
//        // customerManagement.UpdatedCustomer();

//    }

//    public void DeleteCustomer()
//    {
//        // customerManagement.DeleteCustomerById();
//    }


//    public void AddTransaction()
//    {
//        transactionManagement.AddTransaction();

//    }

//    public void GetAllTransaction()
//    {
//        //transactionManagement.GetAllTransaction();
//    }

//    public void UpdateTransaction()
//    {
//        // transactionManagement.UpdatedTransactionByID();

//    }

//    public void DeleteTransaction()
//    {
//        // transactionManagement.DeleteTransactionById();
//    }


//}
