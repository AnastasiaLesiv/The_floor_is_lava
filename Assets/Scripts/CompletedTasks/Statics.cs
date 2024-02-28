namespace MainPlayer.UnityEngine
{
    public class Game
    {
        void Start () 
        {
            Bonus enemy1 = new Bonus();
            Bonus enemy2 = new Bonus();
            Bonus enemy3 = new Bonus();

           int x = Bonus.bonusCount;
        }
    }
    public class Bonus
    {
        public static int bonusCount = 0;

        public Bonus()
        {
            bonusCount++;
        }
    }

}