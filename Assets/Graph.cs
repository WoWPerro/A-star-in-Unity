using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph
{
    List<Node> nodes;

    public Graph()
    {
        nodes = new List<Node>();
    }

    public void Initialize()
    {
        Edge edge1 = new Edge(1);
        Edge edge2 = new Edge(3);
        Edge edge3 = new Edge(3);
        Edge edge4 = new Edge(3);
        Edge edge5 = new Edge(3);
        Edge edge6 = new Edge(3);
        Edge edge7 = new Edge(3);
        Edge edge8 = new Edge(3);
        Edge edge9 = new Edge(3);
        Edge edge10 = new Edge(3);
        Edge edge11 = new Edge(3);
        Node node1 = new Node(new Vector2(2,3), 10);
        Node node2 = new Node(new Vector2(2,4), 12);
        Node node3 = new Node(new Vector2(4,3), 3);
        Node node4 = new Node(new Vector2(2,5), 14);
        Node node5 = new Node(new Vector2(2,6), 16);
        Node node6 = new Node(new Vector2(3,5), 13);
        Node node7 = new Node(new Vector2(6,5), 3);
        Node node8 = new Node(new Vector2(9,9), 7);
        Node node9 = new Node(new Vector2(9,0), 0);
        edge1.SetNodes(ref node1, ref node2);
        edge2.SetNodes(ref node1, ref node3);
        edge3.SetNodes(ref node2, ref node3);
        edge4.SetNodes(ref node2, ref node4);
        edge5.SetNodes(ref node4, ref node5);
        edge6.SetNodes(ref node5, ref node8);
        edge7.SetNodes(ref node4, ref node6);
        edge8.SetNodes(ref node6, ref node3);
        edge9.SetNodes(ref node3, ref node7);
        edge10.SetNodes(ref node7, ref node9);
        edge11.SetNodes(ref node8, ref node9);
        node1.SetEdgeList(new List<Edge>{edge1, edge2});
        node2.SetEdgeList(new List<Edge>{edge1, edge3, edge4});
        node3.SetEdgeList(new List<Edge>{edge2, edge3, edge8, edge9});
        node4.SetEdgeList(new List<Edge>{edge4, edge7, edge5});
        node5.SetEdgeList(new List<Edge>{edge5, edge6});
        node6.SetEdgeList(new List<Edge>{edge7, edge8});
        node7.SetEdgeList(new List<Edge>{edge9, edge10});
        node8.SetEdgeList(new List<Edge>{edge6, edge11});
        node9.SetEdgeList(new List<Edge>{edge10, edge11});
    }
}
