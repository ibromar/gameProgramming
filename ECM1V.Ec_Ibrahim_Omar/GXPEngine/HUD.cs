using System;
using System.Drawing;
namespace GXPEngine
{
    public class HUD : Canvas
    {
        int _score;
        private Spaceship _spaceship;


        public HUD() : base(500, 64)
        {
            _score = 0;
            increaseScore();
            
           
        }

        public void increaseScore()
        {
         
           _score = ++_score;
        }

        void Update()
        {
            
            graphics.Clear(Color.Empty);
            graphics.DrawString("SCORE:" + _score, SystemFonts.DefaultFont, Brushes.White, 400, 0);
        }
    }
}
