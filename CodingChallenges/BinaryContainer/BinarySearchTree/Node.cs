using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges.BinaryContainer.BinarySearchTree
{
    class Node
    {
        int _data;
        Node _left;
        Node _right;

        public Node(int item)
        {
            _data = item;
            _left = null;
            _right = null;
        }
    }
}
