using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour {

    /*public Rigidbody2D rb;
    public Vector2 startForce;
    public GameObject initialText;
    // Use this for initialization
    void Start()
    {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            StartCoroutine(GameStart(3));
    }
    IEnumerator GameStart(float time)
    {
        yield return new WaitForSeconds(time);
        initialText.SetActive(false);
        rb.constraints = RigidbodyConstraints2D.None;
        int randomNumber = Random.Range(0, 2);
        if (randomNumber <= 0.5f)
        {
            rb.AddForce(new Vector2(80, 10),ForceMode2D.Force);
        }
        else
        {
            rb.AddForce(new Vector2(-80, -10),ForceMode2D.Force);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            transform.GetComponent<SpriteRenderer>().color = Color.blue;
        }

    }
*/
    float randomNumber;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer(2));
    }

    private void Reset()
    {
        StopCoroutine("Timer");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        transform.position = new Vector2(0f, 0f);
        StartCoroutine(Timer(0.5f));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("AGoal"))
        {
            transform.GetComponent<SpriteRenderer>().color = collision.gameObject.transform.GetComponent<SpriteRenderer>().color;
            Destroy(collision.gameObject);
            StartCoroutine("Reset");
        }
        if (collision.gameObject.CompareTag("BGoal"))
        {
            transform.GetComponent<SpriteRenderer>().color = collision.gameObject.transform.GetComponent<SpriteRenderer>().color;
            Destroy(collision.gameObject);
            StartCoroutine("Reset");
        }

    }

    IEnumerator Timer(float time)
    {
        yield return new WaitForSeconds(time);
        GoBall();
    }

    void GoBall()
    {
        randomNumber = Random.Range(0, 2);
        if (randomNumber <= 0.5f)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(80, 10));
        }
        else
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-80, -10));
        }
    }

}
