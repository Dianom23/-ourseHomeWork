using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace HomeWork2.Exercise2
{
    public sealed class Coroutines : MonoBehaviour
    {
        private static Coroutines _instance;

        public static Coroutines instance
        {
            get
            {
                if (_instance == null)
                {
                    GameObject go = new GameObject("[COROUTINE MANAGER]");
                    _instance = go.AddComponent<Coroutines>();
                    DontDestroyOnLoad(go);
                }

                return _instance;
            }
        }

        public static Coroutine StartRoutine(IEnumerator enumerator) => instance.StartCoroutine(enumerator);

        public static void StopRoutine(Coroutine coroutine) => instance.StopCoroutine(coroutine);
    }
}
