using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHealth 
{
    private int health;
    public UnitHealth(int health)
    {
        this.health = health;
    }

    public int GetHealth()
    {
        return health;
    }

}
