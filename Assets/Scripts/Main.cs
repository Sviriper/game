using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Maze
{
    public class Main : MonoBehaviour
    {
        private InputConroller _inputConroller;
        private CameraController _cameraController;
        private ListExecuteObject _interactiveObject;

        [SerializeField]private Unit _player;
        private void Start()
        {
            _inputConroller = new InputConroller(_player);
            _cameraController = new CameraController(_player._transform, Camera.main.transform);
            _interactiveObject = new ListExecuteObject();


            _interactiveObject.AddExecuteObject(_inputConroller);
            _interactiveObject.AddExecuteObject(_cameraController);
        } 
        void Update()
        {
            for (int i = 0; i < _interactiveObject.Length; i++)
            {
                if(_interactiveObject[i] == null)
                {
                    continue;
                }
                _interactiveObject[i].Update();
            }
        }
    }
}