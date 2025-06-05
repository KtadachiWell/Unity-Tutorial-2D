using UnityEngine;

public class ColliderEvent : MonoBehaviour
{
    public GameObject fadeUI;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("GameOver");
            fadeUI.SetActive(true);
        }
    }

    private void Update()
    {
        transform.position += Vector3.left * 5.0f * Time.deltaTime;
    }
}
