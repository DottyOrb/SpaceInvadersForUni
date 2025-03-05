using UnityEngine;

public class VanLeft : MonoBehaviour
{
    private Vector3 _direction = Vector2.left;
    int speed = 6;
    public float timeTillDespawn = 20;
    [SerializeField] private int invaderScore;

    private void Update()
    {
        this.transform.position += _direction * speed * Time.deltaTime;

        if (timeTillDespawn > 0)
        {
            timeTillDespawn -= Time.deltaTime;

        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Laser"))
        {
            this.gameObject.SetActive(false);
            ScoreManager.instance.AddToScore(invaderScore);
        }
    }
}
