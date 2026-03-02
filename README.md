# CetStudentBook

---

## Ödev: Books CRUD

Bu projede `Book` modeli ekledim ve CRUD sayfalarını yaptım. Scaffolding kullanmadım, controller ve view'ları kendim yazdım.

### Ne yaptım

- Book modeli oluşturdum (Name, Author, PublishDate, PageCount, IsSecondHand alanları var, hepsine validation koydum)
- DbContext'e `DbSet<Book>` ekledim
- BooksController yazdım (Index, Create, Edit, Delete)
- Her işlem için ayrı view oluşturdum
- Navbar'a Books linki ekledim
- Veritabanı olarak SQLite kullandım

### Projeyi çalıştırmak için

Repoyu klonlayın:
```
git clone https://github.com/variksia/CetStudentBook.git
cd CetStudentBook/CetStudentBook
```

EF tool yoksa kurun:
```
dotnet tool install --global dotnet-ef
```

Veritabanını oluşturun ve projeyi başlatın:
```
dotnet ef database update
dotnet run
```

Tarayıcıda açılan linkten Books sekmesine gidebilirsiniz.

### Ekran görüntüleri

<!-- buraya eklenecek -->

