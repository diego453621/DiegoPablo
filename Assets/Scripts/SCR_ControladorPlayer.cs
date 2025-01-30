using UnityEngine;

public class SCR_ControladorPlayer : MonoBehaviour
{
    [SerializeField] private float velocidad;

    private Rigidbody2D rig;
    private Animator anim;
    private SpriteRenderer spritePersonaje;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        spritePersonaje = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    private void FixedUpdate(){
        Movimiento();
    }
    private void Movimiento(){
        float horizontal= Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rig.linearVelocity = new Vector2(horizontal, vertical)* velocidad;
        anim.SetFloat("pulsarD", Mathf.Abs (rig.linearVelocity.magnitude));

        if(horizontal < 0 ){
            spritePersonaje.flipX = false;
        }else if(horizontal > 0 ){
            spritePersonaje.flipX = true;
        }
    }
}
