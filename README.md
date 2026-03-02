# CetStudentBook

---

## Ödev: Books CRUD

Bu projede `Book` modeli ve CRUD sayfalarını yaptım. Scaffolding kullanmadım, controller ve view'ları yazdım.

### eklenenler

- Book modeli (Name, Author, PublishDate, PageCount, IsSecondHand, validation)
- DbContext'e `DbSet<Book>` 
- BooksController  (Index, Create, Edit, Delete)
- Her işlem için ayrı view 
- Navbar'a Books linki 
- Veritabanı olarak SQLite 

### Projeyi çalıştırmak için


Veritabanını oluşturun ve projeyi başlatın:
```
dotnet ef database update
dotnet run
```


### Ekran görüntüleri


