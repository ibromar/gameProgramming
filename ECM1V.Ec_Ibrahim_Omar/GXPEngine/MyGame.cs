using System;									// System contains a lot of default C# libraries 
using GXPEngine;                                // GXPEngine contains the engine
using System.Drawing;							// System.Drawing contains drawing tools such as Color definitions

public class MyGame : Game
{
	Missile missile;
	public MyGame() : base(800, 800, false)		// Create a window that's 800x600 and NOT fullscreen
	{
		
		Menu menu = new Menu();
		AddChild(menu);
		HUD hud = new HUD();
		AddChild(hud);
		//wgfyuwegiuwg 
		ImageID
		



	}

	// For every game object, Update is called every frame, by the engine:
	void Update()
	{
		
	}

	static void Main()							// Main() is the first method that's called when the program is run
	{
		new MyGame().Start();					// Create a "MyGame" and start it
	}
}