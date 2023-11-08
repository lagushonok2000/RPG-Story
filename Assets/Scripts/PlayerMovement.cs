using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CounterKristall _counterKristall;
    [SerializeField] private float  _playerSpeed;
    private CharacterController _controller;
    private Vector3 _playerVelocity;
    private Vector3 _move;
    private const int _layerKristall = 6;

    private void Start()
    {
        _controller = gameObject.GetComponent<CharacterController>();
        Time.timeScale= 1.0f;
    }
        
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == _layerKristall)
        {
            int ID = other.GetComponent<Kristall>().ID;
            _counterKristall.AddKristall(ID);
            other.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        _move = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        _controller.Move(_move * Time.deltaTime * _playerSpeed);

        if (_move != Vector3.zero)
        {
            transform.forward = _move;
        }

        _controller.Move(_playerVelocity * Time.deltaTime);
    }
}