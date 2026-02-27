using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;

    private PlayerController player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject playerGo = GameObject.Find("Player");
        player = playerGo.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isGameOver == true)
        {
            return;
        }
        transform.Translate(speed * Vector3.left * Time.deltaTime);
    }
}
