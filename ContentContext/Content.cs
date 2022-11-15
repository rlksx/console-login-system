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
        Console.Write(@"|  -------------------------------------  |");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 + 3);
        Console.Write(@"| R :                                     |");
        
        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 + 4);
        Console.Write(@"\_________________________________________/");

        Console.SetCursorPosition(windowWidth/2 - 17, windowHight/2 + 3);
        int answer = Convert.ToInt32(Console.ReadLine());

        switch(answer)
        {
          case 1: changeUser(); break;
          case 2: changePassword(); break;
          case 3: deleteAccount(); break;
          case 4: viewInformation(); break;
        }
    }

    private void viewInformation()
    {
      throw new NotImplementedException();
    }

    private void deleteAccount()
    {
      throw new NotImplementedException();
    }

    private void changePassword()
    {
      throw new NotImplementedException();
    }

    private void changeUser()
    {
      throw new NotImplementedException();
    }
  }
}