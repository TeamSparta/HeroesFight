namespace HeroesFight.GameObjects
{
    using System.Drawing;

    public abstract class GameObject
    {
        protected GameObject(Image sprite)
        {
            this.Sprite = sprite;
        }

        public Image Sprite { get; set; }
    }
}