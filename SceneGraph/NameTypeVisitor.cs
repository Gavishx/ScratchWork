using Adams.SceneGraph;
namespace adams.SceneGraphCore
{
	public class NameTypeVisitor : IVisitor
	{
		public NameTypeVisitor()
		{
		}

        public string Name => throw new NotImplementedException();

        public void Accept(IVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void PostVisit(IDrawableNode drawable)
        {
            currentIndentation = currentIndentation.Substring(0,
                currentIndentation.Length - indentIncrement.Length);
        }

        public void PostVisit(ITransformNode transform)
        {
            currentIndentation = currentIndentation.Substring(0,
                currentIndentation.Length - indentIncrement.Length);
        }

        public void PostVisit(IStateNode state)
        {
            currentIndentation = currentIndentation.Substring(0,
                currentIndentation.Length - indentIncrement.Length);
        }

        public void PostVisit(IGroupNode group)
        {
            currentIndentation = currentIndentation.Substring(0,
                currentIndentation.Length - indentIncrement.Length);
        }

        public void PreVisit(IDrawableNode drawable)
        {
            System.Console.WriteLine(currentIndentation
                + "A Drawable node of type "
                + drawable.GetType().ToString()
                +  " with name: " + drawable.Name);
            currentIndentation += indentIncrement;
        }

        public void PreVisit(ITransformNode transform)
        {
            System.Console.WriteLine(currentIndentation
                + "A transform node of type "
                + transform.GetType().ToString()
                + " with name: " + transform.Name);
            currentIndentation += indentIncrement;
        }

        public void PreVisit(IStateNode state)
        {
            System.Console.WriteLine(currentIndentation
                + "A state node of type "
                + state.GetType().ToString()
                + " with name: " + state.Name);
            currentIndentation += indentIncrement;
        }

        public void PreVisit(IGroupNode group)
        {
            System.Console.WriteLine(currentIndentation
                + "A group node of type "
                + group.GetType().ToString()
                + " with name: " + group.Name);
            currentIndentation += indentIncrement;
        }

        #region Member Variables 
        string currentIndentation = "";
        string indentIncrement = "  ";
        #endregion
    }
}

