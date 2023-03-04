namespace Adams.SceneGraph
{
    public class Camera : ITransformNode
    {
        public Camera()
        {
        }

        public string Name => throw new NotImplementedException();

        public void Accept(IVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void Apply()
        {
            throw new NotImplementedException();
        }

        public void UnApply()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}