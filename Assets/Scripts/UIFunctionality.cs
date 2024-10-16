using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    // Declarar los diferentes elementos de UI
    public Button myButton;
    public Text myText;
    public Image myImage;
    public Slider mySlider;
    public Toggle myToggle;

    void Start()
    {
        // Asignar funcionalidad al botón
        if (myButton != null)
        {
            myButton.onClick.AddListener(OnButtonClick);
        }

        // Configurar el slider para que cambie el texto según el valor
        if (mySlider != null && myText != null)
        {
            mySlider.onValueChanged.AddListener(OnSliderValueChanged);
        }

        // Configurar el toggle para activar/desactivar una imagen
        if (myToggle != null && myImage != null)
        {
            myToggle.onValueChanged.AddListener(OnToggleValueChanged);
        }
    }

    // Función ejecutada cuando el botón es presionado
    void OnButtonClick()
    {
        Debug.Log("Botón presionado");
        myText.text = "¡Botón presionado!";
    }

    // Función ejecutada cuando el valor del slider cambia
    void OnSliderValueChanged(float value)
    {
        myText.text = "Valor del slider: " + value.ToString("0.00");
    }

    // Función ejecutada cuando el estado del toggle cambia
    void OnToggleValueChanged(bool isOn)
    {
        myImage.gameObject.SetActive(isOn);
        Debug.Log("El toggle está " + (isOn ? "activado" : "desactivado"));
    }
}
