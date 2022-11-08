using System;
namespace trabManseira
{
    public class Canvas
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Header { get; set; }
        public bool MiddleLine { get; set; }

        public Canvas(int width, int height, bool header, bool middleLine)
        {
            this.Width = width;
            this.Height = height;
            this.Header = header;
            this.MiddleLine = middleLine;
        }

        public void drawCanvas()
        {
            // primeira linha
            Console.Write("+ ");
            for (int i = 0; i < Width; i++)
            {
                Console.Write("=");
            }
            Console.Write(" +\n");
            // meio
            for (int i = 0; i < Height; i++)
            {
                Console.Write("| ");
                // espaço do meio 
                for (int j = 0; j < Width; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(" |\n");
            }
            // linha final
            Console.Write("+ ");
            for (int i = 0; i < Width; i++)
            {
                Console.Write("=");
            }
            Console.Write(" +\n");

            if(Header == true) drawHeaderCanvas();
            if(MiddleLine== true) drawMiddleLine();
        }

        public void drawHeaderCanvas()
        {
            // criando header
            Console.SetCursorPosition(0, 5);

            Console.Write("+ ");
            for (int i = 0; i < Width; i++)
                Console.Write("=");

            Console.Write(" +");

            // inserindo titulo no header
            string text = "Titulo do Titulo";

            Console.SetCursorPosition(Width/2 - text.Length/2, 3);
            Console.Write(text);
        }
    }
}