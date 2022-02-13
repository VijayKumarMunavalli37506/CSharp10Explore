using System;

namespace Regression
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linear Regression
            var xValues = new double[]
                            {
                                  1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998, 1999, 2000, 2001, 2002, 2003, 2004,
                                  2005, 2006, 2007, 2008, 2009
                            };
            var yValues = new double[]
                              {
                                  8669269, 8595500, 8484900, 8459800, 8427400, 8384700, 8340900, 8283200, 8230400, 8190900,
                                  8149468, 7932984, 7845841, 7801273, 7761049, 7720000, 7679290, 7640238, 7606551,
                                  7563710
                              };

            double rSquared, intercept, slope;
            LinearRegressionCore.LinearRegression(xValues, yValues, out rSquared, out intercept, out slope);

            Console.WriteLine($"R-squared = {rSquared}");
            Console.WriteLine($"Intercept = {intercept}");
            Console.WriteLine($"Slope = {slope}");

            var predictedValue = (slope * 2017) + intercept;
            Console.WriteLine($"Prediction for 2017: {predictedValue}");
        }
       
    }
}
