using Godot;
using System;

public partial class GPong : Node2D
{

    int ScorePlayer01 = 0;
    int ScorePlayer02 = 0;



    public void OnButtonPressed()
    {
        GetNode<CharacterBody2D>("Ball").Call("Start");
        GetNode<Button>("UI/Button").Visible = false;
        GetNode<Sprite2D>("UI/00Bg").Visible = false;
        GetNode<CharacterBody2D>("Ball").GlobalPosition = new Vector2(GetViewportRect().Size.X/2, GetViewportRect().Size.Y/2);
    }

    public void OnVisibleOnScreenNotifier2dScreenExited()
    {
        if(GetNode<CharacterBody2D>("Ball").GlobalPosition.X <= 0)
        {
            ScorePlayer02 =+ 1;
            GetNode<Label>("UI/HBoxContainer/Label2").Text = ScorePlayer02.ToString();
        }

        else
        {
            ScorePlayer01 += 1;
            GetNode<Label>("UI/HBoxContainer/Label").Text = ScorePlayer01.ToString();
        }

        //GetNode<CharacterBody2D>("Ball").Call("Start");
        GetNode<Button>("UI/Button").Visible = true;
        GetNode<Sprite2D>("UI/00Bg").Visible = true;


    }
}
