using UnityEngine;

public class StudySomething : MonoBehaviour
{

    public int currentLevel = 10;
    public int maxLevel = 99;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool isMaxLevel = currentLevel >= maxLevel;
        // �� ���꿡 ���� ����� bool ������ �޴� �ڵ�. ������ True�� Ʋ���� false�� ��ȯ�Ǵ�.

        string msg = currentLevel >= maxLevel ? "���� �����Դϴ�." : "���� ������ �ƴմϴ�.";
        // ���� ������

        int levelPoint = currentLevel >= maxLevel ? 0 : 1;
        currentLevel += levelPoint;

        Debug.Log(msg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
