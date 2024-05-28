using System;

namespace ClassObjectRealations
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            // 1
            // 1.1. Можливість додавати користувачів
            library.AddUser(new User { Id = 1, FirstName = "Ivan", LastName = "Ivanov", AcademicGroup = "A1" });
            library.AddUser(new User { Id = 2, FirstName = "Alex", LastName = "Petrov", AcademicGroup = "B1" });
            library.AddUser(new User { Id = 3, FirstName = "Vasyl", LastName = "Vasylenko", AcademicGroup = "B2" });
            library.AddUser(new User { Id = 4, FirstName = "Petro", LastName = "Vasylenko", AcademicGroup = "B2" });

            Console.WriteLine("1.1 Можливість додавати користувачів");
            foreach (var user in library.GetAllUsers())
            {
                Console.WriteLine(user);
            }

            // 1.2. Можливість видаляти користувачів
            library.RemoveUser(3);

            Console.WriteLine("1.2 Можливість видаляти користувачів");
            foreach (var user in library.GetAllUsers())
            {
                Console.WriteLine(user);
            }

            // 1.3. Можливість змінювати дані користувачів
            User updatedUser = library.GetUser(1);
            updatedUser.AcademicGroup = "A2";
            library.UpdateUser(updatedUser);

            Console.WriteLine("1.3 Можливість змінювати дані користувачів");
            foreach (var user in library.GetAllUsers())
            {
                Console.WriteLine(user);
            }

            // 1.4. Можливість переглянути дані конкретного користувача
            Console.WriteLine("1.4. Можливість переглянути дані конкретного користувача");
            Console.WriteLine(library.GetUser(1));

            // 1.5. Можливість переглянути список всіх користувачів
            Console.WriteLine("1.5. Можливість переглянути список всіх користувачів");
            foreach (var user in library.GetAllUsers())
            {
                Console.WriteLine(user);
            }

            // 1.5.1. Можливість відсортувати список по імені

            List<User> sortedUsersByFirstName = library.SortUsersByFirstName();

            Console.WriteLine("1.5.1. Можливість відсортувати список по імені");
            foreach (var user in sortedUsersByFirstName)
            {
                Console.WriteLine(user);
            }

            // 1.5.2. Можливість відсортувати список по прізвищу

            List<User> sortedUsersByLastName = library.SortUsersByLastName();

            Console.WriteLine("1.5.2. Можливість відсортувати список по прізвищу");
            foreach (var user in sortedUsersByLastName)
            {
                Console.WriteLine(user);
            }

            // 1.5.3. Можливість відсортувати список по академічній групі
            List<User> sortedUsersByGroup = library.SortUsersByAcademicGroup();

            Console.WriteLine("1.5.3. Можливість відсортувати список по академічній групі");
            foreach (var user in sortedUsersByGroup)
            {
                Console.WriteLine(user);
            }

            // 2. Управління документами (літературою) бібліотеки
            // 2.1. Можливість додавати документ
            library.AddDocument(new Document
                { Id = 1, Title = "Big Bamb", Author = "Arthur Conan Doil", IsIssued = false });
            library.AddDocument(new Document { Id = 2, Title = "Bamboo", Author = "Viliam Bold", IsIssued = false });
            library.AddDocument(new Document
                { Id = 3, Title = "Fahrenheit 451", Author = "Red Bredbery ", IsIssued = false });
            library.AddDocument(new Document
                { Id = 4, Title = "Around the World in Eighty Days", Author = "Jule Verne ", IsIssued = false });
            library.AddDocument(new Document
                { Id = 5, Title = "Fellowship Point", Author = "Alice Elliott", IsIssued = false });
            library.AddDocument(new Document
                { Id = 6, Title = "Finding Me", Author = "Viola Davis", IsIssued = false });
            library.AddDocument(new Document
                { Id = 7, Title = "Lapvona Verne", Author = "Ottessa Moshfegh", IsIssued = false });

            library.IssueDocument(2, 1);

            Console.WriteLine("2.1 Можливість додавати документ");
            foreach (var document in library.GetAllDocuments())
            {
                Console.WriteLine(document);
            }

            // 2.2. Можливість видаляти документ
            library.RemoveDocument(1);

            Console.WriteLine("2.2. Можливість видаляти документ");
            foreach (var document in library.GetAllDocuments())
            {
                Console.WriteLine(document);
            }

            // 2.3. Можливість змінювати дані документу
            Document updatedDocument = library.GetDocument(2);
            updatedDocument.Title = "Bamboo 2";
            library.UpdateDocument(updatedDocument);

            Console.WriteLine("2.3 Можливість змінювати дані документів");
            foreach (var document in library.GetAllDocuments())
            {
                Console.WriteLine(document);
            }

            // 2.4. Можливість переглянути дані конкретного документу
            Console.WriteLine("2.4 Можливість переглянути дані конкретного документу");
            Console.WriteLine(library.GetDocument(2));

            // 2.5. Можливість переглянути список всіх документів
            Console.WriteLine("2.5. Можливість переглянути список всіх документів");
            foreach (var document in library.GetAllDocuments())
            {
                Console.WriteLine(document);
            }

            // 2.5.1. Можливість відсортувати список по назві
            List<Document> sortedDocumentsByTitle = library.SortDocumentsByTitle();

            Console.WriteLine("2.5.1. Можливість відсортувати список по назві");
            foreach (var document in sortedDocumentsByTitle)
            {
                Console.WriteLine(document);
            }

            // 2.5.2. Можливість відсортувати список по автору

            List<Document> sortedDocumentsByAuthor = library.SortDocumentsByAuthor();

            Console.WriteLine("2.5.2. Можливість відсортувати список по автору");
            foreach (var document in sortedDocumentsByAuthor)
            {
                Console.WriteLine(document);
            }

            // 3. Управління видачами документів
            // 3.1. На рахунок користувача можна видавати n документів n<5
            Console.WriteLine("3.1. На рахунок користувача можна видавати n документів n<5");
            library.IssueDocument(3, 1);
            library.IssueDocument(4, 1);
            library.IssueDocument(5, 1);
            library.IssueDocument(6, 1);
            library.IssueDocument(7, 1); //Не зарахується на користувача

            Console.WriteLine("3.2. Можливість переглядати яку які документи взяв конкретний користувач");
            List<Document> userDocuments = library.GetDocumentsByUser(1);
            foreach (var document in userDocuments)
            {
                Console.WriteLine(document);
            }

            // 3.3. Можливість по заданому документу визначити, чи він знаходиться  бібліотеці.
            // Якщо документ виданий, то котрому користувачеві."
            Console.WriteLine(
                "3.3. Можливість по заданому документу визначити, чи він знаходиться у\n" +
                "бібліотеці. Якщо документ виданий, то котрому користувачеві.");
            Console.WriteLine(library.GetDocument(2));
            Console.WriteLine(library.GetDocumentHolder(2));

            // 3.4. Можливість повернути книжку в бібліотеку
            Console.WriteLine("3.4. Можливість повернути книжку в бібліотеку");
            library.ReturnDocument(2);
            Console.WriteLine(library.GetDocument(2));

            // 4. Пошук
            // 4.1. Можливість пошуку по ключовому слову серед документів
            List<Document> searchedDocuments = library.SearchDocuments("Verne");
            Console.WriteLine("4.1. Можливість пошуку по ключовому слову серед документів");
            foreach (var document in searchedDocuments)
            {
                Console.WriteLine(document);
            }

            // 4.2. Можливість пошуку по ключовому слову серед користувачів
            List<User> searchedUsers = library.SearchUsers("Petro");

            Console.WriteLine("4.2 Можливість пошуку по ключовому слову серед користувачів");
            foreach (var user in searchedUsers)
            {
                Console.WriteLine(user);
            }
        }
    }
}