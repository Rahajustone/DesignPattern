using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.memento
{
    public class Editor
    {
        private String Content;

        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        public void Restore(EditorState state)
        {
            Content = state.GetContent();
        }

        public void SetContent(string content)
        {
            Content = content;
        }

        public string GetContent()
        {
            return Content;
        }
    }

    public class EditorState
    {
        private readonly string content;
        public EditorState(string content)
        {
            this.content = content;
        }

        public string GetContent()
        {
            return content;
        }
    }

    public class History
    {
        Stack<EditorState> stateList = new Stack<EditorState>();

        public void pushState(EditorState stateText)
        {
            stateList.Push(stateText);
        }

        public EditorState popState()
        {
            return stateList.Pop();
        }
    }
}
