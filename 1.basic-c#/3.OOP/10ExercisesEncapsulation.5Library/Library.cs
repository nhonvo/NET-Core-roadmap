namespace _10ExercisesEncapsulation._5Library
{
    public class Library
    {
        private List<Book> Books { get; set; }
        private List<Borrower> Borrowers { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Borrowers = new List<Borrower>();
        }

        public void AddBook(Book book)
        {
            if (!Books.Any(b => b.Id == book.Id))
            {
                Books.Add(book);
            }
        }

        public void RemoveBook(Book book)
        {
            if (Books.Any(b => b.Id == book.Id))
            {
                Books.Remove(book);
            }
        }

        public void AddBorrowers(Borrower borrower)
        {
            if (!Borrowers.Any(b => b.Id == borrower.Id))
            {
                Borrowers.Add(borrower);
            }
        }

        public void RemoveBorrowers(Borrower borrower)
        {
            if (Borrowers.Any(b => b.Id == borrower.Id))
            {
                Borrowers.Remove(borrower);
            }
        }
    }
}