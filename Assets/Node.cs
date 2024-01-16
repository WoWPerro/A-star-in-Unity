using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    int _h;
    public Vector2 _pos;
    private List<Edge> _Edges;
    bool _visited;
     
    public Node(Vector2 pos, List<Edge> edges, int h)
    {
        _pos = pos;
        _Edges = edges;
        _h = h;
    }

    public Node(Vector2 pos, int h)
    {
        _pos = pos;
        _h = h;
    }

    public void SetEdgeList(List<Edge> edges)
    {
        _Edges = edges;
    }
}
