using UnityEngine;

public class SawDeath : MonoBehaviour
{
    [SerializeField]
    GameObject deathAnim;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Saw")
        {
            MortePorContato();
        }
    }

    void MortePorContato()
    {
        Instantiate(deathAnim, transform.position, Quaternion.identity);
        transform.parent.gameObject.SetActive(false);
    }
}
