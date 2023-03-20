using System.Collections;
using UnityEngine;

public class PlayerCoroutines : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject[] enemyCubes;

    [SerializeField]
    private float frequency = 0.5f;

    [SerializeField]
    private float minDistanceFromEnemy = 1.0f;

    void Start()
    {
        StartCoroutine(CheckForEnemies());
    }

    IEnumerator CheckForEnemies()
    {
        while (true)
        {
            Logger.Instance.LogInfo("Checking for Enemies...");

            foreach(var enemy in enemyCubes)
            {
                var enemyPosition = enemy.transform.position;
                var playerPosition = player.transform.position;
                var distance = Vector3.Distance(playerPosition, enemyPosition);

                if (distance <= minDistanceFromEnemy)
                { 
                    Logger.Instance.LogInfo($"Enemy: {enemy.name} " +
                        $"is closed by {distance}");
                }
            }

            yield return new WaitForSeconds(frequency);
        }
    }

    void Update()
    {

    }
}
