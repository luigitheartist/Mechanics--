using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 5.0f;
    private GameObject fp;

        void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        fp = GameObject.Find("FP");
    }

    
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(fp.transform.forward * speed * forwardInput);
    }
}
