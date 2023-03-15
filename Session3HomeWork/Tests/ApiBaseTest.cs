using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using Session3HomeWork.DataModels;
using Session3HomeWork.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3HomeWork.Tests
{
    public class ApiBaseTest
    {
        public RestClient RestClient { get; set; }

        public PetModel PetDetails { get; set; }

        [TestInitialize]
        public void Initilize()

        {
            RestClient = new RestClient();
        }

        [TestCleanup]
        public void CleanUp()
        {

        }
    }
}
