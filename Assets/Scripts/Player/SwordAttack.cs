using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private bool _startAnimation;
    private void Update()
    {
        //if (_startAnimation)
        //{
        //    _startAnimation = false;
        //    _animator.SetBool("attack", false);
        //}

        if (Input.GetMouseButtonDown(0))
        {
            _animator.SetTrigger("attack");
            _startAnimation = true;

        }
    }
}
