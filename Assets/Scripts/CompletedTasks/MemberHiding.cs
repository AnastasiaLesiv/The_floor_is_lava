using UnityEngine;
namespace MainPlayer.UnityEngine
{
    public class FriedChicken
    {
        //Base version of the Yell method
        public void AddHealth()
        {
            Debug.Log ("Fried chicken gives the player 5 percent health.");
        }
    }
    public class Meat : FriedChicken
    {
        //This hides the Humanoid version.
        new public void AddHealth()
        {
            Debug.Log ("Meat can restore the player's health only up to 40 percents.");
        }
    }
    public class Food : Meat
    {
        //This hides the Enemy version.
        new public void AddHealth()
        {
            Debug.Log ("Food can completely restore the player's health.");
        }
    }
    public class RestoreHealth : MonoBehaviour 
    {
        void Start () 
        {
            FriedChicken chiken = new FriedChicken();
            Meat meat = new Meat();
            Food food = new Food();

            //Notice how each Humanoid variable contains
            //a reference to a different class in the
            //inheritance hierarchy, yet each of them
            //calls the Humanoid Yell() method.
            chiken.AddHealth();
            meat.AddHealth();
            food.AddHealth();
        }
    }
}