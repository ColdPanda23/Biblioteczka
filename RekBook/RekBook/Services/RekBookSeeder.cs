using RekBook.Entities;

namespace RekBook.Services
{
    public class RekBookSeeder
    {
        private readonly RekBookDbContext _dbContext;

        public RekBookSeeder(RekBookDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Books.Any())
                {
                    var books = GetBooks();
                    _dbContext.Books.AddRange(books);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Book> GetBooks()
        {
            var books = new List<Book>()
                {
                    new Book()
                    {
                        Title = "Head First C#. 4th Edition",
                        ISBN = "9781491976708",
                        Description = "Dive into C# and create apps, user interfaces, games, " +
                                      "and more using this fun and highly visual introduction to C#, " +
                                      ".NET Core, and Visual Studio. With this completely updated guide, " +
                                      "which covers C# 8.0 and Visual Studio 2019, beginning programmers " +
                                      "like you will build a fully functional game in the opening chapter. " +
                                      "Then you'll learn how to use classes and object-oriented programming, " +
                                      "create 3D games in Unity, and query data with LINQ. " +
                                      "And you'll do it all by solving puzzles, doing hands-on exercises, " +
                                      "and building real-world applications. By the time you're done, you'll be a solid " +
                                      "C# programmer--and you'll have a great time along the way!",
                        Authors = new List<Author>()
                        {
                            new Author()
                            {
                                FirstName = "Andrew",
                                LastName = "Stellman",

                            },
                            new Author()
                            {
                                FirstName = "Jennifer",
                                LastName = "Greene",
                            }
                        },

                        Shelf = new Shelf()
                        {
                            Name = "VFloor1",
                            Building = "Villa",
                            Floor = 1
                        },
                        Publisher = new Publisher()
                        {
                            Name = "O'Reilly Media"

                        },
                        Category = new Category()
                        {
                            Name = "Informatyka"
                        }
                    }

                };
            return books;
        }

    }
}


