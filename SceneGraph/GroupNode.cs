using Adams.SceneGraph;

namespace Adams.SceneGraphCore
{

    public class GroupNode : IGroupNode
    {
        public const int capacity = 8;

        public GroupNode(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get;
            private set;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.PreVisit(this);
            foreach (ISceneNode child in children)
                child.Accept(visitor);
            visitor.PostVisit(this);
        }

        public void AddChild(ISceneNode child)
        {
            children.Add(child);
        }

        #region Member variables 
        private IList<ISceneNode> children = new List<ISceneNode>(capacity);
        #endregion
    }
}
