using Bibliotekarz.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Bibliotekarz.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}

            //System.Collections.ArrayList zwyklaLista = new System.Collections.ArrayList();
            //zwyklaLista.Add("Leszek");
            //zwyklaLista.Add(4);
            //zwyklaLista.Add(new Book());

            //if (zwyklaLista[0] is int)
            //{ 
            //    int element = (int)zwyklaLista[0];
            //}

            //BookList.Add(new Book());
            //Book book = BookList[3];

            //Dictionary<int, Book> slownik = new Dictionary<int, Book>();
            //slownik.Add(1, new Book());
            //book = slownik[1];
            ////slownik.Add(1, new Book()); //Nie zadzia³a

            //Queue<string> kolejka = new Queue<string>();
            //kolejka.Enqueue("Leszek");
            //string name = kolejka.Dequeue();
            //string name2 = kolejka.Peek();

            //Stack<string> stos = new Stack<string>();
            //stos.Push("Leszek");
            //string name3 = stos.Pop(); //stos.Peek();

            //List<Book>

            GenerateFakeData();
        }

        private void GenerateFakeData()
        {
            BookList = new ObservableCollection<Book>();
            //{
            //    new Book{},
            //    new Book{},
            //    new Book{},
            //    new Book{},
            //};

            Book book = new Book();
            book.Id = 1;
            book.Author = "Leszek Lewandowski";
            book.Title = "Programowanie w C#";
            book.PageCount = 456;
            book.IsBorrowed = false;

            BookList.Add(book);

            BookList.Add(new Book()
            {
                Id = 2,
                Author = "John Newman",
                PageCount = 345,
                Title = "Tytu³ ksi¹¿ki",
                IsBorrowed = true,
                Borrower = new Customer
                {
                    Id = 1,
                    FirstName = "Leszek",
                    LastName = "Lewandowski"
                }
            });
        }

        public ObservableCollection<Book> BookList { get; set; }

        public ICommand CloseCommand
        {
            get
            {
                return new RelayCommand(Close);
            }
        }

        private void Close()
        {
            Environment.Exit(0);
        }
    }
}