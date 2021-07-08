using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace CustomNodesLinks.Models
{
  public sealed class DiagramNode : NodeModel
  {
    public DiagramNode(string name, Point pos) :
      base(name, pos)
    {
      Name = name;
    }

    public string Name { get; set; }
  }
}
