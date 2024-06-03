﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class_in_Method
{
    internal class Box<T>
    {
        private T content;

        public Box(T initialValue)
        {
            content = initialValue;
        }

        public void UpdateContent(T newContent)
        {
            content = newContent;
            Console.WriteLine($"Updated content to {content}");
        }

        public T GetContent()
        {
            return content;
        }
    }
}
