using UnityEngine;

public class Player : MonoBehaviour {

    private readonly string[] colourStrings = { "purple", "orange", "teal", "yellow" };
    private readonly Color[] colours = {
        new Color(132f / 255f, 0, 205f / 255f),
        new Color(255f / 255f, 116f / 255f, 0),
        new Color(0, 195f / 255f, 195f / 255f),
        new Color(255f / 255f, 255f / 255f, 0)
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
        if (other.tag == "colourChanger")
        {
            SetRandomColour();
            Destroy(other.gameObject);
            return;
        }

        if (other.tag != currentColour)
        {
            Debug.Log("Game Over!");
        }
    }

    private void SetRandomColour()
    {
        int index = Random.Range(0, 4);
        currentColour = colourStrings[index];
        sr.color = colours[index];
    }

}
