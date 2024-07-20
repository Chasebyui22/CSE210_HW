class Video
{
    public string _title;
    public string _author;
    public float _length;
    private List<Comment> comments;
    public Video(string Title, string Author, float Length)
    {
        _title = Title;
        _author = Author;
        _length = Length;
        comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return comments.Count;
    }   
    public List<Comment> GetComments()
    {
        return new List<Comment>(comments);
    }
}