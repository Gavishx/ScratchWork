using Adams.SceneGraph;
namespace adams.SceneGraphCore
{
	abstract public class DrawableNodeBase : IDrawableNode
	{
		public DrawableNodeBase(string name)
		{
            this.Name = name;
		}

        public string Name
        {
            get;
            protected set;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.PreVisit(this);
            visitor.PostVisit(this);
        }

        public abstract void Draw();
    }
}

