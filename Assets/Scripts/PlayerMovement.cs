using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    float speed = 500;

    [SerializeField]
    int player;

    void Update()
    {
        var movement = 
                    (Vector3.right * Input.GetAxis("Horizontal player " + player)
                   + Vector3.forward * Input.GetAxis("Vertical player " + player))
                   * Time.fixedDeltaTime * speed;
        
        GetComponent<CharacterController>()
        .SimpleMove(movement);

        Vector3 relativePos = (new Vector3(-Input.GetAxisRaw("Vertical player " + player), 0, Input.GetAxisRaw("Horizontal player " + player))) * Time.fixedDeltaTime * (speed / 2);

        if (relativePos != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(relativePos);
        }

        //Debug.Log(Input.GetAxis("Horizontal player " + player));
    }
       
}
