using UnityEngine;


public class MidPipe : MonoBehaviour
{
    public LogicScript l;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        l = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            l.addScore();
        }
    }
}