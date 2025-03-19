using UnityEngine;

public class Plataform : MonoBehaviour
{
    private Gyroscope gyro;
    private bool gyroEnabled;
    private float currentZRotation = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gyro = Input.gyro;
        gyro.enabled = true;
        gyroEnabled = true;
        
        if (gyroEnabled)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gyroEnabled)
        {
            float rotationZ = gyro.rotationRateUnbiased.z * -1;
            currentZRotation -= rotationZ * Time.deltaTime * 50f;
            currentZRotation = Mathf.Clamp(currentZRotation, -30f, 30f);
            transform.rotation = Quaternion.Euler(0f, 0f, currentZRotation);
        }
    }
}
