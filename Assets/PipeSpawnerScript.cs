using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffSet = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }

    }

    void spawnPipe()
    {
        float lowestpoint = transform.position.y - heightOffSet;
        float highestpoint = transform.position.y + heightOffSet;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint,highestpoint),0), transform.rotation);
    }
}
