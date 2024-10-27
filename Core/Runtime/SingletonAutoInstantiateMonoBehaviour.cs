using UnityEngine;

namespace Squirrel
{
    public abstract class SingletonAutoInstantiateMonoBehaviour<T> : MonoBehaviour where T : SingletonAutoInstantiateMonoBehaviour<T>
    {
        private static T _instance;

        public static T gInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameObject(typeof(T).Name).AddComponent<T>();
                    DontDestroyOnLoad(_instance.gameObject);
                }

                return _instance;
            }
        }
    }
}