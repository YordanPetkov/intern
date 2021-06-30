using DPS.Data;
using DPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPS.Logic.DatabaseUtilities
{
    public static class BookStore
    {
        public static void Create(CreationModel creationModel)
        {
            using (var dbContext = new LibraryDbContext())
            {
                foreach (var book in creationModel.books)
                {
                    var genres = new List<Genre>();
                    foreach (var genre in book.Genres)
                    {
                        genres.Add(dbContext.Genres.Find((int)genre.Id));
                    }

                    Book newBook = new Book
                    {
                        Title = book.Title,
                        Year = book.Year,
                        AuthorNicknameId = book.AuthorNicknameId,
                        Author = dbContext.Nicknames.Find(book.AuthorNicknameId),
                        Genres = genres
                    };

                    dbContext.Books.Add(newBook);
                }
            }
        }
    }
}
