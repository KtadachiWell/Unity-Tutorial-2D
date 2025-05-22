using UnityEngine;

public class StudyComponent2 : MonoBehaviour
{

    public GameObject obj;

    public Mesh msh;
    public Material mat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CreateCube();
    }

    public void CreateCube()
    {

        obj = new GameObject("cube");

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh; 

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.AddComponent<BoxCollider>();

    }
}
