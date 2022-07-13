using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Maze
{
    public class BadBonus : Bonus, IFly, IRotation, IFlick
    {
        private float HightFly;
        private float speedRotation;
        private MeshRenderer meshRenderer;

        private void Awake()
        {
            HightFly = Random.Range(1f, 5f);
            speedRotation = Random.Range(13f, 40f);
            meshRenderer = GetComponent<MeshRenderer>();
        }

        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, HightFly), transform.position.z);
        }

        public void Rotate()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * speedRotation), Space.World);
        }

        public void Flick()
        {
            Color old = meshRenderer.material.color;
            float a = Mathf.PingPong(Time.time, 1);
            Color rgb = new Color(old.r, old.g, old.b, a);
            meshRenderer.material.color = rgb;
        }

        void Update()
        {
            Fly();
            Rotate();
            Flick();
        }
    }
}