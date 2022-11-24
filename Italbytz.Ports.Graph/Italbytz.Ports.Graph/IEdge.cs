namespace Italbytz.Ports.Graph
{
    /// <summary>
    /// Represents a directed edge.
    /// </summary>
    /// <typeparam name="TVertex">Vertex type.</typeparam>
    public interface IEdge<out TVertex>
    {
        TVertex Source { get; }
        TVertex Target { get; }
    }
}