using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
        // Vector3.foward는 월드 상에서의 앞을 의미함.

        Destroy(this.gameObject, 0.4f);
    }
}
