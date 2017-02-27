using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    abstract class LibraryItem
    {
        private int _numCopies;
        public int NumCopies {get;set;}
        public abstract void Display();
    }
    class Book:LibraryItem
    {
        private string _author;
        public Book(string author, int numCopies)
        {
            this._author = author;
            this.NumCopies = numCopies;
        }
        public override void Display()
        {
            Console.WriteLine("Book");
            Console.WriteLine("copies: {0}", NumCopies);
        }
    }
    class Video:LibraryItem
    {
        private string _director;
        public Video(string director,int numCopies)
        {
            _director = director;
            this.NumCopies = numCopies;
        }
        public override void Display()
        {
            Console.WriteLine("Video");
            Console.WriteLine("Copies {0}", NumCopies);
        }
    }
    abstract class Decorator:LibraryItem
    {
        protected LibraryItem _libraryItem;
        public Decorator(LibraryItem libraryItem)
        {
            _libraryItem = libraryItem;
        }
        public override void Display()
        {
            _libraryItem.Display();
        }
    }
    class Borrowable :Decorator
    {
        protected List<string> borrowers = new List<string>();

        public Borrowable(LibraryItem libraryItem):base(libraryItem)
        {

        }
        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            _libraryItem.NumCopies++;
        }
        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            _libraryItem.NumCopies--;
        }
        public override void Display()
        {
            base.Display();
            foreach(string s in borrowers)
            {
                Console.WriteLine("borrower " + s);
            }
        }
    }
    public class DecoratorTest
    {
        public static void Test()
        {
            Book b = new Book("aa", 1);
            b.Display();

            Video v = new Video("b", 91);
            v.Display();

            Borrowable bo = new Borrowable(v);
            bo.BorrowItem("c1");
            bo.BorrowItem("c2");
            bo.Display();
        }
    }
}
