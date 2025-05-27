using UnityEngine;

public class StudyMaterial : MonoBehaviour
{
    public Material mat;
    public string hexCode;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Material에 접근해서 Material 자체를 바꾸는 방식.
        // // this.GetComponent<Material>() = mat; // Material을 바꾸는 방식 X, 에러 발생시키는 코드임.
        // this.GetComponent<MeshRenderer>().material = mat; // MeshRenderer에 접근해서 바꾸는 방식.


        // Material의 데이터 속성 값을 바꾸는 방식
        this.GetComponent<MeshRenderer>().material.color = Color.green; // 자신(해당 오브젝트 한정)의 메테리얼만 바꾸는 형식
        // this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.green; // sharedMaterial은 해당 메테리얼을 가진 모든 오브젝트가 변경되는 메테리얼 자체를 변경하는 방식이다.
        // 즉, sharedMaterial은 일괄적으로 모든 메테리얼을 변경하고 싶을 때 사용하면 된다고 한다.

        // this.GetComponent<MeshRenderer>().material.color = new Color(200f/225f, 137f/255f, 70f/255f, 1); // 직접적으로 컬러값을 넣어서 메테리얼의 색상을 제어하는 방식.


        // HexCode를 인스펙터에서 직접 입력하여 컬러를 변경하는 방식.
        Material mat = this.GetComponent<MeshRenderer>().material;
        Color outputColor;

        if (ColorUtility.TryParseHtmlString(hexCode, out outputColor))
        {
            mat.color = outputColor;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
