using UnityEngine;
using UnityEngine.Rendering;

public class move : MonoBehaviour
{
    public float speed = 10.0f;
    public float inputHorizontal;
    public float inputVertical;
    public float inputSpace;
    public float XmaxRt = 8.5f;
    public float XmaxLt = -9.3f;
    public float YmaxLt = -19.15f;
    public float YmaxRt = 13.19f;
    public bool cambiaObjeto = false;


    public GameObject miObjeto;
    public GameObject balaDoble;
    void Start()
    {
        
    }

    
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical = Input.GetAxis("Vertical");
        inputSpace = Input.GetAxis ("Jump"); ;



        transform.Translate(Vector3.up * inputSpace * speed * Time.deltaTime);
        if ((inputHorizontal > 0 && transform.position.x < XmaxRt) || (inputHorizontal < 0 && transform.position.x > XmaxLt))
        {
            transform.Translate(Vector3.right * inputHorizontal * speed * Time.deltaTime);
        }
        if ((inputVertical > 0 && transform.position.z < YmaxRt) || (inputVertical < 0 && transform.position.z > YmaxLt))
        {
            transform.Translate(Vector3.forward * inputVertical * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.V)) {
            cambiaMiObjeto(); // identacion del objeto, con la posicion del persoje, quaternion sirve para controlar la rotacion del objeto creado
        }

        
    }

    private void cambiaMiObjeto()
    {
        if (cambiaObjeto == true)
        {
            Instantiate(balaDoble, transform.position, Quaternion.identity);
        }
        else {
            Instantiate(miObjeto, transform.position, Quaternion.identity);
        }
        
    }
}
