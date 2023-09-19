using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator_design_pattern
{
    public class Borrowable : Decorator
    {
        protected readonly List<string> _borrowers = new List<string>();
        // Constructor
        public Borrowable(LibraryItem libraryItem) : base(libraryItem) { }

        public void BorrowItem(string name)
        {
            if(_libraryItem.NumCopies > 0)
            {
                _borrowers.Add(name);
                _libraryItem.NumCopies--;
            }
            else
            {
                Console.WriteLine("No more available copies!");
            }
        }

        public void ReturnItem(string name)
        {
            _borrowers.Remove(name);
            _libraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();
            foreach (string borrower in _borrowers)
            {
                Console.WriteLine("Borrower: " + borrower);
            }
        }
    }
}
