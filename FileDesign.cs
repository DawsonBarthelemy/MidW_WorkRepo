using Godot;
using System;

public partial class FileDesign : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void _on_hovering()
	{
		GD.Print("Entered");
		Control file = GetNode<Control>("FileClosed");
		Control file2 = GetNode<Control>("FileOpen");
		

		file.Visible = false;
		file2.Visible = true;

	}
	private void _on_exit()
	{
		GD.Print("exited");
		Control file = GetNode<Control>("FileClosed");
		Control file2 = GetNode<Control>("FileOpen");
		
		file.Visible = true;
		file2.Visible = false;
	}
}
