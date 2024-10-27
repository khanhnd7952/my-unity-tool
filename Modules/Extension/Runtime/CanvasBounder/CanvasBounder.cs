using UnityEngine;

namespace Squirrel.Extension
{
    public class CanvasBounder : MonoBehaviour
    {
        private Canvas _canvas;

        Canvas Canvas
        {
            get
            {
                if (_canvas == null)
                {
                    _canvas = GetComponentInParent<Canvas>();
                }

                return _canvas;
            }
        }

        public Bounds GetBounds()
        {
            return new Bounds(GetPosition(), GetSize());
        }

        public Vector2 GetSize()
        {
            return (transform as RectTransform).CanvasObjectToWorldSize(Canvas);
        }

        public Vector3 GetPosition()
        {
            var position = transform.CanvasObjectToWorldPosition(Canvas);
            position.z = 0f;
            return position;
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            var bound = GetBounds();
            Gizmos.DrawWireCube(bound.center, bound.size);
        }
    }
}