using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKController : MonoBehaviour
{
    [SerializeField] private Transform _handPoint;
    [SerializeField] private Transform _headPoint;

    [SerializeField, Range(0f, 1f)] private float _handWeight;
    [SerializeField] private Vector3 _handOffset;

    [SerializeField] private Transform _handPoint2;

    [SerializeField, Range(0f, 1f)] private float _handWeight2;
    [SerializeField] private Vector3 _handOffset2;

    [SerializeField, Range(0f, 1f)] private float _LookIKWeight;

    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnAnimatorIK(int layerIndex)
    {
        if (_handPoint)
        {
            _animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, _handWeight);
            _animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, _handWeight);

            _animator.SetIKPosition(AvatarIKGoal.LeftHand, _handPoint.position + _handOffset);
            _animator.SetIKRotation(AvatarIKGoal.LeftHand, _handPoint.rotation);
        }
        if (_handPoint2)
        {
            _animator.SetIKPositionWeight(AvatarIKGoal.RightHand, _handWeight2);
            _animator.SetIKRotationWeight(AvatarIKGoal.RightHand, _handWeight2);

            _animator.SetIKPosition(AvatarIKGoal.RightHand, _handPoint2.position + _handOffset2);
            _animator.SetIKRotation(AvatarIKGoal.RightHand, _handPoint2.rotation);
        }
        if (_headPoint)
        {
            _animator.SetLookAtWeight(_LookIKWeight);
            _animator.SetLookAtPosition(_headPoint.position);

        }
    }
}
