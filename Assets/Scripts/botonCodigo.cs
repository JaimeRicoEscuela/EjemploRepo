using UnityEngine;
using UnityEngine.UI; // Asegúrate de incluir esta librería para trabajar con UI

public class ButtonHandler : MonoBehaviour
{
    // Asigna el botón desde el Inspector de Unity
    public Button myButton;

    void Start()
    {
        // Verifica que el botón esté asignado
        if (myButton != null)
        {
            // Agrega un listener para que el botón ejecute la función cuando se presione
            myButton.onClick.AddListener(OnButtonClick);
        }
    }

    // Esta es la función que se ejecutará cuando el botón sea presionado
    void OnButtonClick()
    {
        // Aquí puedes colocar la funcionalidad que desees ejecutar
        Debug.Log("El botón ha sido presionado.");
        // Ejemplo: Cambiar escena, activar objetos, etc.
    }
}
