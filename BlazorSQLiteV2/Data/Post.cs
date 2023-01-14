using System.ComponentModel.DataAnnotations;

namespace BlazorSQLiteV2.Data
{
    public class Post
    {
        [Key] public int PostId { get; set; }
        public string PostTitle { get; set; } = string.Empty;
        public string PostMessage { get; set; } = string.Empty;
        public DateOnly PostDate { get; set; }
        public int? PostPictureId { get; set; }
        public PostPicture PostPicture { get; set; }
    }
}