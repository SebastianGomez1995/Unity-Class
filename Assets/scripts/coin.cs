using TMPro;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int coinCount = 0;
    public TextMeshProUGUI coinText;

    public Renderer pisoRenderer; 
    public Material materialNuevo;


    public int monedasParaCambiar = 5;
    private bool materialCambiado = false;

    public Transform jugador;
    public Vector3 nuevaPosicionJugador;

    public void AddCoin()
    {
        coinCount++;
        UpdateUI();

        if (!materialCambiado && coinCount >= monedasParaCambiar)
        {
            CambiarTexturaPiso();
            MoverJugador();
        }
    }

    void UpdateUI()
    {
        coinText.text = "Monedas x " + coinCount.ToString();
    }

    void CambiarTexturaPiso()
    {
        if (pisoRenderer != null && materialNuevo != null)
        {
            pisoRenderer.material = materialNuevo;
            materialCambiado = true;
        }
    }

    void MoverJugador()
    {
        if (jugador != null)
        {
            jugador.position = nuevaPosicionJugador;
        }
    }
}
