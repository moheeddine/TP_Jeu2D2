using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject obstacle;

    public float minTime = 1.5f;
    public float maxTime = 3.5f;

    private float timer;

    void Start()
    {
        ResetTimer();
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            Spawn();
            ResetTimer();
        }
    }

    void Spawn()
    {
        Instantiate(obstacle, transform.position, Quaternion.identity);
    }

    void ResetTimer()
    {
        timer = Random.Range(minTime, maxTime);
    }
}
