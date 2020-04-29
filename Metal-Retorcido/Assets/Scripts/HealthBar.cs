using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradiente;
    public Image relleno;

    public void SetearVidaMaxima (int vida)
    {
        slider.maxValue = vida;
        slider.value = vida;

        relleno.color = gradiente.Evaluate(1f);
    }

    public void SetearVida(int vida)
    {
        slider.value = vida;

        relleno.color = gradiente.Evaluate(slider.normalizedValue);
    }
}
