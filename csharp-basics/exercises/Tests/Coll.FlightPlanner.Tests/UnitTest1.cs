using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;

namespace Coll.FlightPlanner.Tests
{
    public class UnitTest1
    {
        string[] input = {"San Jose -> San Francisco", "San Jose -> Anchorage", "New York -> Anchorage", "New York -> San Jose", "New York -> San Francisco",
            "New York -> Honolulu", "Anchorage -> New York", "Anchorage -> San Jose", "Honolulu -> New York", "Honolulu -> San Francisco",
            "San Francisco -> New York", "San Francisco -> Honolulu"};

        [Fact]
        public void GetRout_CitiesFromInput_InformationOfRout()
        {

            var expect = "New York -> Anchorage, New York -> San Jose, New York -> San Francisco, New York -> Honolulu";
            var result = Pogram.Travel("New York");

            Assert.Equal(expect, result);

        }
    }
}