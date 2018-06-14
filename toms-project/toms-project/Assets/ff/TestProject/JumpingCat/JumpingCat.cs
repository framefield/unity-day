using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ff.TestProject.cat
{
    /** Quick test implementation for cat interaction */
    public class JumpingCat : MonoBehaviour
    {
        [Range(0, 10)]
        public float JumpHeight;

        [Range(0, 10)]
        public float JumpFrequency;

        public void IncreaseJumpHeight()
        {
            JumpHeight = JumpHeight + 1;
        }

        void Update()
        {
            var jumpHeight = Mathf.Pow(Mathf.Sin(Time.time * JumpFrequency), 2) * JumpHeight;
            transform.localPosition = Vector3.up * jumpHeight + Vector3.forward * Time.time;
        }

    }
}