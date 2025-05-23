using Unity.VisualScripting;
using UnityEngine;

public class StudyComponent2 : MonoBehaviour
{

    public GameObject obj;

    public Mesh msh;
    public Material mat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CreateCube(); // 기본값이 함수 자체에서 들어가있어서 이렇게 만들수도있음.
        CreateCube("Hello World");
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube); //큐브 만들기
    }

    public void CreateCube(string name = "Cube") // 이렇게 해두면 매개변수의 기본값 설정이 되는 것.
    {

        obj = new GameObject(name);

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh; 

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.AddComponent<BoxCollider>();

    }
}
