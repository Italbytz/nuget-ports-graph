using System;
namespace Italbytz.Ports.Graph
{
    public interface ITaggedEdge<TVertex, TTag> : IEdge<TVertex>, ITagged<TTag>
    {
    }
}
