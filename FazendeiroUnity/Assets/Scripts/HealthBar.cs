using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public void SetMaxBar(int maxhealth)
    {
        slider.maxValue = maxhealth;
    }
    public void SetBar(int health)
    {
        slider.value = health;
    }
}
