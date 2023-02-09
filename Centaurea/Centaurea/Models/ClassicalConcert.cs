using Centaurea.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Centaurea.Models
{
    public class ClassicalConcert : Concert
    {
        public VoiceTypes VoiceType { get; set; } 
        public string ConcertName { get; set; }
        public string ComposersName { get; set; }

    }
}
