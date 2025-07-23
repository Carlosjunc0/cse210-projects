using System.Collections.Generic;

public class Video
{
    public string Title;
    public string Author;
    public int Length; 

    public List<Comment> Comments = new List<Comment>();

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}
