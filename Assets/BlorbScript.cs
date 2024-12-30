using UnityEngine;

public class BlorbScript : MonoBehaviour
{
    public Rigidbody2D mrb;
    public float flapStrength;
    public LogicScript l;
    public bool blorbIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        l = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && blorbIsAlive)
        {
            Vector2 v2 = Vector2.up * flapStrength;
            mrb.linearVelocity = v2; //(0,1) displacement upwards flapStrength (can be changed in unity whenever we want) times (to give it a bit more power)
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        l.gameOver();
        blorbIsAlive = false;
    }

}
  