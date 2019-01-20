using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NutritionaData.Backend.Models;

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
    }
}