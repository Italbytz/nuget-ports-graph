using System.Collections.Generic;

namespace Italbytz.Ports.Graph
{
    public interface IMinimumSpanningTreeSolution
    {
        IEnumerable<ITaggedEdge<string, double>> Edges { get; set; }
    }
}
