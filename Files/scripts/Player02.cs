using Godot;
public partial class Player02 : CharacterBody2D
{

    //[Export]
    //int IdPlayer = 1;

    [Export]
    int Speed = 700;


    public override void _PhysicsProcess(double delta)
    {

        Movement();
        MoveAndCollide(Velocity * (float)delta);
    }


    public void Movement()
    {
        if (Input.IsActionPressed("UP2"))
        {
            Velocity = new Vector2(0, -Speed);
        }

        else if (Input.IsActionPressed("DOWN2"))
        {
            Velocity = new Vector2(0, Speed);
        }

        else { Velocity = new Vector2(0, 0); }
    }

}