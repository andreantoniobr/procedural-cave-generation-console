namespace ProceduralCaveGeneration.CaveGenerator
{
    public class Cave
    {
        private int _seed = 0;
        private int _width = 50;
        private int _height = 25;
        private int _randomFillPercent = 50;
        private int[,] _caveData;

        public int Width => _width;
        public int Height => _height;
        public int[,] CaveData => _caveData;

        public Cave(int seed, int width, int height, int randomFillPercent)
        {
            _seed = seed;
            _width = width;
            _height = height;
            _randomFillPercent = randomFillPercent;
            CaveDataGenerator.GenerateData(_width, _height, _seed, _randomFillPercent, out _caveData);
        }     
    }
}