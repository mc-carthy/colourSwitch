using UnityEngine;

public class Rotator : MonoBehaviour {

	private float rotSpeed = 100f;

    private void Update()
    {
        transform.Rotate(0, 0, rotSpeed * Time.deltaTime);
    }

}
