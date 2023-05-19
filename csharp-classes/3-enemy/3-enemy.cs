using System;

namespace Enemies
{
    ///<summary>
    /// Required documentation creates unneeded noise when reading code.
    /// Writing clean self-documenting code is a better practice.
    /// See the book "Clean Code", page 63, Mandated Comments.
    ///
    /// Furthermore, documenting an empty class is just noise.
    /// did We mention that failing to update comments makes them worse?
    ///</summary>
    public class Zombie
    {
        /**
    <summary>
        int health
    </summary>
    */
        private int health;

        /**
        <summary>
            Default Constructor
        </summary>
        */
        public Zombie()
        {
            
        }

        /**
        <summary>
            specific Constructor
        </summary>
        <param name="value"> a terribly named varriable, should be more descriptive</param>
        */
        public Zombie(int value)
        {
            if(value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }

        /**
        <summary>
        Getter for health.
        </summary>
        <returns> the value of this.health </returns>
        */
        public int GetHealth()
        {
            return this.health;
        }
    }
}
