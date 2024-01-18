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
        GetNode<Sprite2D>("UI/00Bg").Visible=false;
    }

    public void OnVisibleOnScreenNotifier2dScreenExited()
    {
        if(GetNode<CharacterBody2D>("Ball").GlobalPosition.X<=0)
        {
            ScorePlayer02 = ScorePlayer02 + 1;
            GetNode<Label>("UI/HBoxContainer/Label2").Text=ScorePlayer02.ToString();
        }

        else
        {
            ScorePlayer01 = ScorePlayer01 +1;
            GetNode<Label>("UI/HBoxContainer/Label1").Text = ScorePlayer01.ToString();
        }

    }
}
