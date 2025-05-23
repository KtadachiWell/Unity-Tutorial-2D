using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;
    // GameObject 써도 됌. Transform 이 조금 더 효율 좋다고 함.

    public GameObject bulletPrefab; // 총알 프리팹
    public Transform firePos; // 발사 위치

    public float timer;
    public float cooldownTime;

    public void TargetLookAt()
    {
        turretHead.LookAt(targetTf.GetChild(0));
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        TargetLookAt();
        timer += Time.deltaTime;
        if (timer >= cooldownTime)
        {

        timer = 0f;
        Instantiate(bulletPrefab, firePos.position, firePos.rotation);

        }

    }
}
