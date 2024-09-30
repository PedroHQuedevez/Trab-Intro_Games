using UnityEngine;

public class SawAnims : MonoBehaviour
{
    Animator animator;
    float moveSpeed = 1f;
    [SerializeField]
    Transform[] pointsToMove;
    [SerializeField]
    int startingPoint;

    public void Start()
    {
        animator = GetComponent<Animator>();
        transform.position = pointsToMove[startingPoint].transform.position;
    }

    public void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, pointsToMove[startingPoint].transform.position, moveSpeed * Time.deltaTime);
        if (transform.position == pointsToMove[startingPoint].transform.position)
        {
            startingPoint += 1;
        }

        if (startingPoint == pointsToMove.Length)
        {
            startingPoint = 0;
        }
    }
}
