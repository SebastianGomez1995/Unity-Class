using UnityEngine;

public class colletable : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colisione con: " + other.name);
        move myObject = other.GetComponent<move>(); // accediendo a las propiedades y metodos de la clase move(jugador)
        if (myObject != null)
        {

            myObject.cambiaObjeto = true;
        }
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
