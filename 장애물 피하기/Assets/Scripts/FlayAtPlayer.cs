// using System.Threading.Tasks.Dataflow;
using System;
using UnityEngine;

public class FlayAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 20f;
    Vector3 playerPosition;


    void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        
        playerPosition = player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
