using console_login_system.SignInContext;
using console_login_system.SignUpContext;
using console_login_system.ContentContext;
namespace console_login_system
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var signInAccount = new SignInAccount();
            var signUpNewAccount = new SignUpNewAccount();
            signInAccount.start();
            // signUpNewAccount.start();
            
            Console.ReadKey();
        }
    }
}