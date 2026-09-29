using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField]
    float speed = 0.1f;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Launch();
    }

    // Update is called once per frame
    public void Launch()
    {
        transform.position = Vector2.zero;
        rb.linearVelocity = new Vector2(1, 1).normalized * speed;
    }
}
