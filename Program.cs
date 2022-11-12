using console_login_system.ContentContext;
namespace console_login_system
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            try
            {
                Console.SetWindowSize(130, 34);
            }
            catch (System.Exception)
            {
                isSignInOrSignUp();
            }

            var signInAccount = new SignInAccount();
            var signUpNewAccount = new SignUpNewAccount();
            // signInAccount.start();
            signUpNewAccount.start();
            
            Console.ReadKey(); 
        }

        public static void isSignInOrSignUp ()
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
                Console.Write("Width = 130 Height = 33");

                Thread.Sleep(100);
                Console.Clear();
            }
        }
        
    }
}