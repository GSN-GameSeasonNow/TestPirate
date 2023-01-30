using UnityEngine;

public class TrapActivator : MonoBehaviour
{
    public GameObject spikes;
    public GameObject trigger;
    public float fallDelay = 1f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = spikes.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Invoke("Fall",fallDelay);
        }
    }

    private void Fall()
    {
        rb.isKinematic = false;
        if (rb.isKinematic == false)
        {
            Destroy(spikes, 2f);
            Destroy(trigger, 2f);
        }
    }
}