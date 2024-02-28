using System;
using UnityEngine;

namespace MainPlayer.UnityEngine
{
    public static class TransformExtensions
    {
        public static void ResetTransformation(this Transform trans)
        {
            trans.position = Vector3.zero;
            trans.localRotation = Quaternion.identity;
            trans.localScale = Vector3.one;
        }
    }

    public class ObjectManipulator : MonoBehaviour
    {
        private void Start()
        {
            transform.ResetTransformation();
        }
    }
}