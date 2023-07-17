using UnityEngine;

public class dusentaslar : MonoBehaviour
{
    private float varsayilan_hiz;
    private int gidilen_serit;
    public int tas_sprite;
    public Sprite tas1, tas2, tas3, tas4, tas5;
    Rigidbody2D rb;
    SpriteRenderer spr;
    

    [SerializeField] private int damage = 1;

    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        gidilen_serit = Random.Range(1, 5);
        varsayilan_hiz = Random.Range(2.5f, 3.5f);
        tas_sprite = Random.Range(1, 6);

        if (gidilen_serit == 1)
        {
            transform.position = new Vector3(-0.98f, transform.position.y + 10, 0);
        }

        else if (gidilen_serit == 2)
        {
            transform.position = new Vector3(-0.28f, transform.position.y + 10, 0);
        }

        else if (gidilen_serit == 3)
        {
            transform.position = new Vector3(0.40f, transform.position.y + 10, 0);
        }

        else
        {
            transform.position = new Vector3(1.10f, transform.position.y + 10, 0);
        }
        switch (tas_sprite)
        {
            case 1:
                spr.sprite = tas1;
                break;
            case 2:
                spr.sprite = tas2;
                break;
            case 3:
                spr.sprite = tas3;
                break;
            case 4:
                spr.sprite = tas4;
                break;
            case 5:
                spr.sprite = tas5;
                break;

        }



    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(rb.velocity.x, varsayilan_hiz * 50 * Time.deltaTime, 0);
    }
    void Update() =>
        // Aşağı doğru hareket etme işlevi
        transform.Translate(Vector3.down * varsayilan_hiz * Time.deltaTime);

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "mainHero")
        {
            FindObjectOfType<HealthSystem>().TakeDamage(damage);
        }

    }

}
