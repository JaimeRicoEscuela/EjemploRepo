using UnityEngine;
using UnityEngine.UI;  // Necesario para trabajar con UI

public class CameraFollow2D : MonoBehaviour
{
    public Transform target;    // El objeto al que la cámara seguirá (el personaje)
    public float smoothSpeed = 0.125f;   // Velocidad de suavizado
    public Vector3 offset;  // Desplazamiento entre la cámara y el personaje

    // Slider de UI para ajustar la posición Z de la cámara
    public Slider zPositionSlider;

    void Start()
    {
        // Inicializamos el valor del slider con la posición Z actual de la cámara
        if (zPositionSlider != null)
        {
            zPositionSlider.value = transform.position.z;
            zPositionSlider.onValueChanged.AddListener(UpdateCameraZPosition);  // Vinculamos el método a la interacción del slider
        }
    }

    void LateUpdate()
    {
        // La posición deseada es la posición del objetivo (personaje) más el offset
        Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, transform.position.z) + offset;

        // Interpolamos suavemente entre la posición actual de la cámara y la posición deseada
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Aplicamos la posición suavizada a la cámara
        transform.position = smoothedPosition;
    }

    // Función que se llama cuando el slider cambia de valor
    public void UpdateCameraZPosition(float value)
    {
        // Actualizamos la posición Z de la cámara con el valor del slider
        transform.position = new Vector3(transform.position.x, transform.position.y, value);
    }
}
