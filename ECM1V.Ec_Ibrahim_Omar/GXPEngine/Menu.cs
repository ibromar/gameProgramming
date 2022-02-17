using System;
namespace GXPEngine
{
    public class Menu : GameObject
    {
        Button _button;
        bool _hasStarted;

        public Menu() : base()
        {
            _hasStarted = false; 
            _button = new Button();
            AddChild(_button);
            _button.x = (game.width - _button.width) / 2;
            _button.y = (game.height - _button.height) / 2;
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (_button.HitTestPoint(Input.mouseX, Input.mouseY))
                {
                    startGame();
                    hideMenu();
                }
            }
        }

        void hideMenu()
        {
            _button.visible = false;
        }

        void startGame()
        {
            if (_hasStarted == false)
            {
                Spaceship spaceship = new Spaceship();
                AddChild(spaceship);
                Level level = new Level();
                AddChild(level);
                Missile missile = new Missile();
                AddChild(missile);
                

                _hasStarted = true;

                
            }
        }
    }
}
