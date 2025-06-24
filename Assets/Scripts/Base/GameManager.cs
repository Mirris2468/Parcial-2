using UnityEngine;
//Script del GameMananger que permite aparecer a los enemigos en sus respectivos spawns
public class GameManager : MonoBehaviour
{
    public GameObject Enemy1;//Se coloca en el inspector el PreFab del enemigo 1
    public GameObject Enemy2;//Se coloca en el inspector el PreFab del enemigo 2
    public Transform[] spawnPoints;//Se colocan los Puntos del spawn en el inspector

    void Start()//Al empezar la escena el juego escoje al azar un enemigo y lo instancia en uno de los spawn (Esto lo hace por cada spawn (2 veces en este caso))
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