using System.Collections.Generic;
using UnityEngine;

public class Level
{
    //define global variables
    public string clue;
    public int numberOfDials;

    //constructor
    public Level(string clue, int numberOfDials)
    {
        this.clue = clue;
        this.numberOfDials = numberOfDials;
    }
}
