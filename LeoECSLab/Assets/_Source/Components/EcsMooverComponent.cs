using System;
using UnityEngine;

namespace Client 
{ 
    [Serializable]
    public struct EcsMooverComponent {
       
        public float Speed;
        public Transform Anchor;
        public float Amplitude;
        public float StartZ;
    }
}