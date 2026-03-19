

using UnityEngine;
using UnityEngine.InputSystem;
using InputSystem = UnityEngine.InputSystem;
public class Move : MonoBehaviour
{
   public float speed =5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
        else if (Keyboard.current.wKey.isPressed && Keyboard.current.aKey.isPressed)
        {
            Vector3 direction = new Vector3(-1, 0, 1).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
        }
        else if (Keyboard.current.wKey.isPressed && Keyboard.current.dKey.isPressed)
        {
            Vector3 direction = new Vector3(1, 0, 1).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
        }
        else if (Keyboard.current.sKey.isPressed && Keyboard.current.aKey.isPressed)
        {
            Vector3 direction = new Vector3(-1, 0, -1).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
        }
        else if (Keyboard.current.sKey.isPressed && Keyboard.current.dKey.isPressed)
        {
            Vector3 direction = new Vector3(1, 0, -1).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}
