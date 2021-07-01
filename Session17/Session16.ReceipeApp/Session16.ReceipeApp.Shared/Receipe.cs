using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Session16.ReceipeApp.Shared
{
    public class Receipe
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Detaile { get; set; }
        public int PreparationTime { get; set; }
        public List<Ingridient> Ingridients { get; set; } = new List<Ingridient>();
        public FoodImage FoodImage { get; set; } = new FoodImage();

    }

    public class FoodImage
    {
        public byte[] Content { get; set; }
        public string FileName { get; set; }
    }
}
