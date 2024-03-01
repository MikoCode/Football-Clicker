using UnityEngine;
using UnityEngine.UI;

public class FillSlider : MonoBehaviour
{
    public Slider slider;
    public float fillDuration; // Duration to fill the slider in seconds
    private float targetFill = 0f;
    private float currentFill = 0f;
    private float timer = 0f;
    public bool isFilling;

    void Start()
    {
        // Initialize slider
        slider.value = currentFill;
       
       
    }

    void Update()
    {
        if (isFilling)
        {
            timer += Time.deltaTime;
            currentFill = Mathf.Lerp(0f, targetFill, timer / fillDuration);
            slider.value = currentFill;

            if (currentFill >= targetFill)
            {
                currentFill = 0;
                timer = 0f;
            }
        }
    }

    public void StartFilling(float fillValue)
    {
        if (!isFilling)
        {
            isFilling = true;
            currentFill = 0f;
            targetFill = Mathf.Clamp01(fillValue);
            timer = 0f;
        }
    }
}


