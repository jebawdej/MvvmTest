using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Wpf_EF_MVVM
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        AuthorBookEntities ctx = new AuthorBookEntities();

        public MainWindowViewModel()
        {
            FillAuthors();
        }

        private void FillAuthors()
        {
            var q = (from a in ctx.Author
                     select a).ToList();
            this.Authors = q;
        }

        private List<Author> _authors;
        public List<Author> Authors
        {
            get
            {
                return _authors;
            }
            set
            {
                _authors = value;
                NotifyPropertyChanged();
            }
        }

        private Author _selectedAuthor;
        public Author SelectedAuthor
        {
            get
            {
                return _selectedAuthor;
            }
            set
            {
                _selectedAuthor = value;
                NotifyPropertyChanged();
                FillBook();
            }
        }

        private void FillBook()
        {
            Author author = this.SelectedAuthor;

            var q = (from book in ctx.Book
                     orderby book.Title
                     where book.AuthorId == author.AuthorId
                     select book).ToList();

            this.Books = q;
        }

        private List<Book> _books;
        public List<Book> Books
        {
            get
            {
                return _books;
            }
            set
            {
                _books = value;
                NotifyPropertyChanged();
            }
        }

        private Book _selectedBook;
        public Book SelectedBook
        {
            get
            {
                return _selectedBook;
            }
            set
            {
                _selectedBook = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
