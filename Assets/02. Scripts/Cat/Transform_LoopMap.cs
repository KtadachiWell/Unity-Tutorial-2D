using UnityEngine;

public class InfiniteBackground : MonoBehaviour
{
    [Header("��ũ�� ����")]
    public float scrollSpeed = 8f;

    [Header("��� ��������Ʈ��")]
    public Transform background1;
    public Transform background2;

    public Camera cam;
    private float backgroundWidth;

    void Start()
    {
        cam = Camera.main;

        // ��� ��������Ʈ�� �ʺ� ���
        SpriteRenderer spriteRenderer = background1.GetComponent<SpriteRenderer>();
        backgroundWidth = spriteRenderer.bounds.size.x;

        // �� ��° ����� ù ��° ��� �����ʿ� ��ġ
        background2.position = new Vector3(background1.position.x + backgroundWidth, background1.position.y, background1.position.z);
    }

    void Update()
    {
        // ������ �������� �̵�
        background1.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
        background2.Translate(Vector3.left * scrollSpeed * Time.deltaTime);

        // ī�޶��� ���� ��� ���
        float cameraLeftEdge = cam.transform.position.x - cam.orthographicSize * cam.aspect;

        // ���1�� ī�޶� ���� ������ ����� ��
        if (background1.position.x + backgroundWidth * 0.7f < cameraLeftEdge)
        {
            // ���1�� ���2�� ���������� �̵�
            background1.position = new Vector3(background2.position.x + backgroundWidth, background1.position.y, background1.position.z);
        }

        // ���2�� ī�޶� ���� ������ ����� ��
        if (background2.position.x + backgroundWidth * 0.7f < cameraLeftEdge)
        {
            // ���2�� ���1�� ���������� �̵�
            background2.position = new Vector3(background1.position.x + backgroundWidth, background2.position.y, background2.position.z);
        }
    }
}