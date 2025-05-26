using UnityEngine;

public class RouletteController : MonoBehaviour
{

    public float rotSpeed;

    public bool isStop; // �Ҹ��� ���� �⺻ false

    private void Start()
    {
        rotSpeed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotSpeed * Time.deltaTime); // Z�� �������� ȸ��
        // Vector3 �� ���� �򰥸��� ������ ȸ��(E) ������ ���� �����ϱ� ����.
        // transform.Rotate(0f,0f,rotSpeed); �� �ص� �������. ��ŸŸ���� ��?��

        // ���콺 ��Ŭ���ϸ� ȸ������ �ö󰡴� ���
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed += 100f;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
            // rotSpeed = 0f; // �ٷ� ����
        }
        else if (isStop == true)
        {
            rotSpeed *= 0.98f; // ������ ���ӽ�Ű�� �� ����
        }

        if (rotSpeed < 0.01f) {

            isStop = false; // �ӵ��� ���� ���㿡 ��������� ���̻� �ȵ��� ���� �Ҹ��� �� �������� ����, �׳� �θ� �������� �����ϸ鼭 ������ ����� �����̴� ���¸� �����ϴϱ�.
            rotSpeed = 0f; // �� ���Ŀ� 0���� �ʱ�ȭ�ؼ� ���� ���� ���·�
        
        }


    }
}
