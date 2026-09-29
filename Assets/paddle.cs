using UnityEngine;
using UnityEngine.InputSystem;

public class Paddle : MonoBehaviour
{
    public Key upKey = Key.W;
    public Key downKey = Key.S;
    public Key leftKey = Key.A;
    public Key rightKey = Key.D;

    public Key RRKey = Key.E;
    public Key LRKey = Key.Q;
    public float speed = 8f;
    public float limit = 4f;
    public float rotationlimit = 120f; 

    Rigidbody2D rb;
    float input;
    float inputlr;
    float inputro;


    void Start() { rb = GetComponent<Rigidbody2D>(); }

    void Update()
    {
        inputlr = 0;
        input = 0;
        if (Keyboard.current[upKey].isPressed) input += 1;
        if (Keyboard.current[downKey].isPressed) input -= 1;
        if (Keyboard.current[leftKey].isPressed) inputlr += 1;
        if (Keyboard.current[rightKey].isPressed) inputlr -= 1;
        if (Keyboard.current[RRKey].isPressed) inputro -= 1;
        if (Keyboard.current[LRKey].isPressed) inputro += 1;

    }

    void FixedUpdate()
    {
        float y = rb.position.y + input * speed * Time.fixedDeltaTime;
        y = Mathf.Clamp(y, -limit, limit);
        float x = rb.position.x + inputlr * speed * Time.fixedDeltaTime;
        x = Mathf.Clamp(x, -limit, limit);
        float rotation= rb.rotation + inputro * Time.fixedDeltaTime;
        rotation= Mathf.Clamp(rotation, -rotationlimit, rotationlimit);
        rb.MovePosition(new Vector2(x,y));
        rb.MoveRotation(rotation);
    }
}