namespace Adams.SceneGraph
{
	public interface ITransformNode : ISceneNode
    {
        void Apply();
        void UnApply();
    }
}