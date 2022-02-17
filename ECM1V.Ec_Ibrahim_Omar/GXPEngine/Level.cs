using System;
namespace GXPEngine
{
    public class Level : GameObject
    {
		const int WIDTH = 7;
		const int HEIGHT = 13;
		const int SIZE = 64;

		int[,] level = new int[HEIGHT, WIDTH]
		{
		{ 0, 0, 0, 0, 0, 0, 0},
		{ 0, 1, 0, 1, 0, 0, 0},
		{ 0, 0, 1, 0, 1, 0, 0},
		{ 0, 1, 0, 1, 0, 0, 0},
		{ 0, 0, 1, 0, 1, 0, 0},
		{ 0, 1, 0, 1, 0, 0, 0},
		{ 0, 0, 1, 0, 1, 0, 0},
		{ 0, 1, 0, 1, 0, 0, 0},
		{ 0, 0, 1, 0, 1, 0, 0},
		{ 0, 1, 0, 1, 0, 0, 0},
		{ 0, 0, 1, 0, 1, 0, 0},
		{ 0, 1, 0, 1, 0, 0, 0},
		{ 0, 0, 0, 0, 0, 0, 0}
		};

        int startTimeMs;
        int endTimeMs;

		public Level()
        {
            setupLevel();
			startTimeMs = Time.now;
            endTimeMs = Time.now + 20000;



        }

        void Update()
        {

            if (Time.now > endTimeMs)
            {
                Console.WriteLine("END GAME");
            }
        }

        
        void createTile(int row, int col, int tile)
        {
            if (tile == 1)
            {
                Ufo ufo = new Ufo();
                AddChild(ufo);
                ufo.x = col * SIZE;
                ufo.y = row * SIZE;


            }
        }

        void setupLevel()
        {
            for (int row = 0; row < HEIGHT; row++)
            {
                for (int col = 0; col < WIDTH; col++)
                {
                    int tile = level[row, col];
                    createTile(col, row, tile);
                }
            }
        }
    }
}
