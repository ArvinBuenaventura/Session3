using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Session3HomeWork.DataModels;

namespace Session3HomeWork.Tests.TestData
{
    public class GeneratePet
    {
        public static PetModel PetInfo()
        {
            return new PetModel
            {
                Id = 159,
                Name = "Milktzy",
                PhotoUrls = new string[] { "catUrl" },
                Category = new Category { Id = 258, Name = "Cat" },
                Tags = new Category[] { new Category { Id = 258, Name = "White" } },
                Status = "available"
            };
        }
    }
}
