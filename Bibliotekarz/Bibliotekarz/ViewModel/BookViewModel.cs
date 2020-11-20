using Bibliotekarz.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Windows.Input;

namespace Bibliotekarz.ViewModel
{
    public class BookViewModel : ViewModelBase
    {
        public BookWindow Window;

        public BookViewModel()
        {
            EditedBook = new Book
            {
                Borrower = new Customer()
            };
        }

        public Book EditedBook { get; set; }

        public ICommand SaveCommand => new RelayCommand(Save);

        private void Save()
        {
            Window.DialogResult = true;
            Window.Book = EditedBook;
            Window.Hide();
        }
    }
}
