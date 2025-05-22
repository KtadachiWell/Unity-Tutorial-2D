using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private void Update()
    {
        /// Input System (Old - Legacy)
        /// �Է°��� ���� ��ӵ� �ý���
        /// �̵� -> WASD, ȭ��ǥŰ����
        /// ���� -> Space
        /// �ѽ�� -> ���콺 ����

        // �ε巴�� �����ϴ� ��
        float h = Input.GetAxis("Horizontal"); // wasd�� ȭ��ǥŰ ������ �Ѵ� �۵���
        float v = Input.GetAxis("Vertical"); // ���� ����

        // �� �������� ��
        float h2 = Input.GetAxisRaw("Horizontal");
        float v2 = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        Debug.Log($"���� �Է� : {dir}");

        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}

    // Update is called once per frame
//    void Update()
//    {
//        // moveSpeed = Time.deltaTime;
//        // this.transform.position = transform.position = this.transform.position + Vector3.forward * moveSpeed;
//        // this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime; // ���������� ����ȭ�ؼ� ��ŸŸ�� ���� �� ����
        
//        if (Input.GetKey(KeyCode.W))
//        {
//            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
//        }
//        if (Input.GetKey(KeyCode.A))
//        {
//            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
//        }
//        if (Input.GetKey(KeyCode.S))
//        {
//            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
//        }
//        if (Input.GetKey(KeyCode.D))
//        {
//            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
//        }
//    }
//}
