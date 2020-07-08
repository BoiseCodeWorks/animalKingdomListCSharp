using System.Collections.Generic;

namespace AnimalKingdom.Models
{
  public class Node
  {
    public string Name { get; set; }
    public Node Parent { get; set; }
    public List<Node> Children { get; set; }

    public Node(string name)
    {
      Name = name;
      Children = new List<Node>();
    }

    public void AddNode(Node child)
    {
      Children.Add(child);
    }
  }
}