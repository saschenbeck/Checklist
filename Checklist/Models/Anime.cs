using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Checklist.Models
{
    public class Anime 
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Poster { get; set; }
        public bool Watched { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Anime>(this);
        

    }
}