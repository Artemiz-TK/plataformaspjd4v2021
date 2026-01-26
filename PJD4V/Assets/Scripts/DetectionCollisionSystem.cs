using UnityEngine;

public class DetectionCollisionSystem : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabs;    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject target in prefabs) {
                target.SetActive(true);
            }
        }
    }
}
