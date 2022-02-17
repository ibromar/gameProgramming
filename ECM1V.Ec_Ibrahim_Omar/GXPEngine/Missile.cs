using System;
namespace GXPEngine
{
    public class Missile : Sprite
    {
        
        Missile missile;
        Sound _missileSound;
        HUD hud;

        public Missile() : base("missile.png")
        {
            //this.x = 380;
            //this.y = 700;
            _missileSound = new Sound("explosion.mp3", false, false);
            
        }

        

        void Update()
        {
            SearchHud();    
            y = y - 2;

        }

        void OnCollision (GameObject other)
        {
            
            if (other is Ufo)
            {
                _missileSound.Play();
                other.LateDestroy();
                LateDestroy();
                hud.increaseScore();
                
                    
              
            }
        }
        void SearchHud()
        {
            if (hud == null)
            {
                hud = game.FindObjectOfType<HUD>();
            }
        }
        
    }
}
