using UnityEngine;

public class Path3D : MonoBehaviour
{
    public PathNode[] pathNodes;

    private void Awake()
    {
        pathNodes = GetComponentsInChildren<PathNode>();
    }

    public PathNode GetNode(int index)
    {
        return pathNodes[index];
    }

    public bool OutOfBounds(int index)
    {
        return index > pathNodes.Length;
    }
}