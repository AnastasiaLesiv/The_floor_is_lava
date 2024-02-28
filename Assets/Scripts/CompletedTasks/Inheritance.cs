using UnityEngine;
namespace MainPlayer.UnityEngine
{
    public class DollHouse : MonoBehaviour
    {
        void Start()
        {
            Debug.Log("Creating the toy");
            Toy myToy = new Toy();
            Debug.Log("Creating the doll");
            Doll myDoll = new Doll();

            myToy.DisplayInfo();
            myToy.Play();

            myDoll.DisplayInfo();
            myDoll.Play();

            Debug.Log("Creating the toy");
            myToy = new Toy("Action Figure");
            Debug.Log("Creating the Lego");
            myDoll = new Doll("Anabel");

            myToy.DisplayInfo();
            myToy.Play();
           
            myDoll.DisplayInfo();
            myDoll.Play();
        }
    }
   public class Toy
    {
        public string name;

        // Конструктор за замовчуванням для класу Toy.
        public Toy()
        {
            name = "Teddy Bear";
            Debug.Log("Default Toy Constructor Called");
        }

        // Конструктор, який приймає параметр name.
        public Toy(string newName)
        {
            name = newName;
            Debug.Log("Toy Constructor Called with Name: " + newName);
        }

        public void Play()
        {
            Debug.Log("Playing with " + name);
        }

        public void DisplayInfo()
        {
            Debug.Log("I am a toy named " + name);
        }
    }
   
  
   public class Doll : Toy
   {
       public Doll()
       {
           name = "Barbie";
           Debug.Log("1st Doll Constructor Called");
       }

       public Doll(string newName) : base(newName)
       {
           Debug.Log("2nd Doll Constructor Called");
       }
   }


}