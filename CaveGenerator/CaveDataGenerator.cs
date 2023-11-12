namespace ProceduralCaveGeneration.CaveGenerator
{
    public class CaveDataGenerator
    {
        public static bool GenerateData(int width, int height, int seed, int randomFillPercent, out int[,] caveData)
        {
            caveData = null;
            bool canGenerateData = false;
            if (width > 0 && height > 0)
            {
                canGenerateData = true;
                caveData = new int[width, height];
                Random pseudoRandom = new Random(seed);
                FillData(width, height, randomFillPercent, caveData, pseudoRandom);
                SmoothData(width, height, caveData);
            }
            return canGenerateData;
        }

        private static void FillData(int width, int height, int randomFillPercent, int[,] caveData, Random pseudoRandom)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (IsBorder(width, height, x, y))                      
                    {
                        caveData[x, y] = 1;
                    }
                    else
                    {
                        caveData[x, y] = (pseudoRandom.Next(0, 100) < randomFillPercent) ? 1: 0;
                    }
                }
            }
        }

        private static void SmoothData(int width, int height, int[,] caveData)
        {
            int smootDataLoopsAmount = 4;
            for (int x = 0; x <= smootDataLoopsAmount; x++)
            {
                SmoothDataLoop(width, height, caveData);
            }
        }

        private static void SmoothDataLoop(int caveWidth, int caveHeight, int[,] caveData)
        {
            int neighborsAmountToSmoothCell = 4;
            for (int x = 0; x < caveWidth; x++)
            {
                for (int y = 0; y < caveHeight; y++)
                {
                    int neighborsAmount = GetNeighborsAmount(caveWidth, caveHeight, x, y, caveData);                   
                    if (neighborsAmount > neighborsAmountToSmoothCell)
                    {
                        caveData[x, y] = 1;
                    }
                    else if (neighborsAmount < neighborsAmountToSmoothCell)
                    {
                        caveData[x, y] = 0;
                    }
                }
            }
        }

        private static int GetNeighborsAmount(int gridWidth, int gridHeight, int cellX, int cellY, int[,] caveData)
        {
            int neighborsAmount = 0;
            for (int neighborX = cellX - 1; neighborX <= cellX + 1; neighborX++)
            {
                for (int neighborY = cellY - 1; neighborY <= cellY + 1; neighborY++)
                {
                    if (IsInBorderLimits(gridWidth, gridHeight, neighborX, neighborY))
                    {
                        if (neighborX != cellX || neighborY != cellY)
                        {
                            neighborsAmount += caveData[neighborX, neighborY];
                        }
                    }
                    else
                    {
                        neighborsAmount++;
                    }
                }
            }
            return neighborsAmount;
        }

        private static bool IsBorder(int gridWidth, int gridHeight, int cellX, int cellY)
        {
            return cellX == 0 || cellY == 0 || cellX == gridWidth - 1 || cellY == gridHeight - 1;
        }

        private static bool IsInBorderLimits(int gridWidth, int gridHeight, int cellX, int cellY)
        {
            return cellX >= 0 && cellY >= 0 && cellX < gridWidth && cellY < gridHeight;
        }
    }
}