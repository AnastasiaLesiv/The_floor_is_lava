using System;
using UnityEngine;

namespace MainPlayer.UnityEngine
{
    public class Inventory{}
    [Serializable]
    public class Weapon : Inventory{}

    public class Bow : Weapon
    {
        public void Sound()
        {
            Debug.Log("Whizz");
        }
    }
    public class Knife: Weapon
    {
        public void Sound()
        {
            Debug.Log("Swish");
        }
    }
    public class Pistol : Weapon
    {
        public void Sound()
        {
            Debug.Log("Pop");
        }
    }
    public class PlayerArsenal
    {
        [SerializeReference]
        public Weapon rareWeapon = new Bow();
        private Weapon[] weaponOfChoice;
        
        public PlayerArsenal()
        {
            weaponOfChoice = new Weapon[2];
            weaponOfChoice[0] = new Knife();
            weaponOfChoice[1] = new Pistol();
            if (weaponOfChoice[0] is Knife)
            {
                Knife knife = weaponOfChoice[0] as Knife;
                knife.Sound();
            }
            if (weaponOfChoice[1] is Pistol)
            {
                Pistol pistol = (Pistol)weaponOfChoice[1];
                pistol.Sound();
            }
        }
    }
    
}