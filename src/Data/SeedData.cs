using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NutritionData.Backend.Models;
using NutritionData.Backend.Models.food;

namespace NutritionData.Backend.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new NutritionDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<NutritionDataContext>>()))
            {
                if (context.Foods.Any())
                {
                    return;   // DB has been seeded
                }

                List<Weight> weights = GetWeights();
                List<SourceCode> sourceCodes = GetSourceCodes();
                List<Source> sources = GetDataSources();
                List<Footnote> footnotes = GetFootnotes();
                List<FoodGroup> foodGroups = GetFoodGroups();
            }
        }

        /// <summary>
        /// Gets weights from weights CSV/TXT file.
        /// </summary>
        /// <returns>List of weights</returns>
        public static List<Weight> GetWeights()
        {
            return System.IO.File.ReadAllLines(@"Data/WEIGHT.txt")
                .Select(row => row.Split('^'))
                .Select(columns => new Weight
                {
                    NDBNumber = columns[0].Replace("~", ""),
                    SequenceNumber = columns[1].Replace("~", ""),
                    Amount = Double.TryParse(columns[2], out double amount) ? amount : -1,
                    Description = columns[3].Replace("~", ""),
                    Grams = Double.TryParse(columns[4], out double grams) ? grams : -1,
                    NumberDataPoints = Int32.TryParse(columns[5], out int numberDataPoints) ? numberDataPoints : -1,
                    StandardDeviation = Double.TryParse(columns[6], out double standardDeviation) ? standardDeviation : -1

                })
                .ToList();
        }

        public static List<SourceCode> GetSourceCodes()
        {
            return System.IO.File.ReadAllLines(@"Data/SRC_CD.txt")
                .Select(row => row.Split('^'))
                .Select(columns => new SourceCode
                {
                    SourceCodeId = columns[0].Replace("~", ""),
                    Description = columns[1].Replace("~", "")
                })
                .ToList();
        }

        public static List<Source> GetDataSources()
        {
            return System.IO.File.ReadAllLines(@"Data/DATA_SRC.txt")
                .Select(row => row.Split('^'))
                .Select(columns => new Source
                {
                    SourceId = columns[0].Replace("~", ""),
                    Authors = columns[1].Replace("~", ""),
                    Title = columns[2].Replace("~", ""),
                    Year = columns[3].Replace("~", ""),
                    Journal = columns[4].Replace("~", ""),
                    Volume = columns[5].Replace("~", ""),
                    Issue = columns[6].Replace("~", ""),
                    StartPage = columns[7].Replace("~", ""),
                    EndPage = columns[8].Replace("~", "")
                })
                .ToList();
        }

        public static List<Footnote> GetFootnotes()
        {
            return System.IO.File.ReadAllLines(@"Data/FOOTNOTE.txt")
                .Select(row => row.Split('^'))
                .Select(columns => new Footnote
                {
                    NDBNumber = columns[0].Replace("~", ""),
                    SequenceNumber = columns[1].Replace("~", ""),
                    Type = columns[2].Replace("~", ""),
                    NutrientNumber = columns[3].Replace("~", ""),
                    Text = columns[4].Replace("~", "")
                })
                .ToList();
        }

        public static List<FoodGroup> GetFoodGroups()
        {
            return System.IO.File.ReadAllLines(@"Data/FD_GROUP.txt")
                .Select(row => row.Split('^'))
                .Select(columns => new FoodGroup
                {
                    FoodGroupId = columns[0].Replace("~", ""),
                    Name = columns[1].Replace("~", "")
                })
                .ToList();
        }

        public static List<Description> GetFoodDescriptions()
        {
            return System.IO.File.ReadAllLines(@"Data/FD_GROUP.txt")
                .Select(row => row.Split('^'))
                .Select(columns => new Description
                {
                    NDBNumber = columns[0].Replace("~", ""),
                    LongDescription = columns[2].Replace("~", ""),
                    ShortDescription = columns[3].Replace("~", ""),
                    CommonName = columns[4].Replace("~", ""),
                    Manufacturer = columns[5].Replace("~", ""),
                    Survey = columns[6].Replace("~", "").Equals("Y"),
                    RefuseDescription = columns[7].Replace("~", ""),
                    RefusePercent = Double.TryParse(columns[8], out double amount) ? amount : -1,
                    ScientificName = columns[9].Replace("~", "")
                })
                .ToList();
        }
    }
}