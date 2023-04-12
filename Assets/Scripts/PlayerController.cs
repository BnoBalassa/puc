using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private float Horizontal;
    private float Vertical;
    private CharacterController _CharacterController;
    private Vector3 newPosition;
    [SerializeField]
    private GameObject ammo;
    [SerializeField]
    private Transform transform;
    void Start()
    {
        _CharacterController = GetComponent<CharacterController>();
    }


    void Update()
    {
        Moviment();
        Atack();
    }

    private void Moviment()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        newPosition = new Vector3(Horizontal, 0, Vertical);
        _CharacterController.Move(newPosition * Time.deltaTime * 4);
        
    }

    private void Atack()
    {
       if(Input.GetButtonDown("Jump"))
        {
            Instantiate(ammo, transform.position, transform.rotation);
        }     
    }
}
