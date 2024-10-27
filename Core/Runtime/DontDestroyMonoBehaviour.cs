namespace Squirrel
{
    public class DontDestroyMonoBehaviour<T> : SingletonMonoBehaviour<T> where T : DontDestroyMonoBehaviour<T>
    {
        protected override void Awake()
        {
            base.Awake();
            transform.SetParent(null);
            DontDestroyOnLoad(gameObject);
        }
    }
}