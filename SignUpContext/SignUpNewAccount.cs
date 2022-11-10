
using console_login_system.ContentContext;

namespace console_login_system.SignUpContext
{
    public class SignUpNewAccount
    {
        public void start()
        {
            Console.Clear();
            var canvas = new Canvas(126, 31, false, true);
            canvas.drawCanvas();
            
            var content = new Content(false);
            var earth = new Earth();

            this.getData();
        }

        private void getData()
        {
            Console.SetCursorPosition(96,18);
            string email = Console.ReadLine().Trim().ToLower();

            Console.SetCursorPosition(96,19);
            string newName = Console.ReadLine().Trim();

            Console.SetCursorPosition(96,20);
            string newPassword = Console.ReadLine().Trim();

            Console.SetCursorPosition(103,22);
            string passwordConfirmation = Console.ReadLine().Trim();

            if(newPassword != passwordConfirmation) this.start();
        }

        private void SetData()
        {
            
        }
    }
}