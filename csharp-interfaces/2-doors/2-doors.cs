

///<summary> Door Class </summary>
public class Door : Base, IInteractive
{
    ///<summary> Door Constructor </summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    ///<summary> Interact Method </summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the {}. It's locked.", this.name);
    }
}