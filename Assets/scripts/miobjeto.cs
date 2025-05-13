using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class miobjeto : MonoBehaviour
{
    public float speed = 100.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if(transform.position.z > 13.19){
            Destroy(gameObject);
        }
    }
}
