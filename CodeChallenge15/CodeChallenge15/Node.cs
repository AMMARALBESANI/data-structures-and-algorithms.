﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge15
{
    public class Node <T>
    {
        public T Value { get; set; }
        
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
