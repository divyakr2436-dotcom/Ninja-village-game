using UnityEngine;

public class bluecubemovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        if(transform.position.x>-10.0f)
        transform.Translate(Vector3.left * 1.0f * Time.deltaTime);
    }
}
