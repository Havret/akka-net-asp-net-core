using System;

namespace Bookstore.Messages
{
    public class CreateBook
    {
        public CreateBook(string title, string author, decimal cost, int inventoryAmount)
        {
            Title = title;
            Author = author;
            Cost = cost;
            InventoryAmount = inventoryAmount;
        }
        
        public string Title { get; }
        public string Author { get; }
        public decimal Cost { get; }
        public int InventoryAmount { get; }
    }
}