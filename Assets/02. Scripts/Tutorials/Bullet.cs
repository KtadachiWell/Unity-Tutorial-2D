using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform targetTf;
    public float bulletSpeed = 50f;

    public void TargetLookAt()
    {
        this.transform.LookAt(targetTf.GetChild(0));
        transform.Rotate(90, 0, 0);
    }

    private void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * bulletSpeed * Time.deltaTime;
        // Vector3.foward는 월드 상에서의 앞을 의미함.

        TargetLookAt();

        Destroy(this.gameObject, 0.4f);
    }
}
