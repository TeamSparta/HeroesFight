namespace HeroesFight.GameObjects
{
    #region

    using System.Drawing;

    #endregion

    public abstract class GameObject
    {
        protected GameObject(Bitmap sprite)
        {
            this.Sprite = sprite;
        }

        public Bitmap Sprite { get; set; }
    }
}