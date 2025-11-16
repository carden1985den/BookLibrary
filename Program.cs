using BookLibrary;
using BookLibrary.Repositoryes;

class Application
{
    static void Main()
    {
        var userView = new UserView();
        var bookView = new BookView();
        var rentView = new RentView();
        var requestView = new RequestView();

        var userRequestProcessing = new UserRequestProcessing();
        var bookRequestProcessing = new BookRequestProcessing();
        var rentRequestProcessing = new RentRequestProcessing();
        //InitDatabaseEntity.Now(db, true);

        while (true)
        {
            Console.Clear();

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
                        RentView.Menu(rentRequestProcessing);
                        break;
                    }
                case "0":
                    return;
            }
        }
    }
}