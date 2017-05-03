using UnityEngine;

public class Player : MonoBehaviour {

    private Rigidbody2D rb;
	private float jumpForce = 10f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

}
