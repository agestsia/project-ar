using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public GameObject healingText;

    void OnMouseDown()
    {
        healingText.SetActive(true);

        Destroy(gameObject);
    }
}