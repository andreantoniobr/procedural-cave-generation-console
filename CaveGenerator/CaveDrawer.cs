namespace ProceduralCaveGeneration.CaveGenerator
{
    public class CaveDrawer
    {
        public static void Draw(Cave cave)
        {
            ConsoleColor wallColor = ConsoleColor.DarkYellow;
            ConsoleColor backgroundColor = ConsoleColor.Black;
            Char wallChar = '1';
            Draw(cave, wallColor, backgroundColor, wallChar);
        }

        public static void Draw(Cave cave, ConsoleColor wallColor, ConsoleColor backgroundColor, Char wallChar)
        {
            if (cave != null && 
                cave.CaveData != null && 
                cave.Width > 0 && 
                cave.Height > 0)
            {
                Console.WriteLine();
                for (int y = 0; y < cave.Height; y++)
                {
                    Console.WriteLine();
                    for (int x = 0; x < cave.Width; x++)
                    {
                        DrawTile(cave.CaveData[x, y], wallColor, backgroundColor, wallChar);                                            
                    }
                }
                Console.WriteLine();
            }
        }
        
        public static void DrawTile(int caveTile, ConsoleColor wallColor, ConsoleColor backgroundColor, Char wallChar)
        {
            if (caveTile >= 1)
            {
                Console.ForegroundColor = wallColor;
                Console.Write(wallChar);
            } 
            else
            {
                Console.ForegroundColor = backgroundColor;
                Console.Write(wallChar);
            }
        }
    }
}