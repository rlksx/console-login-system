using console_login_system.ContentContext;
namespace console_login_system.SignInContext
{
    public class SignInAccount
    {
        public void start()
        {
            Console.Clear();
            var canvas = new Canvas(126, 31, false, true);
            canvas.drawCanvas();

            var content = new Content(true);
            var earth = new Earth();

            this.getData();
        }

        private void getData()
        {
            Console.SetCursorPosition(96,18);
            string userName = Console.ReadLine().Trim();

            Console.SetCursorPosition(96, 19);
            string userPassword = Console.ReadLine().Trim();
        }

        private void checkData()
        {

        }
    }
}