using System;
using System.Collections.Generic;

/// <summary> RoomObject class </summary>
public class RoomObjects
{
    enum myType
    {
        Interactive,
        Breakable,
        Collectable
    }

    /// <summary> InteractAction method </summary>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach(Base obj in roomObjects)
        {
            // Do things... 
        }

    }
}
