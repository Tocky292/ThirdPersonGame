using UnityEngine;

public class Path3D : MonoBehaviour
{
    public PathNode[] pathNodes;

    public PathNode GetNode(int index)
    {
        return pathNodes[index];
    }

    public bool OutOfBounds(int index)
    {
        return index > pathNodes.Length;
    }
}