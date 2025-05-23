using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;
    // GameObject �ᵵ ��. Transform �� ���� �� ȿ�� ���ٰ� ��.

    public GameObject bulletPrefab; // �Ѿ� ������
    public Transform firePos; // �߻� ��ġ

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
