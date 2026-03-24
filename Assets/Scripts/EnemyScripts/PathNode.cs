using UnityEngine;

public class PathNode : MonoBehaviour
{
    public float speed = 5f;

    public Vector3 offset;

    public float delay = 0;

    public Vector3 GetPos()
    {
        return transform.position + offset;
    }

    public virtual void OnArrived()
    {
        
    }
}
