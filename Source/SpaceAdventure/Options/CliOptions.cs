using CommandLine;
using System;

namespace SpaceAdventure.Options
{
    public class CliOptions
    {
        [Option('f', "Functionality", Required = true, HelpText = @"Choose functionality between ""Asteroid info"" and ""Picture info""")]
        public string Functionality { get; set; }

        [Option('s', "StartDate", Required = false, HelpText = "Starting date for asteroid search")]
        public DateTime StartDate { get; set; }

        [Option('e', "EndDate", Required = false, HelpText = "Ending date for asteroid search")]
        public DateTime EndDate { get; set; }

        [Option('d', "Date", Required = false, HelpText = "Date for picture info")]
        public DateTime Date { get; set; }

        [Option('p', "Path", Required = true, HelpText = "Path")]
        public string Path { get; set; }
    }
}