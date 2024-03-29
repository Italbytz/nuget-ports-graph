﻿using System;
namespace Italbytz.Ports.Graph
{
    /// <summary>
    /// An undirected graph with vertices of type <typeparamref name="TVertex"/>
    /// and edges of type <typeparamref name="TEdge"/>.
    /// </summary>
    /// <typeparam name="TVertex">Vertex type.</typeparam>
    /// <typeparam name="TEdge">Edge type.</typeparam>
    public interface IUndirectedGraph<TVertex, TEdge> : IEdgeSet<TVertex, TEdge> where TEdge : IEdge<TVertex>
    {
        string ToGraphviz();
    }
}
