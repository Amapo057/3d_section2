using UnityEngine;

public class Scorer : MonoBehaviour
{
    public int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("you bumped into a thing this many times: " + hits);
        }
        
    }
}
