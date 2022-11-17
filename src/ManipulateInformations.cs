using System.Collections;
using Dapper;
using Microsoft.Data.SqlClient;
namespace console_login_system.src
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
        Console.Clear();
        int windowHight = Console.WindowHeight;
        int windowWidth = Console.WindowWidth;

        
        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 2);
        Console.Write(@" _________________________________________");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 1);
        Console.Write(@"/                                         \");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2);
        Console.Write(@"| Are you sure? (S/N) :                   |");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 + 1);
        Console.Write(@"\_________________________________________/");

        Console.SetCursorPosition(windowWidth/2 + 1, windowHight/2);
        var respose = Console.ReadLine();
        if(respose.ToLower() == "n") Thread.Sleep(800); signInAccount.start();

      using(var connection = new SqlConnection(stringConnection))
      {
        var sql = @"
          DELETE [Account] WHERE [Id] = @id
        ";

        connection.Open();
        connection.Execute(sql, new { id } );
      }

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 2);
        Console.Write(@" _________________________________________");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 1);
        Console.Write(@"/                                         \");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2);
        Console.Write(@"|  Account has been successfully deleted  |");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 + 1);
        Console.Write(@"\_________________________________________/");

        Thread.Sleep(1200);
        Environment.Exit(1);
    }

    public void viewInformation(Guid id)
    {
        Console.Clear();
        int windowHight = Console.WindowHeight;
        int windowWidth = Console.WindowWidth;

      using(var connection = new SqlConnection(stringConnection))
      {
        var sql = @"
          SELECT * FROM [Account] WHERE [Id] = @id
        ";

        connection.Open();
        var userInformation = connection.Query(sql, new { id } );

        // Console.SetCursorPosition(windowWidth/2 - 10, windowHight/2);
        foreach (var item in userInformation)
        {
          Console.WriteLine("Email : " + item.Email);
          Console.WriteLine("User : " + item.User);
          Console.WriteLine("Password : " + item.Password);
        }
      }

        // Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 2);
        // Console.Write(@" _________________________________________");

        // Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 1);
        // Console.Write(@"/                                         \");

        // Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2);
        // Console.Write(@"| Email :                                 |");

        // Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 + 1);
        // Console.Write(@"| Username:                               |");

        // Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 + 2);
        // Console.Write(@"| Password :                              |");

        // Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 + 3);
        // Console.Write(@"\_________________________________________/");

        Thread.Sleep(1200);
        Environment.Exit(1);
    }
  }
}