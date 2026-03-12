
using UnityEngine;
using UnityEngine.InputSystem;
public class SphereSpawner : MonoBehaviour
{
    public GameObject spherePrefab; // Reference to the sphere prefab

   

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
             GameObject newGameObject=Instantiate(spherePrefab); 
        newGameObject.transform.position = 
            transform.position + new Vector3
            (Random.Range(-0.1f, 0.1f), 
            0f, 
            Random.Range(-0.1f, 0.1f)); 
        }   
    }
}
