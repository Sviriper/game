using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Maze
{
    public class Main : MonoBehaviour
    {
        private InputConroller _inputConroller;
        [SerializeField]private Unit _player;
        private void Awake()
        {
            _inputConroller = new InputConroller(_player);
        }
        void Update()
        {
            _inputConroller.Update();
        }
    }
}