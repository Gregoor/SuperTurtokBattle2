using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    float speed = 500;

    [SerializeField]
    int player;

    void Update()
    {
        GetComponent<CharacterController>()
            .SimpleMove((
                            Vector3.right * Input.GetAxis("Horizontal player " + player)
                            + Vector3.forward * Input.GetAxis("Vertical player " + player)
                        ) * Time.fixedDeltaTime * speed);

    }
}
