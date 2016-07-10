namespace Pressbox.Models
{
    public interface IPlayHistory
    {
        string lastPlay { get; set; }
        string lastResult { get; set; }
        string tackleMade { get; set; }
    }
}