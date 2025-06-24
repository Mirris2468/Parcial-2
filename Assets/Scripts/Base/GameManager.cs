using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public Transform[] spawnPoints;

    void Start()
    {
        foreach (Transform spawn in spawnPoints)
        {
            int random = Random.Range(0, 2);
            if (random == 0)
                Instantiate(Enemy1, spawn.position, spawn.rotation);
            else
                Instantiate(Enemy2, spawn.position, spawn.rotation);
        }
    }
}