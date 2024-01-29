using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_Properties_in_C__Coding_Exercise
{
    public class Book
    {
        // Create private fields to store data
        private string _title;
        private int _pages;

        public void setTitle(string title)
        {
            if (title == "")
            {
                _title = "Unknown";
            }
            else
            {
                _title = title;
            }
        }

        public string GetTitle()
        {
            return _title + " is the name of the book";
        }

        public void setPages(int pages)
        {
            if (pages < 1)
            {
                _pages = 1;
            }
            else
            {
                _pages = pages;
            }
        }

        public int GetPages()
        {
            return _pages;
        }
    }
}
