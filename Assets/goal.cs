using UnityEngine;

public class goal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        ball ball = other.GetComponent<ball>();
        if (ball == null) return;

        Debug.Log(name + "- gol!");
        ball.Launch();
    }
}
