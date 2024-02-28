using UnityEngine;
namespace MainPlayer.UnityEngine
{
    using UnityEngine;

    public class Bookshelf : MonoBehaviour
    {
        void Start()
        {
           Novel myNovel = new Novel();

            myNovel.DisplayInfo();
            myNovel.Read();

            Book myBook = new Novel();
            
            myBook.DisplayInfo();
            myBook.Read();
       
           
        }
    }

    public class Book
    {
        public string title;

        public Book()
        {
            Debug.Log("Default Book Constructor Called");
        }

       public virtual void Read()
        {
            Debug.Log("Reading " + title);
        }

        public virtual void DisplayInfo()
        {
            Debug.Log("This is a book titled " + title);
        }
    }

    public class Novel : Book
    {
        public Novel()
        {
            title = "Pride and Prejudice";
            Debug.Log("1st Novel Constructor Called");
        }

        public override void Read()
        {
            base.Read();
            Debug.Log("Reading " + title);
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Debug.Log("This is a book titled " + title);
        }
    }

}