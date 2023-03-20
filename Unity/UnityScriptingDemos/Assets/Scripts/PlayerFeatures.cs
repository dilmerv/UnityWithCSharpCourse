using Assets.Scripts.Types;
using UnityEngine;

public class PlayerFeatures : MonoBehaviour
{
    [Header("Player Dependencies")]
    [SerializeField]
    private GameObject playerPrefab;

    [Space]
    [Header("Player Information")]

    [SerializeField]
    private Player player;

    void OnEnable()
    {
        Debug.Log("Player Features Enabled");
    }

    void DisplayPlayerInfo()
    {
        Logger.Instance.LogInfo($"Id: {player.Id}");
        Logger.Instance.LogInfo($"First Name: {player.FirstName}");
        Logger.Instance.LogInfo($"Last Name: {player.LastName}");
        Logger.Instance.LogInfo($"Country Allowed: {player.CountryAllowed}");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player Features Started");

        DisplayPlayerInfo();

        if (player == null)
        {
            string warningMessage = "Player has not been set";
            Debug.LogWarning(warningMessage);
            Logger.Instance.LogInfo(warningMessage);
        }
        else
        {
            Logger.Instance.LogInfo($"{playerPrefab.name} was referenced through the inspector");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log($"Update was called: {Time.deltaTime}");
    }
}
