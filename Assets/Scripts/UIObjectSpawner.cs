using UnityEngine;
using UnityEngine.UI;

public class UIObjectSpawner : MonoBehaviour
{
    public Button spawnButton; // Referencja do przycisku, na kt�rym b�dzie obs�ugiwane klikni�cie
    public GameObject uiObjectPrefab; // Prefabrykat obiektu UI do spawnowania
    private Canvas canvas; // Referencja do obiektu Canvas

    void Start()
    {
        // Pobierz obiekt Canvas z hierarchii sceny
        canvas = FindObjectOfType<Canvas>();

        // Dodaj nasz� metod� do obs�ugi klikni�cia na przycisku
        spawnButton.onClick.AddListener(SpawnUIObject);
    }

    void SpawnUIObject()
    {
        // Pobierz pozycj� klikni�cia myszy w przestrzeni widoku kamery
        Vector3 clickPosition = Input.mousePosition;

        // Zamie� pozycj� klikni�cia na pozycj� w przestrzeni �wiata gry
        Vector3 worldPosition;
        RectTransformUtility.ScreenPointToWorldPointInRectangle(canvas.transform as RectTransform, clickPosition, Camera.main, out worldPosition);

        // Spawnowanie obiektu UI w miejscu klikni�cia jako dziecka obiektu Canvas
        GameObject spawnedUIObject = Instantiate(uiObjectPrefab, worldPosition, Quaternion.identity, canvas.transform);
    }
}






