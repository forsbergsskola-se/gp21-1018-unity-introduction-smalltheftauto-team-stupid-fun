using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEvent : MonoBehaviour
{
    [SerializeField] private Transform playerPosition;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private GameObject player;
    private TMPro.TextMeshProUGUI deathText;
    public float respawnTime;
    public bool isDead;
    
    void Start()
    {
        
    }
    
    void Update()
    {
   
    }

    public void PlayerDeathEvent()
    {
        isDead = true;
        Invoke("Respawn", respawnTime);
    }

    public void Respawn()
    {
        playerPosition.transform.position = respawnPoint.transform.position;
        //Physics.SyncTransforms(); this is if we have a trigger to cause the death then uncomment this
        player.GetComponent<Currency>().LoseMoney();
        player.GetComponent<HealthSystem>().ResetHealth();
        isDead = false;
    }

    public void DeathText()
    {
        
    }


}
