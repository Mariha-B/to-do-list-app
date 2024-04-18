using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.IO;

namespace ToDoListApp
{
    public class ToDoListViewModel
    {
        private Database _database;
        public ObservableCollection<ToDoItem> ToDoItems { get; set; }
        public ToDoListViewModel()
        {
            _database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "items.db3"));
            LoadToDoItems();
        }
        public ToDoListViewModel(string dbPath)
        {
            _database = new Database(dbPath);
            LoadToDoItems(); 
        }

        public ICommand AddToDoCommand => new Command(AddToDoItem);
        public string NewToDoInputValue { get; set; }
        void AddToDoItem()
        {
            _database.SaveItemAsync(new ToDoItem(NewToDoInputValue, false)); 
            NewToDoInputValue = "";
            ToDoItems.Add(new ToDoItem(NewToDoInputValue, false));
        }

        public ICommand RemoveToDoCommand => new Command(RemoveToDoItem);
        void RemoveToDoItem(object o)
        {
            ToDoItem toDoItemBeingRemoved = o as ToDoItem;
            _database.DeleteItemAsync(toDoItemBeingRemoved);
            ToDoItems.Remove(toDoItemBeingRemoved);
        }

        private void LoadToDoItems()
        {
            List<ToDoItem> items = _database.GetItemsAsync().Result;
            ToDoItems = new ObservableCollection<ToDoItem>(items);
            ToDoItems.Clear(); 
            foreach (var item in items)
            {
                ToDoItems.Add(item); 
            }
        }

    }
}
