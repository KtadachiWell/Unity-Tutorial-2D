using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
        // Vector3.foward�� ���� �󿡼��� ���� �ǹ���.

        Destroy(this.gameObject, 0.4f);
    }
}
