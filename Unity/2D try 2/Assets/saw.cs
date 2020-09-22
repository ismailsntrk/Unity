
using UnityEngine;

public class saw : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int Damage = 20;
    public Transform sawTrans;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    public void Update()
    {
        if (Mathf.Abs(sawTrans.position.x) > 150 || Mathf.Abs(sawTrans.position.y) > 150 || Mathf.Abs(sawTrans.position.z) > 150)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Mace mace = collision.GetComponent<Mace>();
            if (mace != null)
            {
                mace.takeDamage(Damage);
                Destroy(gameObject);
            }
        }
      
       

       
    }
   


}
