using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerDisneyIdApi.Models
{


    public class RespostaDisney
    {
        public Character? data { get; set; }
    }
    
    public class Character
    {
        public string? name { get; set; }

        public string? imageUrl { get; set; }
    }
}
