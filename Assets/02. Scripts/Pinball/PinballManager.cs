using UnityEngine;

public class PinballManager : MonoBehaviour
{
    public Rigidbody2D leftBarRb;
    public Rigidbody2D rightBarRb;

    public float torquePower = 30f;

    void BarMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            leftBarRb.AddTorque(torquePower);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rightBarRb.AddTorque(-torquePower);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        BarMovement();
    }
}
