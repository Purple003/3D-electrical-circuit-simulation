using UnityEngine;

public class Switch3D : MonoBehaviour
{
    public Wire3D wire;       // le fil � contr�ler
    public bool isOn = true;  // �tat initial

    void Update()
    {
        if (wire != null && wire.bulb != null)
        {
            // si off, on met la lumi�re � 0
            wire.bulb.bulbLight.intensity = isOn ? wire.bulb.bulbLight.intensity : 0;
        }
    }

    // M�thode pour basculer l'�tat (appeler depuis UI ou clavier)
    public void Toggle()
    {
        isOn = !isOn;
    }
}
