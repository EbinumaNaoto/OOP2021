using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleEntityFramework.Models;

namespace SampleEntityFramework {

    class Program {

        static void Main(string[] args) {

            //13.1.1
            //Exercise13_1();
            //Console.WriteLine("------");

            //13.1.2
            Exercise13_2();
            Console.WriteLine("------");

            //13.1.3
            Exercise13_3();
            Console.WriteLine("------");

            //13.1.4
            Exercise13_4();
            Console.WriteLine("------");

            //13.1.5
            Exercise13_5();

            Console.ReadLine(); //F5で実行してもすぐコンソール画面が消えないようにする
        }

        private static void Exercise13_1() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    Birthday = new DateTime(1888, 12, 26),
                    Gender = "M",
                    Name = "菊池寛"
                };
                db.Authors.Add(author1);

                var author2 = new Author {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "M",
                    Name = "川端康成"
                };
                db.Authors.Add(author2);
                db.SaveChanges();
            }

            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(a => a.Name == "夏目漱石");
                var book1 = new Book {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = author1
                };
                db.Books.Add(book1);

                var author2 = db.Authors.Single(a => a.Name == "川端康成");
                var book2 = new Book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = author2
                };
                db.Books.Add(book2);

                var author3 = db.Authors.Single(a => a.Name == "菊池寛");
                var book3 = new Book {
                    Title = "真珠婦人",
                    PublishedYear = 2002,
                    Author = author3
                };
                db.Books.Add(book3);

                var author4 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book4 = new Book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = author4
                };
                db.Books.Add(book4);
                db.SaveChanges();
            }
        }

        private static void Exercise13_2() {
            using (var db = new BooksDbContext()) {
                var books = db.Books.ToList();
                foreach (var book in books) {
                    Console.WriteLine($"タイトル:{book.Title} 発行年:{book.PublishedYear} 著者名:{book.Author.Name}");
                }
            }
        }

        private static void Exercise13_3() {
            using (var db = new BooksDbContext()) {
                var longTitleBooks = db.Books.Where(b => b.Title.Length == db.Books.Max(x => x.Title.Length)).ToList();
                foreach (var book in longTitleBooks) {
                    Console.WriteLine($"タイトル:{book.Title} 発行年:{book.PublishedYear} 著者名:{book.Author.Name}");
                }
            }
        }

        private static void Exercise13_4() {
            using (var db = new BooksDbContext()) {
                var oldBooks = db.Books.OrderBy(b => b.PublishedYear).Take(3).ToList();
                foreach (var book in oldBooks) {
                    Console.WriteLine($"タイトル:{book.Title} 著者名:{book.Author.Name}");
                }
            }
        }

        private static void Exercise13_5() {
            using (var db = new BooksDbContext()) {
                var authors = db.Authors.OrderByDescending(a => a.Birthday).ToList();
                foreach (var author in authors) {
                    Console.WriteLine($"著者名:{author.Name}");
                    foreach (var book in author.Books) {
                        Console.WriteLine($"タイトル{book.Title} 発行年{book.PublishedYear}");
                    }
                }
            }
        }

        //自動マイグレーション
        private static void AutomaticMigration() {
            using (var db = new BooksDbContext()) {
                db.Database.Log = sql => { Debug.Write(sql); };

                var count = db.Books.Count();
                Console.WriteLine(count);
            }
        }

        //高度なクエリ
        private static void AdvancedQuery() {
            
            using (var db = new BooksDbContext()) {
                #region 2冊以上の著者
                //書籍が2冊以上の著者を取得する
                var authors = db.Authors.Where(a => a.Books.Count() >= 2);
                foreach (var a in authors) {
                    Console.WriteLine($"{a.Name} {a.Gender} {a.Birthday}");
                }
                #endregion

                #region 昇順に並べ替え
                //出版年、著者名の順(それぞれ昇順)に書籍を並べ替えて取得する
                var books = db.Books.OrderBy(b => b.PublishedYear).ThenBy(b => b.Author.Name);
                foreach (var book in books) {
                    Console.WriteLine($"{book.Title} {book.PublishedYear} {book.Author.Name}");
                }
                #endregion

                #region 発行年ごとの書籍数
                //発行年ごとの書籍数を求める
                var groups = db.Books.GroupBy(b => b.PublishedYear)
                                     .Select(g => new {
                                         Year = g.Key,
                                         Count = g.Count()
                                     });
                foreach (var g in groups) {
                    Console.WriteLine($"{g.Year} {g.Count}");
                }
                #endregion

                #region 最も冊数の多い著者
                //最も冊数の多い著者を1人求める
                var author = db.Authors.Where(a => a.Books.Count() == db.Authors.Max(x => x.Books.Count())).First();
                Console.WriteLine($"{author.Name} {author.Gender} {author.Birthday}");
                #endregion
            }
        }

        // List 13-5
        static void InsertBooks() {
            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book1);

                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);

                db.SaveChanges();   //データベースの更新

            }
        }

        // List 13-7
        static IEnumerable<Book> GetBooks() {
            using (var db = new BooksDbContext()) {
                return db.Books.Where(book => book.Author.Name.StartsWith("夏目")).ToList();

            }
        }

        // List 13-8
        static void DisplayAllBooks() {
            var books = GetBooks();
            foreach (var book in books) {
                Console.WriteLine($"{book.Title} {book.PublishedYear}");
            }
            Console.ReadLine(); //F5で実行後、一時停止させる
        }

        // List 13-9
        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子"
                };
                db.Authors.Add(author1);

                var author2 = new Author {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治"
                };
                db.Authors.Add(author2);
                db.SaveChanges();

            }
        }

        // List 13-10
        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var book1 = new Book {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1,
                };
                db.Books.Add(book1);

                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.Books.Add(book2);

                db.SaveChanges();
            }

        }

        //List 13-11
        private static void UpdateBook() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.Single(x => x.Title == "銀河鉄道の夜");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }
        }

        //List 13-12
        private static void DeleteBook() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.SingleOrDefault(x => x.Id == 10);
                if (book != null) {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
            }
        }
    }
}
