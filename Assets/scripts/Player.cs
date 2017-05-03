using UnityEngine;

public class Player : MonoBehaviour {

    private readonly string[] colourStrings = { "purple", "orange", "teal", "yellow" };
    private readonly Color[] colours = {
        new Color(132, 0, 205, 255),
        new Color(255, 116, 0, 255),
        new Color(0, 195, 195, 255),
        new Color(255, 255, 0, 255)
    };

    private Rigidbody2D rb;
    private SpriteRenderer sr;
	private float jumpForce = 10f;
    private string currentColour;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        SetRandomColour();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == currentColour)
        {

        }
    }

    private void SetRandomColour()
    {
        int index = Random.Range(0, 3);
        currentColour = colourStrings[index];
        sr.color = colours[index];
    }

}
