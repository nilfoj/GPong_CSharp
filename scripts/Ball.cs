using Godot;
using System;

public partial class Ball : CharacterBody2D
{
    //[Export]
    int Speed = 400;


    Vector2 direction;


    public override void _Ready()
    {
        //direction = new Vector2 (-1 * Speed, 1 * Speed);
        //direction = new Vector2 (-Mathf.Abs(Speed), Mathf.Abs(Speed));
        direction = new Vector2(GD.RandRange(-3, 3) * Speed, GD.RandRange(-3, 3) * Speed);
    }


    public override void _PhysicsProcess(double delta)
    {
        var collision = MoveAndCollide(direction * (float)delta);
        var touchingWalls = ((Node)collision.GetCollider()).IsInGroup("Walls");
        var touchingPlayer = ((Node)collision.GetCollider()).IsInGroup("Player");
        if (touchingWalls)
        {
            direction.Y = direction.Y * (-1);
        }
        else if (touchingPlayer)
        {
            direction.X = direction.X * (-1);
        }
    }
}
