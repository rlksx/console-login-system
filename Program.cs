namespace trabManseira
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.CursorVisible = false;
            var canvas = new Canvas(90, 24, false, true);
            canvas.drawCanvas();

            Console.ReadKey();
        }
    }
}