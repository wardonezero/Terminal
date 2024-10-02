using BinaryTreeProject;
using QueueProject;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Terminal;
using static System.Console;
//1
MyBinaryTreeNode<int> tree = new(4);
tree.Left = new(2);
tree.Left.Left = new(1);
tree.Left.Right = new(3);
tree.Right = new(8);
tree.Right.Left = new(6);
tree.Right.Left.Left = new(5);
tree.Right.Left.Right = new(7);
MyBinaryTree<int> mytree = new();
mytree._head = tree;
mytree.Remove(8);

    Write($" {mytree._head.Right.Value}");