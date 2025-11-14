using BookLibrary;
using BookLibrary.Repositoryes;

class Application
{
    static void Main()
    {

        var userView = new UserView();
        userView.GetUser();
        //userView.GetUserById(5);

        //userView.AddUser("Игорь", "ig@rambler.com");
        //InitDatabaseEntity.Now(db, true);

    }
}