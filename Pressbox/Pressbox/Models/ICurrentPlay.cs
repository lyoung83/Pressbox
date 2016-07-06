namespace Pressbox.Models
{
    interface ICurrentPlay
    {
        string playCall { get; set; }
        string playResult { get; set; }
        string tackledBy { get; set; }
    }
}