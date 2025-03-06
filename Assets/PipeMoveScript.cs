using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float Speed = 5;
    public float DeadZone = -45;
    // Start is called once before the first execution of Update after the MonoBehaviour is created 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;

        if (transform.position.x < DeadZone)
        {
            Debug.Log("Pipe destroyed");
            Destroy(gameObject);
        }
    }
}
