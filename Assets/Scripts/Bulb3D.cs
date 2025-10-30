using UnityEngine;

public class Bulb3D : MonoBehaviour
{
    [Tooltip("Résistance de l’ampoule (en Ohms)")]
    public float resistance = 10f;

    [Tooltip("Lumière qui représente la brillance de l’ampoule")]
    public Light bulbLight;

    [Tooltip("Intensité maximale de la lumière quand le courant est fort")]
    public float maxIntensity = 5f;

    // Appelé automatiquement si le composant Light est un enfant
    private void Reset()
    {
        bulbLight = GetComponentInChildren<Light>();
    }

    public float GetResistance()
    {
        return resistance;
    }

    public void SetCurrent(float current)
    {
        // Le courant contrôle la luminosité : plus de courant = plus de lumière
        float brightness = Mathf.Clamp01(current * 0.2f); // tu peux ajuster 0.2f
        if (bulbLight != null)
        {
            bulbLight.intensity = brightness * maxIntensity;
        }
    }
}
