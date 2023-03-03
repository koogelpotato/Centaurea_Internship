using System.Text.Json.Serialization;

namespace Centaurea_Project.Models
{
    public class Party : Concert
    {
        public int AgeLimit { get; set; }
    }
}
