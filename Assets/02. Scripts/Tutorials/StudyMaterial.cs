using UnityEngine;

public class StudyMaterial : MonoBehaviour
{
    public Material mat;
    public string hexCode;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Material�� �����ؼ� Material ��ü�� �ٲٴ� ���.
        // // this.GetComponent<Material>() = mat; // Material�� �ٲٴ� ��� X, ���� �߻���Ű�� �ڵ���.
        // this.GetComponent<MeshRenderer>().material = mat; // MeshRenderer�� �����ؼ� �ٲٴ� ���.


        // Material�� ������ �Ӽ� ���� �ٲٴ� ���
        this.GetComponent<MeshRenderer>().material.color = Color.green; // �ڽ�(�ش� ������Ʈ ����)�� ���׸��� �ٲٴ� ����
        // this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.green; // sharedMaterial�� �ش� ���׸����� ���� ��� ������Ʈ�� ����Ǵ� ���׸��� ��ü�� �����ϴ� ����̴�.
        // ��, sharedMaterial�� �ϰ������� ��� ���׸����� �����ϰ� ���� �� ����ϸ� �ȴٰ� �Ѵ�.

        // this.GetComponent<MeshRenderer>().material.color = new Color(200f/225f, 137f/255f, 70f/255f, 1); // ���������� �÷����� �־ ���׸����� ������ �����ϴ� ���.


        // HexCode�� �ν����Ϳ��� ���� �Է��Ͽ� �÷��� �����ϴ� ���.
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
