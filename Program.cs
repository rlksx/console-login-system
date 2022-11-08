namespace console_login_system
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.CursorVisible = false;

            var canvas = new Canvas(146, 31, false, true);
            canvas.drawCanvas();
            //
            var earth = new Earth();

            Console.ReadKey();
        }
    }
}