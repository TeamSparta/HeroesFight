namespace HeroesFight.GameObjects
{
    using System.Drawing;

    public abstract class GameObject
    {
        protected GameObject(Bitmap sprite)
        {
            this.Sprite = sprite;
        }

        public Bitmap Sprite { get; set; }
    }
}