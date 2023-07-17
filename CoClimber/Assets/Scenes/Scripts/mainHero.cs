using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroMove : MonoBehaviour
{
    public float dikey_hız, yatay_hız,varsayılan_hız;
    private float yatay_hareket,dikey_hareket;
    Rigidbody2D rb;

    void Start ()

    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
       dikey_hareket = Input.GetAxis("Vertical");
       yatay_hareket = Input.GetAxis("Horizontal");

        rb.velocity = new Vector3
        (yatay_hareket*50*yatay_hız*Time.deltaTime, varsayılan_hız+dikey_hareket * 50 * dikey_hız * Time.deltaTime);

        if (transform.position.x > 1.35f) //sağ sınır satırı
        {
            Vector3 right_limit = new Vector3(1.35f, transform.position.y);
            transform.position = right_limit;
        }

        if (transform.position.x < -1.2f) //sol satır sınırı
        {
            Vector3 left_limit = new Vector3(-1.2f, transform.position.y);
            transform.position = left_limit;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.tag=="Win")
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }
}