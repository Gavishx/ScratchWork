namespace Adams.SceneGraph
{
    public interface IGroupNode : ISceneNode
    {
        void AddChild(ISceneNode child);
    }
}
