using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class NPC : MonoBehaviour, IInteractable0
{
    [SerializeField] private SpriteRenderer _interactSprite;

    public Transform _playerTransform;

   // private const float INTERACT_DISTANCE = 5f;

    private void Start()
    {
        //_playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
       if(Keyboard.current.eKey.wasPressedThisFrame && IsWithInteractDistance())
    {
        //interact
        Interact();
    }
    
        if(_interactSprite.gameObject.activeSelf && !IsWithInteractDistance())
        {
            _interactSprite.gameObject.SetActive(false);
        }
        else if(!_interactSprite.gameObject.activeSelf && IsWithInteractDistance())
        {
            _interactSprite.gameObject.SetActive(true);
           
        }

    }
    public abstract void Interact();

    public bool IsWithInteractDistance()
    {
        if(Vector3.Distance(_playerTransform.position,transform.position)<1.75f)   //INTERACT_DISTANCE
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
}