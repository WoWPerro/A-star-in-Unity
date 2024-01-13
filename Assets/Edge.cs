using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge
{
   bool _traversed;
   int _cost;
   private Node _to;
   private Node _from;

   public Edge(int cost)
   {
        _traversed = false;
        _cost = cost;
        
   }

   public void SetNodes(ref Node to, ref Node from)
   {
        _to = to;
        _from = from;
   }

   public int GetCost()
   {
        return _cost;
   }

   public Node GetTo()
   {
        return _to;
   }


   public Node GetFrom()
   {
     
        return _from;
   }

   public bool IsTraversed()
   {
        return _traversed;
   }

   public void SetTraversed(bool traversed)
   {
        _traversed = traversed;    
   }
}
