using UnityEngine;
using UnityEngine.UI;

public class UIObjectSpawner : MonoBehaviour
{
    public Button spawnButton; // Referencja do przycisku, na którym bêdzie obs³ugiwane klikniêcie
    public GameObject uiObjectPrefab; // Prefabrykat obiektu UI do spawnowania
    private Canvas canvas; // Referencja do obiektu Canvas

    void Start()
    {
        // Pobierz obiekt Canvas z hierarchii sceny
        canvas = FindObjectOfType<Canvas>();

        // Dodaj nasz¹ metodê do obs³ugi klikniêcia na przycisku
        spawnButton.onClick.AddListener(SpawnUIObject);
    }

    void SpawnUIObject()
    {
        // Pobierz pozycjê klikniêcia myszy w przestrzeni widoku kamery
        Vector3 clickPosition = Input.mousePosition;

        // Zamieñ pozycjê klikniêcia na pozycjê w przestrzeni œwiata gry
        Vector3 worldPosition;
        RectTransformUtility.ScreenPointToWorldPointInRectangle(canvas.transform as RectTransform, clickPosition, Camera.main, out worldPosition);

        // Spawnowanie obiektu UI w miejscu klikniêcia jako dziecka obiektu Canvas
        GameObject spawnedUIObject = Instantiate(uiObjectPrefab, worldPosition, Quaternion.identity, canvas.transform);
    }
}






