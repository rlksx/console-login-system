using console_login_system.ContentContext;
namespace console_login_system
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            try { Console.SetWindowSize(130, 34); } 
            catch (System.Exception) { checkWindowSize(); }

            var signInAccount = new SignInAccount();
            var signUpNewAccount = new SignUpNewAccount();
            Console.CursorVisible = true;

            Thread.Sleep(800);
            bool isSignIn = isSignInOrSignUp();
            switch(isSignIn)
            {
                case true: signInAccount.start(); break;
                case false: signUpNewAccount.start(); signInAccount.start(); break;
            }
            
            Console.ReadKey(); 
        }

    private static bool isSignInOrSignUp()
    {
        int windowHight = Console.WindowHeight;
        int windowWidth = Console.WindowWidth;

        bool isSignIn = true;
        
        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 2);
        Console.Write(@" _________________________________________");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 - 1);
        Console.Write(@"/                                         \");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2);
        Console.Write(@"| Ja possui uma conta conosco? (S/N) :    |");

        Console.SetCursorPosition(windowWidth/2 - 23, windowHight/2 + 1);
        Console.Write(@"\_________________________________________/");

        Console.SetCursorPosition(windowWidth/2 + 16, windowHight/2);
        var response = Console.ReadLine();

        switch (response.ToLower().Trim())
        {
            case "s": isSignIn = true; break;
            case "n": isSignIn = false; break;
            default: isSignInOrSignUp(); break;
        }


      return isSignIn;
    }

    private static void checkWindowSize()
        {
            Console.CursorVisible = false;
            int currentWindowHight = Console.WindowHeight;
            int currentWindowWidth = Console.WindowWidth;

            while (currentWindowHight < 34 || currentWindowWidth < 130)
            {
                currentWindowWidth = Console.WindowWidth;
                currentWindowHight = Console.WindowHeight;

                Console.SetCursorPosition(currentWindowWidth/2 - "Terminal Window too small".Length/2, currentWindowHight/2 - 3);
                Console.Write("Terminal Window too small");

                Console.SetCursorPosition(currentWindowWidth/2 - $"Width = {currentWindowWidth} Height = {currentWindowHight}".Length/2, currentWindowHight/2 - 2);
                Console.Write($"Width = {currentWindowWidth} Height = {currentWindowHight}");

                Console.SetCursorPosition(currentWindowWidth/2 - $"Needed for run the project:".Length/2, currentWindowHight/2);
                Console.Write("Needed for run the project:");

                Console.SetCursorPosition(currentWindowWidth/2 - $"Width = 100 Height = 100".Length/2, currentWindowHight/2 + 1);
                Console.Write("Width = 130 Height = 34");

                Thread.Sleep(60);
                Console.Clear();
            }
        }
        
    }
}