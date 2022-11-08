using System;
namespace trabManseira
{
    public class Canvas
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Header { get; set; }
        public bool VerticalRow { get; set; }

        public Canvas(int width, int height, bool header, bool verticalRow)
        {
            this.Width = width;
            this.Height = height;
            this.Header = header;
            this.VerticalRow = verticalRow;
        }

        public void DrawCanvas()
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
            if(VerticalRow == true) drawVerticalRow();
            
        }
    }
}