using UnityEditor.Timeline.Actions;
using UnityEngine;

public class Invader : MonoBehaviour
{
    public Sprite[] animationSprites;
    public float animationTime;
    public System.Action killed;
    public int invaderScore;
    public Projectile PowerUp;

    private SpriteRenderer _spriteRenderer;
    private int _animationFrame;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), this.animationTime, this.animationTime);
    }

    private void AnimateSprite()
    {
        _animationFrame++;

        if (_animationFrame >= this.animationSprites.Length) { 
            _animationFrame = 0;
        }

        _spriteRenderer.sprite = this.animationSprites[_animationFrame];
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Laser"))
        {
            
            int SpawnPowerUp = Random.Range(0, 20);
            if (SpawnPowerUp == 19)
            {
                Instantiate(this.PowerUp, transform.position, Quaternion.identity);
            }
            this.killed.Invoke();
            this.gameObject.SetActive(false);
            ScoreManager.instance.AddToScore(invaderScore);
        }
    }


}
