namespace PhoneBook;

// Доработайте вашу телефонную книгу из задания 14.2.10 предыдущего юнита так, чтобы контакты телефонной книги были отсортированы сперва по имени, а затем по фамилии.
internal class Program
{
    private static void Main(string[] args)
    {
        List<Contact> phoneBook = new()
        {
            new Contact("Игорь",      "Николаев",      79990000001,  "igor@example.com"),
            new Contact("Сергей",     "Довлатов",      79990000010,  "serge@example.com"),
            new Contact("Анатолий",   "Карпов",        79990000011,  "anatoly@example.com"),
            new Contact("Валерий",    "Леонтьев",      79990000012,  "valera@example.com"),
            new Contact("Сергей",     "Брин",          799900000013, "serg@example.com"),
            new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com")
        };

        phoneBook = phoneBook
            .OrderBy(contact => contact.FirstName)
            .ThenBy(contact => contact.LastName)
            .Select(contact => contact)
            .ToList();

        while (true)
        {
            char input = Console.ReadKey().KeyChar;

            bool isParsed = int.TryParse(input.ToString(), out int pageNumber);

            if (!isParsed || pageNumber < 1 || pageNumber > 3)
            {
                Console.WriteLine();
                Console.WriteLine("Страницы не существует");
                continue;
            }

            var pageContent = phoneBook.Skip((pageNumber - 1) * 2).Take(2);
            Console.WriteLine();

            foreach (var entry in pageContent)
                Console.WriteLine(entry.FirstName + " " + entry.LastName +  ": " + entry.PhoneNumber);

            Console.WriteLine();
        }

    }
}