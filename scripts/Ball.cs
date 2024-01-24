using Godot;
using System;

public partial class Ball : CharacterBody2D
{
    [Export]
    int Speed = 540;


    Vector2 direction;


    public override void _Ready()
    {
        //direction = new Vector2 (-1 * Speed, 1 * Speed);
        //direction = new Vector2 (-Mathf.Abs(Speed), Mathf.Abs(Speed));
        direction = new Vector2(0, 0);
    }


    public override void _PhysicsProcess(double delta)
    {
        var collision = MoveAndCollide(direction * (float)delta);
        if (collision != null)
        {
            var touchingWalls = ((Node)collision.GetCollider()).IsInGroup("Walls");
            var touchingPlayer = ((Node)collision.GetCollider()).IsInGroup("Player");


            if (touchingWalls)
            {
                direction.Y = direction.Y * (-1);
            }

            else if (touchingPlayer)
            {

                if (collision.GetNormal().Y == 1 || collision.GetNormal().Y == -1)
                {
                    direction.Y = direction.Y * (-1 * 1f);
                }

                else
                {
                    direction.X = direction.X * (-1 * 1f);
                }

            }
        }

    }


    public void Start()
    {
        direction = new Vector2(GD.RandRange(-1, 1) * Speed, GD.RandRange(-1, 1) * Speed);
        if((int)direction.Y == 0 || (int)direction.X == 0)
        {
            direction.Y = 1 * Speed;
            direction.X = 1 * Speed;
        }
    }


}
