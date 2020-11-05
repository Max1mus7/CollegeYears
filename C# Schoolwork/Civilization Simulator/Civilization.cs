using System;
using System.Transactions;

namespace Civilization_Simulator
{
    abstract class Civilization
    {
        int StartDate { get; set; }
        //date civilization is created
        int EndDate { get; set; }
        //date civilization dies(if it becomes unsustainable)
        int PoliticalType { get; set; }
        //int for now until I decide to learn enums
        int EconomicType { get; set; }
        //int for now until I decide to learn enums
        double Population { get; set; }
        //civilization total population
        double Size { get; } 
        //area of civilization(most likely going to be set up for km^2)
        double PopDensity { get; set; }
        //population density of civlization(people/km^2)
        string CivName { get; set; }
        //Name of Civilization(more than likely going to be optional)
        decimal Gdp { get; set; }
        //GDP
    }
}
