// using System;
// class Library
// {
//     private Dictionary<int, string> books = new Dictionary<int, string>();
//     public string this[int bookId]
//     {
//         get
//         {
//             return books.ContainsKey(bookId) ? books[bookId] : "this Book ID not found";
//         }
//         set
//         {
//             books[bookId] = value;
//         }
//     }

//     public string this[string title]
//     {
//         get
//         {
//             var book = books.FirstOrDefault(b => b.Value == title);
//             return book.Value ?? "this Book not found";
//         }
//     }
// }
