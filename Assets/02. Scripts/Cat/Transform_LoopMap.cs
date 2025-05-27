using UnityEngine;

public class InfiniteBackground : MonoBehaviour
{
    [Header("스크롤 설정")]
    public float scrollSpeed = 8f;

    [Header("배경 스프라이트들")]
    public Transform background1;
    public Transform background2;

    public Camera cam;
    private float backgroundWidth;

    void Start()
    {
        cam = Camera.main;

        // 배경 스프라이트의 너비 계산
        SpriteRenderer spriteRenderer = background1.GetComponent<SpriteRenderer>();
        backgroundWidth = spriteRenderer.bounds.size.x;

        // 두 번째 배경을 첫 번째 배경 오른쪽에 배치
        background2.position = new Vector3(background1.position.x + backgroundWidth, background1.position.y, background1.position.z);
    }

    void Update()
    {
        // 배경들을 왼쪽으로 이동
        background1.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
        background2.Translate(Vector3.left * scrollSpeed * Time.deltaTime);

        // 카메라의 왼쪽 경계 계산
        float cameraLeftEdge = cam.transform.position.x - cam.orthographicSize * cam.aspect;

        // 배경1이 카메라 밖을 완전히 벗어났을 때
        if (background1.position.x + backgroundWidth * 0.7f < cameraLeftEdge)
        {
            // 배경1을 배경2의 오른쪽으로 이동
            background1.position = new Vector3(background2.position.x + backgroundWidth, background1.position.y, background1.position.z);
        }

        // 배경2가 카메라 밖을 완전히 벗어났을 때
        if (background2.position.x + backgroundWidth * 0.7f < cameraLeftEdge)
        {
            // 배경2를 배경1의 오른쪽으로 이동
            background2.position = new Vector3(background1.position.x + backgroundWidth, background2.position.y, background2.position.z);
        }
    }
}