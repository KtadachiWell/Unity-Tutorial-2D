using UnityEngine;

public class StudyUnityEvent : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("Awake");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start");
    }

    private void OnEnable() // 켜질때마다 1회
    {
        Debug.Log("OnEnable");
    }

    private void OnDisable() // 꺼질때마다 1회
    {
        Debug.Log("OnDisable");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
