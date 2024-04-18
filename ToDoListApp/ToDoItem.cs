using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListApp
{
    public class ToDoItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string ToDoText {  get; set; }
        public bool Complete { get; set;}
        public ToDoItem()
        {
            
        }
        public ToDoItem(string ToDoText, bool Complete) 
        { 
            this.ToDoText = ToDoText;
            this.Complete = Complete;
        }
    }
}
