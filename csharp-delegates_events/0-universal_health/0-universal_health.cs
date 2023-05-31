using System;


/// <summary> Player class </summary>
public class Player
{

    protected string name;
    protected float maxHp;
    protected float hp;

    /// <summary> Player Constructor </summary>
    public Player(string name="Player", float maxHp=100f)
    {
        this.name = name;
        if( maxHp <= 0f){
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.maxHp = maxHp;
        this.hp = this.maxHp;
    }

    /// <summary> PrintHealth Method </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }

}
