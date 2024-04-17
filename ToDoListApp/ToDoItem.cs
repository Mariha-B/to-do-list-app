using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListApp
{
    public class ToDoItem
    {
        public string ToDoText {  get; set; }
        public bool Complete { get; set;}

        public ToDoItem(string ToDoText, bool Complete) 
        { 
            this.ToDoText = ToDoText;
            this.Complete = Complete;
        }
    }
}
