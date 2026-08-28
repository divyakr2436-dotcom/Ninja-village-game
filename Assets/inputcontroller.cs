using UnityEngine;

public class inputcontroller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.left * 1.0f * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.right * 1.0f * Time.deltaTime);
        if (Input.GetKey(KeyCode.B))
            transform.Translate(Vector3.up * 1.0f * Time.deltaTime);
        if (Input.GetKey(KeyCode.C))
            transform.Translate(Vector3.down * 1.0f * Time.deltaTime);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="wall")
        Destroy(collision.gameObject);
        else if (collision.gameObject.tag == "enemy")
            Destroy(this.gameObject);
    }
}
