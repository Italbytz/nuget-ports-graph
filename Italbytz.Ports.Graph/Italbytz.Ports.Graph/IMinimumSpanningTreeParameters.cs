namespace Italbytz.Ports.Graph
{
    public interface IMinimumSpanningTreeParameters
    {
        IUndirectedGraph<string, ITaggedEdge<string, double>> Graph { get; set; }
    }
}
