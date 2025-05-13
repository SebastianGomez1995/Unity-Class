using UnityEngine;

public class testClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Mi nombre es: "+name);
        // Debug.Log("Mi posicion en x es: "+ this.transform.position);
        this.transform.position = new Vector3(100, 100, 100);   // se puede asignar un vector 3 con sus valores
        Debug.Log("posicion en x es: "+ this.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        //.Log("Hello World Unity engine");
    }
}
