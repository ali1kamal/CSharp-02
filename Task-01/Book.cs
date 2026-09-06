using System;
using System.Collections.Generic;
using System.Text;

namespace Task_01
{
    public class Book
    {
        public string Title;
        public int Pages;
        public override string ToString()
        {
            return $"book Title: {Title}\nbook pages: {Pages}";
        }
    }
}
