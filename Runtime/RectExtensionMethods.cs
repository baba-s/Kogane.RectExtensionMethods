using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// Rect 型の拡張メソッド
    /// </summary>
    public static class RectExtensionMethods
    {
        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// 中央基準の Rect に変換して返します
        /// </summary>
        public static Rect ToCenterRect( this Rect self )
        {
            return new Rect
            (
                x: self.xMin - self.size.x * 0.5f,
                y: self.yMin - self.size.y * 0.5f,
                width: self.size.x,
                height: self.size.y
            );
        }

        /// <summary>
        /// 指定された座標を Rect の範囲内に Clamp します
        /// </summary>
        public static Vector2 Clamp( this Rect self, in Vector2 position )
        {
            return new
            (
                Mathf.Clamp( position.x, self.xMin, self.xMax ),
                Mathf.Clamp( position.y, self.yMin, self.yMax )
            );
        }

        /// <summary>
        /// 指定されたサイズで Rect を縮小します
        /// </summary>
        public static Rect Shrink( this Rect self, float size )
        {
            return self.Shrink( new Vector2( size, size ) );
        }

        /// <summary>
        /// 指定されたサイズで Rect を縮小します
        /// </summary>
        public static Rect Shrink( this Rect self, in Vector2 size )
        {
            self.position += size * 0.5f;
            self.size     -= size;

            return self;
        }
    }
}