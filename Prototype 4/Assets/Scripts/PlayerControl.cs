using System.Collections;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject powerupIndicator;
    private float powerupStrength = 15.0f;
    public bool hasPowerup;
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
        powerupIndicator.transform.position=transform.position+new Vector3(0,-0.5f,0);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
            powerupIndicator.gameObject.SetActive(true);
        }
    }
   IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup)

        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
            Debug.Log("Collided with " + collision.gameObject.name + " with powerup set to " + hasPowerup);
            enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
            powerupIndicator.gameObject.SetActive(false);
        }

    }
}