using BookLibrary;
using BookLibrary.Repositoryes;
using BookLibrary.View;

class Application
{
    static void Main()
    {
        InitDatabaseEntity.Now();

        var userView = new UserView();
        var bookView = new BookView();
        var rentView = new RentView();
        var requestView = new RequestView();

        var userRequestProcessing = new UserRequestProcessing();
        var bookRequestProcessing = new BookRequestProcessing();
        var rentRequestProcessing = new RentRequestProcessing();
        
        InitDatabaseEntity.Now(false);

        while (true)
        {
            Console.WriteLine("1 - Данные по пользователям");
            Console.WriteLine("2 - Данные по книгам");
            Console.WriteLine("3 - Аренда книги");
            Console.WriteLine("4 - Дополнительные поисковые запросы");
            Console.WriteLine("0 - Выход");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        userView.Menu(userRequestProcessing);
                        break;
                    }
                case "2":
                    {
                        bookView.Menu(bookRequestProcessing);
                        break;
                    }
                case "3":
                    {
                        rentView.Menu(rentRequestProcessing);
                        break;
                    }
                case "4":
                    {
                        requestView.Menu(); //(additionRequestProcessing);
                        break;
                    }
                case "0":
                    return;
            }
        }
    }

    public static void ExitPreviousMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Нажмите любую клавишу для перехода в предыдущее меню...");
        Console.ReadKey();
        Console.Clear();
    }
}