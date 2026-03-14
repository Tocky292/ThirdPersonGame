using UnityEngine;

public class PathNodePlank : PathNode
{
    private GameObject plank;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        plank = transform.GetChild(0).gameObject;
        plank.SetActive(false);
    }

    public void PlacePlank()
    {
        plank.SetActive(true);
    }
}
