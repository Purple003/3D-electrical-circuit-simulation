using UnityEngine;

public class Switch3D : MonoBehaviour
{
    public Wire3D wire;       // le fil à contrôler
    public bool isOn = true;  // état initial

    void Update()
    {
        if (wire != null && wire.bulb != null)
        {
            // si off, on met la lumière à 0
            wire.bulb.bulbLight.intensity = isOn ? wire.bulb.bulbLight.intensity : 0;
        }
    }

    // Méthode pour basculer l'état (appeler depuis UI ou clavier)
    public void Toggle()
    {
        isOn = !isOn;
    }
}
