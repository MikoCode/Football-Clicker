using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Image progressBar;
    public float fillDuration = 2f; // Duration to fill the progress bar in seconds
    private float fillAmount = 0f;
    private float timer = 0f;
    private bool isFilling = false;

    void Start()
    {
        // Initialize progress bar
        progressBar.fillAmount = fillAmount;
        isFilling= true;
    }

    void Update()
    {
        if (isFilling)
        {
            timer += Time.deltaTime;
            fillAmount = Mathf.Clamp01(timer / fillDuration);
            progressBar.fillAmount = fillAmount;

            if (fillAmount >= 1f)
            {
                isFilling = false;
                timer = 0f;
            }
        }
    }

    public void StartFilling()
    {
        if (!isFilling)
        {
            isFilling = true;
            fillAmount = 0f;
            timer = 0f;
        }
    }
}
