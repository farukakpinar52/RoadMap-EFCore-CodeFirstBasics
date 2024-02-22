// See https://aka.ms/new-console-template for more information
using CodeFirstAndMigration.Context;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

#region runtime da veritabanına migrate etmek 

//veritabanı bağlantı sınıfımızın bir nesnesini oluştururuz

//CodefirstDBContext context = new();
//await context.Database.MigrateAsync();

//bunu neden yaparız ? : Son kullanıcı hedef veritabanında uygulamayı ayağa kaldırırken kendi veritabanını sıfırdan oluşturması gerektiğinde bu kod ile programı çalıştırdığında veritabanı otomatik olarak oluşturulacak.

//a

#endregion

