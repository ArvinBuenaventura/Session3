using Microsoft.VisualStudio.TestTools.UnitTesting;
using Session3HomeWork.Helpers;
using Session3HomeWork.Resources;
using Session3HomeWork.DataModels;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Session3HomeWork.Tests
{
    [TestClass]
    public class GetPet : ApiBaseTest
    {
        private static List<PetModel> petCleanUpList = new List<PetModel>();

        [TestInitialize]
        public async Task TestInitialize()
        {
            PetDetails = await PetHelper.AddNewPet(RestClient);
        }

        [TestMethod]
        public async Task GetNewPet()
        {
            //Arrange
            var restRequest = new RestRequest(PetEndpoint.GetPetById(PetDetails.Id));
            petCleanUpList.Add(PetDetails);

            //Act
            var restResponse = await RestClient.ExecuteGetAsync<PetModel>(restRequest);

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, restResponse.StatusCode, "Status code is not equal to 200");
            Assert.AreEqual(PetDetails.Name, restResponse.Data.Name, "Name did not match.");
            Assert.AreEqual(PetDetails.PhotoUrls[0], restResponse.Data.PhotoUrls[0], "Photo Urls did not match.");
            Assert.AreEqual(PetDetails.Category.Id, restResponse.Data.Category.Id, "Category ID did not match.");
            Assert.AreEqual(PetDetails.Category.Name, restResponse.Data.Category.Name, "Category Name did not match.");
            Assert.AreEqual(PetDetails.Tags[0].Id, restResponse.Data.Tags[0].Id, "Tags ID did not match.");
            Assert.AreEqual(PetDetails.Tags[0].Name, restResponse.Data.Tags[0].Name, "Tags Name did not match.");
            Assert.AreEqual(PetDetails.Status, restResponse.Data.Status, "Status did not match.");

        }

        [TestCleanup]
        public async Task TestCleanUp()
        {
            foreach (var data in petCleanUpList)
            {
                var deletePetRequest = new RestRequest(PetEndpoint.GetPetById(data.Id));
                var deletePetResponse = await RestClient.DeleteAsync(deletePetRequest);
            }
        }

    }
}



