using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float ForceValue = 2000f;
    public float sidewaysForce = 500f;
    public Rigidbody rb;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForceValue * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

         if (Input.GetKey("a"))
         {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
         }  

         if(transform.position.y < 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
