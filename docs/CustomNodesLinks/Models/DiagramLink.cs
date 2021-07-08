using Blazor.Diagrams.Core.Models;

namespace CustomNodesLinks.Models
{
  public sealed class DiagramLink : LinkModel
  {
    public DiagramLink(string name, NodeModel sourceNode, NodeModel? targetNode) :
      base(name, sourceNode, targetNode)
    {
      Name = name;
      Labels.Add(new DiagramLinkLabel(this, Name));
    }

    public string Name { get; set; }
  }
}
