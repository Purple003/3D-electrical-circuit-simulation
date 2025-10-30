using UnityEngine;
using UnityEngine.UI;

public class VoltageSliderUI : MonoBehaviour
{
    public Slider slider;
    public Battery3D battery;

    void Start()
    {
        if (slider != null && battery != null)
        {
            slider.value = battery.voltage;
            slider.onValueChanged.AddListener(OnSliderChanged);
        }
    }

    void OnSliderChanged(float value)
    {
        if (battery != null)
            battery.voltage = value;
    }
}
