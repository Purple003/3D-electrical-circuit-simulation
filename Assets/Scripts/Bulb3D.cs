using UnityEngine;

public class Bulb3D : MonoBehaviour
{
    [Tooltip("R�sistance de l�ampoule (en Ohms)")]
    public float resistance = 10f;

    [Tooltip("Lumi�re qui repr�sente la brillance de l�ampoule")]
    public Light bulbLight;

    [Tooltip("Intensit� maximale de la lumi�re quand le courant est fort")]
    public float maxIntensity = 5f;

    // Appel� automatiquement si le composant Light est un enfant
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
        // Le courant contr�le la luminosit� : plus de courant = plus de lumi�re
        float brightness = Mathf.Clamp01(current * 0.2f); // tu peux ajuster 0.2f
        if (bulbLight != null)
        {
            bulbLight.intensity = brightness * maxIntensity;
        }
    }
}
