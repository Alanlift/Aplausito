using UnityEngine;

public class ObjMovement : MonoBehaviour
    
{

    public float horizontalMov;
    public float verticalMov;
    public float jugadorRapidez;
    public float gravity = 9.8f;
    public CharacterController objetivo;
    void Start()
    {
        objetivo = GetComponent<CharacterController>();
    }
    void Update()
    {
        horizontalMov = Input.GetAxis("Horizontal");
        verticalMov = Input.GetAxis("Vertical");
    }
    //FixedUpdate es para cuando jugamos con las físicas
    void FixedUpdate()
    {
        SetGravity();
        objetivo.Move(new Vector3(horizontalMov, 0, verticalMov)* jugadorRapidez * Time.deltaTime);
    }
    void SetGravity()
    {
        
    }
}