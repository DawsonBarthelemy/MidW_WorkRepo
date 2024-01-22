using Godot;
using System;
using System.Runtime.Serialization;


public partial class MainMenuOperations : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//Disable PC Mouse 
		DisplayServer.MouseSetMode(DisplayServer.MouseMode.Hidden);

		//set up custome Files (Tasks and names)
		RichTextLabel PlayFile = GetNode<RichTextLabel>("Home/Play/FileTitle");
		PlayFile.Text = "Play";

		//<--IMPORTANT--> When new levels are added, change currentLevels var
		int currentLevels = 2;   
		for (int i = 1; i <= currentLevels; i++) 
		{
 			RichTextLabel Level = GetNode<RichTextLabel>($"Levels/Level{i}/FileTitle");
			Level.Text = $"Level{i}";

		}





	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		//Custom Mouse rendering
		Vector2 mousepos = GetGlobalMousePosition();
		Polygon2D mouse = GetNode<Polygon2D>("Mouse");
		
        Vector2 updatedpos = new Vector2(mousepos[0] - 160, mousepos[1] - 100);
		mouse.Position =  updatedpos;
		//  ^^^ Updates mousepos


		//TODO add functunality to click "Play"
		Sprite2D play = GetNode<Sprite2D>("Home/Play");

		//TODO add functunality to click "Level{i}"
		//TODO add functunality to click "Settings"

	}
}
