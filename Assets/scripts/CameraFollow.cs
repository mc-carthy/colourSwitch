using UnityEngine;

public class CameraFollow : MonoBehaviour {

	private Transform player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (player.position.y > transform.position.y)
        {
            transform.position = new Vector3(0, player.transform.position.y, transform.position.z);
        }
    }

}
