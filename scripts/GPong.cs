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


}
