namespace console_login_system.ContentContext
{
  public class Content
  {
    public Guid IdUser { get; set; }

    public Content(Guid idUser)
    {
      Console.Clear();


      this.IdUser = idUser;
      this.drawMenu();
    }

    private void drawMenu()
    {
        int windowHight = Console.WindowHeight;
        int windowWidth = Console.WindowWidth;

        bool isSignIn = true;
        
        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 4);
        Console.Write(@" _________________________________________");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 3);
        Console.Write(@"/                                         \");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 2);
        Console.Write(@"| 1 - Change your username                |");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 1);
        Console.Write(@"| 2 - Change your password   *****        |");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2);
        Console.Write(@"| 3 - Delete your Account :(              |");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 + 1);
        Console.Write(@"| 4 - View your user infomation 0.0       |");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 + 2);
        Console.Write(@"| 5 - Exit                                |");
        
        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 + 3);
        Console.Write(@"|  -------------------------------------  |");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 + 4);
        Console.Write(@"| R :                                     |");
        
        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 + 5);
        Console.Write(@"\_________________________________________/");

        Console.SetCursorPosition(windowWidth/2 - 17, windowHight/2 + 4);
        string answer = Console.ReadLine();

        var manipulateInformation = new ManipulateInformation();
        switch(answer)
        {
          case "1": manipulateInformation.changeUser(IdUser); break;
          case "2": manipulateInformation.changePassword(IdUser); break;
          case "3": manipulateInformation.deleteAccount(IdUser); break;
          case "4": manipulateInformation.viewInformation(IdUser); break;
          case "5": Console.Clear(); Thread.Sleep(800); Environment.Exit(1); break;
          default: drawMenu(); break;
        
      } 
    }
  }
}
