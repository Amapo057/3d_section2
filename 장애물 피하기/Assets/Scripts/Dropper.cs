using Unity.VisualScripting;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();
        // 캐싱은 자주 사용되는 정보를 메모리에 저장해 필요할 때 쉽게 저장할 수 있도록 하는 것
        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            Debug.Log("Lookout");
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
