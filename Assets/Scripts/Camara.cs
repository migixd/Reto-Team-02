using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject player; // Referencia al jugador
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position =transform.position;
        position.x = player.transform.position.x;
        position.z = player.transform.position.z ; 
        position.y = player.transform.position.y ; 
        transform.position = position;
    }
}
