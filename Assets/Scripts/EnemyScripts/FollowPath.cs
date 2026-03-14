using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public Path3D pathToFollow;

    [Tooltip("- OPTIONAL - If there is a target transform it will change direction along the path based on where the target is. - OPTIONAL -")]
    public Transform targetTransform;

    public int startingNode = 0;

    private int index;

    private float minDistance = 0.1f;

    private Vector3 direction; 

    private PathNode targetNode;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        index = startingNode;
        targetNode = pathToFollow.GetNode(index);
        transform.position = targetNode.GetPos();
        }

    // Update is called once per frame
    void Update()
    {   

        if (Vector3.Distance(transform.position, targetNode.GetPos()) < minDistance)
        {
             transform.position = targetNode.GetPos();
             GetNextTarget();
        }
        else
        {
            transform.position += direction * targetNode.speed * Time.deltaTime;
        }
    }

    void GetNextTarget()
    {
        if ( targetTransform )
        {
            index += ( targetTransform.position.x >= transform.position.x ) ? 1 : -1;
        }
        else 
        {
            index++;
        }

        if (index >= pathToFollow.pathNodes.Length-1)
        {
            index = pathToFollow.pathNodes.Length-1;
        }

        targetNode = pathToFollow.GetNode(index);

        ChangeDirection();
    }

    void ChangeDirection()
    {
        direction = targetNode.GetPos() - transform.position;
        direction.Normalize();
    }
}
