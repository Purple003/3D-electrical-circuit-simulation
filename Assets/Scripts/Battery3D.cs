using UnityEngine;

public class Battery3D : MonoBehaviour
{
    [Tooltip("Voltage de la batterie en volts (V)")]
    public float voltage = 9f;

    // Cette fonction renvoie la tension de la batterie
    public float GetVoltage()
    {
        return voltage;
    }
}
