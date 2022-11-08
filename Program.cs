namespace trabManseira
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var canvas = new Canvas(90, 24, false, true);
            Console.CursorVisible = false;
            canvas.drawCanvas();

            Console.ReadKey();
        }
    }
}