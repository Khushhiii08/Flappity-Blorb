using UnityEngine;

public class BoundaryScript : MonoBehaviour
{
    public LogicScript l;
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player left the screen!");
            l.gameOver();
        }
    }
}
