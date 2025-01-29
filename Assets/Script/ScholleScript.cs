using UnityEngine;

public class ScholleScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool scholleIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        logic.scholleScript = this; // Referenz für LogicScript
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && scholleIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        if(myRigidbody.position.y < -8)
        {
            logic.gameOver();
            scholleIsAlive = false; 
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        scholleIsAlive = false; 
    }
}
