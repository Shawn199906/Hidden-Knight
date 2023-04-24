
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float Movespeed;
    public float Jumpforce;
    private Rigidbody2D rb;

    bool facingRight = true;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var Movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(Movement,0,0)*Time.deltaTime*Movespeed;

        if(Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y)<0.001f)
        {
            rb.AddForce(new Vector2(0,Jumpforce),ForceMode2D.Impulse);
            ScoreSystem.PlayerScore += 1;
        }

        if (Movement>0 && !facingRight)
        {
            Flip();
        }
        else if (Movement<0 && facingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        //Vector3 current_scale = gameObject.transform.localScale;
        //current_scale.x *= -1;
        //gameObject.transform.localScale= current_scale;
        facingRight = !facingRight;
        ScoreSystem.PlayerScore += 1;
        transform.Rotate(0f,180f,0f);
    }
}
