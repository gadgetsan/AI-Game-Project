using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class GameEvent
{
    public string Type;
    public Collider Source;
    public List<string> Categories;
    int Value;

    public GameEvent(Collider source)
    {
        this.Source = source;
    }
}