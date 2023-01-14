using System.ComponentModel.DataAnnotations;

namespace BlazorSQLiteV2.Data
{
    public class PostPicture
    {
        [Key] public int PostPictureId { get; set; }
        public string PostPictureName { get; set; } = string.Empty;
        public string PostPictureUrl { get; set; } = string.Empty;
        public Post PostId { get; set; }
    }
}