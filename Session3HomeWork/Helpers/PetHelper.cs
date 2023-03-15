using RestSharp;
using Session3HomeWork.DataModels;
using Session3HomeWork.Resources;
using Session3HomeWork.Tests.TestData;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Session3HomeWork.Helpers
{
    /// <summary>
    /// Class containing all methods for pet
    /// </summary>
    public class PetHelper
    {
        /// <summary>
        /// Send POST request to add new pet
        /// </summary>
        ///

        public static async Task<PetModel> AddNewPet(RestClient client)
        {
            var newPetData = GeneratePet.PetInfo();
            var postRequest = new RestRequest(PetEndpoint.PostPet());

            //Send Post Request to add new pet
            postRequest.AddJsonBody(newPetData);
            var postResponse = await client.ExecutePostAsync<PetModel>(postRequest);

            var createdPetData = newPetData;
            return createdPetData;
        }
    }
}
