using UnityEngine;

public class StudyPolygon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Mesh mesh = new Mesh(); // 형태 데이터가 들어갈 Mesh 타입의 변수 생성

        Vector3[] vertices = new Vector3[] //  점 4개 찍기
        {
            new Vector3(0,0,0),
            new Vector3(1,0,0), 
            new Vector3(0,1,0), 
            new Vector3(1,1,0)
        };

        int[] triagnles = new int[]
        {
            0,2,1,
            2,3,1
        };

        Vector2[] uv = new Vector2[]{
            new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(0,1),
            new Vector2(1,1)

        };

        mesh.vertices = vertices;
        mesh.triangles = triagnles;
        mesh.uv = uv;

        // MeshFilter에 Mesh 데이터를 적용
        MeshFilter meshFilter = this.gameObject.AddComponent<MeshFilter>();
        meshFilter.mesh = mesh;

        // MeshRenderer에 Material 데이터를 적용
        MeshRenderer meshRenderer = this.gameObject.AddComponent<MeshRenderer>();
        meshRenderer.material = new Material(Shader.Find("Sprites/Default"));
    }
}
