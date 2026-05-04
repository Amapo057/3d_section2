using UnityEngine;

public class Scorer : MonoBehaviour
{
    public int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        hits++;
        Debug.Log("you bumped into a thing this many times: " + hits);
    }
}
