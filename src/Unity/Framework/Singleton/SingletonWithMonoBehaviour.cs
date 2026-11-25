using UnityEngine;

namespace Framework
{
    public class SingletonWithMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance = default(T);
        private static bool _applicationIsQuitting = false;

        public static T Instance
        {
            get
            {
                if (_applicationIsQuitting == true)
                    return null;

                if (_instance != null)
                    return _instance;

                _instance = FindAnyObjectByType<T>();

                if (_instance != null)
                    return _instance;

                _instance = new GameObject(typeof(T).Name).AddComponent<T>();

                return _instance;
            }
        }

        protected virtual void Awake()
        {
            if (_instance != this && _instance != null)
            {
                GameObject.Destroy(gameObject);
                return;
            }

            _instance =  this as T;
        }

        protected virtual void OnApplicationQuit()
        {
            _applicationIsQuitting = true;
        }
    }
}
