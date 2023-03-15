using System;
using System.Collections.Generic;
using System.Text;

namespace Session3HomeWork.Resources
{
    /// <summary>
    /// Class containing all endpoints used in API tests
    /// </summary>
    public class PetEndpoint
    {
        //Base URL
        public const string BaseURL = "https://petstore.swagger.io/v2";

        public static string GetPetById(long petID) => $"{BaseURL}/pet/{petID}";

        public static string PostPet() => $"{BaseURL}/pet";

        public static string DeletePetById(long petIdDel) => $"{BaseURL}/pet/{petIdDel}";
    }
}
