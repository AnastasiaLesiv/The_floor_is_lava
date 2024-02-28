using System;
using System.Collections;
using System.Collections.Generic;
//directive using for further use of types from the namespace UnityEngine
using UnityEngine;
//specifies the default meaning of the type name throughout the script
using Random = UnityEngine.Random;
//nested namespace declaration
namespace MainPlayer.UnityEngine
{
    //declare a type PlayerMovement as part of a namespace MainPlayer.UnityEngine
    public class PlayerTransform : MonoBehaviour
    {
        private float transformX = Random.value;
    }
}