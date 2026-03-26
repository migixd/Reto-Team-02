

using UnityEngine;
using UnityEngine.InputSystem;
using InputSystem = UnityEngine.InputSystem;
public class Move : MonoBehaviour
{
   public float speed =5f;
   public float jumpForce = 5f;
   public bool isGrounded = true;
    public float minGroundNormalY = 0.5f;
   private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Move requiere un Rigidbody en el mismo GameObject.");
        }
    }

    // Update is called once per frame
    void Update() 
    {

        if (Keyboard.current.wKey.isPressed)
        {
            Vector3 direction = new Vector3(0, 0, 1);
            transform.Translate(direction * speed * Time.deltaTime);
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            Vector3 direction = new Vector3(0, 0, -1);
            transform.Translate(direction * speed * Time.deltaTime);
        }
        else if (Keyboard.current.aKey.isPressed)
        {
            Vector3 direction = new Vector3(-1, 0, 0);
            transform.Translate(direction * speed * Time.deltaTime);
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            Vector3 direction = new Vector3(1, 0, 0);
            transform.Translate(direction * speed * Time.deltaTime);
        } 
        else if (Keyboard.current.spaceKey.wasPressedThisFrame && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
       
    }

    private void OnCollisionStay(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            if (contact.normal.y >= minGroundNormalY)
            {
                isGrounded = true;
                return;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
