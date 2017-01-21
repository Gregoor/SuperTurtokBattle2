using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    float speed = 500;

    [SerializeField]
    int player;

    void Update()
    {

        transform.Rotate(0, Input.GetAxis("Rotation player " + player) * speed * Time.deltaTime, 0);

        GetComponent<CharacterController>()
            .SimpleMove((
                            Vector3.right * Input.GetAxis("Horizontal player " + player)
                            + Vector3.forward * Input.GetAxis("Vertical player " + player)
                        ) * Time.fixedDeltaTime * speed);

    }
}
