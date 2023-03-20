using Assets.Scripts.Events;
using StarterAssets;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

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

    [SerializeField]
    private UnityEvent onEnemyCloseToPlayer;

    [SerializeField]
    private UnityEventForEnemyCloseBy onEnemyCloseToPlayerProvideInfo;

    void Start()
    {
        StartCoroutine(CheckForEnemies());
        onEnemyCloseToPlayer.AddListener(() 
            => PlayerIsCloseToEnemy());

        onEnemyCloseToPlayerProvideInfo.AddListener((enemyName, distance) 
            => PlayerIsCloseToEnemy(enemyName, distance));
    }

    void PlayerIsCloseToEnemy()
    {
        Logger.Instance.LogInfo("Enemy is close to the player");
    }

    void PlayerIsCloseToEnemy(string enemyName, float distance)
    {
        Logger.Instance.LogInfo($"Enemy: {enemyName} " +
                        $"is closed by {distance}");

        GameObject enemy = GameObject.Find(enemyName);
        Renderer renderer = enemy.GetComponent<Renderer>();
        renderer.material.color = Color.yellow;

        PlayerFeatures playerFeatures = FindObjectOfType<PlayerFeatures>();
        Debug.Log($"PlayerFeatures was loaded: {playerFeatures.PlayerName}");

        ThirdPersonController controller = GameObject.FindGameObjectWithTag("Player")
            .GetComponent<ThirdPersonController>();

        //controller.MoveSpeed = 0.5f;
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
                    onEnemyCloseToPlayer?.Invoke();

                    onEnemyCloseToPlayerProvideInfo?.Invoke(enemy.name, distance);
                }
            }

            yield return new WaitForSeconds(frequency);
        }
    }

    void Update()
    {

    }
}
