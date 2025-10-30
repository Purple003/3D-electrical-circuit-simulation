using UnityEngine;

public class CircuitManager3D : MonoBehaviour
{
    [Tooltip("Drag your Wire3D object here")]
    public Wire3D wire;

    [Tooltip("Update simulation every frame")]
    public bool updateEveryFrame = true;

    void Update()
    {
        if (updateEveryFrame)
            SolveCircuit();
    }

    void SolveCircuit()
    {
        if (wire == null || wire.battery == null || wire.bulb == null)
            return;

        float V = wire.battery.GetVoltage();
        float R = wire.bulb.GetResistance();

        if (R <= 0.0001f) R = 0.0001f; // prevent division by zero

        float current = V / R;
        wire.bulb.SetCurrent(current);
    }
}
