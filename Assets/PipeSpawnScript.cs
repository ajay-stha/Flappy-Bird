using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject Pipe;
    private float _Time = 0.0f;
    public float SpawnTime = 2.0f;
    public float HeightOffset = 9.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (_Time > SpawnTime)
        {
            SpawnPipe();
            _Time = 0.0f;
        }
        _Time += Time.deltaTime;
    }
    
    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - HeightOffset;
        float highestPoint = transform.position.y + HeightOffset;
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), Quaternion.identity);
    }
}
