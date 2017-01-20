using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] float speed = 500;

	void Update ()
	{
	    GetComponent<CharacterController>()
	        .SimpleMove((
	                        Vector3.right * Input.GetAxis("Horizontal")
	                        + Vector3.forward * Input.GetAxis("Vertical")
	                    ) * Time.fixedDeltaTime * speed);
	}
}
