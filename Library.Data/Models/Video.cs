using System.ComponentModel.DataAnnotations;

namespace Library.Data.Models
{
    public class Video : LibraryAsset
    {
        //can add other concrete assets like magazines, CDS, etc.
        [Required] public string Director { get; set; }
    }
}