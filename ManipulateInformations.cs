using Dapper;
using Microsoft.Data.SqlClient;
namespace console_login_system
{
  class ManipulateInformation
  {
    public string stringConnection { get; set; }
    SignInAccount signInAccount = new SignInAccount();

    public ManipulateInformation()
    {
      const string stringConnection = "Server=localhost,1433;Database=ConsoleLoginData;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;";
      this.stringConnection = stringConnection;
    }

    public void changeUser(Guid id)
    {
      Console.Clear();
        int windowHight = Console.WindowHeight;
        int windowWidth = Console.WindowWidth;

        
        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 2);
        Console.Write(@" _________________________________________");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 1);
        Console.Write(@"/                                         \");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2);
        Console.Write(@"| New username :                          |");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 + 1);
        Console.Write(@"\_________________________________________/");

        Console.SetCursorPosition(windowWidth/2 - 6, windowHight/2);
        var newUserName = Console.ReadLine();

      using(var connection = new SqlConnection(stringConnection))
      {
        var sql = @"
          UPDATE [Account] SET [User] = @newUserName WHERE [Id] = @id
        ";

        connection.Open();
        connection.Execute(sql, new { newUserName, id } );
      }

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 2);
        Console.Write(@" _________________________________________");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 1);
        Console.Write(@"/                                         \");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2);
        Console.Write(@"| username has been successfully changed! |");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 + 1);
        Console.Write(@"\_________________________________________/");

        Thread.Sleep(1200);
        signInAccount.start();
    }
    public void changePassword(Guid id)
    {
       Console.Clear();
        int windowHight = Console.WindowHeight;
        int windowWidth = Console.WindowWidth;

        
        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 2);
        Console.Write(@" _________________________________________");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 1);
        Console.Write(@"/                                         \");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2);
        Console.Write(@"| New password :                          |");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 + 1);
        Console.Write(@"\_________________________________________/");

        Console.SetCursorPosition(windowWidth/2 - 6, windowHight/2);
        var newPassword = Console.ReadLine();

      using(var connection = new SqlConnection(stringConnection))
      {
        var sql = @"
          UPDATE [Account] SET [Password] = @newPassword WHERE [Id] = @id
        ";

        connection.Open();
        connection.Execute(sql, new { newPassword, id } );
      }

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 2);
        Console.Write(@" _________________________________________");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 1);
        Console.Write(@"/                                         \");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2);
        Console.Write(@"| Password has been successfully changed! |");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 + 1);
        Console.Write(@"\_________________________________________/");

        Thread.Sleep(1200);
        signInAccount.start();
    }

    public void deleteAccount(Guid id)
    {

    }

    public void viewInformation(Guid id)
    {

    }
  }
}