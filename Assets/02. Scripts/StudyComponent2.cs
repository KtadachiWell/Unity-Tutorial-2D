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
        CreateCube(); // �⺻���� �Լ� ��ü���� ���־ �̷��� �����������.
        CreateCube("Hello World");
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube); //ť�� �����
    }

    public void CreateCube(string name = "Cube") // �̷��� �صθ� �Ű������� �⺻�� ������ �Ǵ� ��.
    {

        obj = new GameObject(name);

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh; 

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.AddComponent<BoxCollider>();

    }
}
