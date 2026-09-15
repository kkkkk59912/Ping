using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField]
    float speed = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Text");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed, speed, 0f);
    }
}
