using System;

namespace BookStoreApplication
{
    public class BookUtility
    {
        private Book book;

        public BookUtility(Book book)
        {
            // TODO: Assign book object
            this.book=book;

        }

        public void GetBookDetails()
        {
            // TODO:
            // Print format:
            // Details: <BookId> <Title> <Price> <Stock>
            Console.WriteLine($"Details: {book.Id} {book.Title} {book.Price} {book.Stock}");
        }

        public void UpdateBookPrice(int newPrice)
        {
            // TODO:
            // Validate new price
            // Update price
            // Print: Updated Price: <newPrice>
            book.Price=newPrice;
            Console.WriteLine($"Updated Price: {book.Price}");
        }

        public void UpdateBookStock(int newStock)
        {
            // TODO:
            // Validate new stock
            // Update stock
            // Print: Updated Stock: <newStock>
            book.Stock=newStock;
            Console.WriteLine($"Updated Stock: {book.Stock}");
        }
    }
}
