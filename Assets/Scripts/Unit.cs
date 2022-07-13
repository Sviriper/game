using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public abstract class Unit : MonoBehaviour
    {
        public Transform _transform;
        public Rigidbody _rb;

        public float _speed = 5f;
        public int _health = 100;
        public bool _isDead;


        public virtual void Awake()
        {
            _transform = GetComponent<Transform>();
            _rb = GetComponent<Rigidbody>();
        }

        public abstract void Move(float x, float y, float z);
    }
}