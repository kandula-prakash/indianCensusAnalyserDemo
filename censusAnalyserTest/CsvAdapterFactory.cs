using System;
using System.Collections.Generic;
using System.Text;
using censusAnalyserTest.POCO;

namespace censusAnalyserTest
{
   public class CsvAdapterFactory
    {
        public Dictionary<string, CensusDTO> LoadCsvData(CensusAnalyser.Country country, string CsvFilePath, string dataHeadres)
        {
            switch (country)
            {
                case (CensusAnalyser.Country.INDIA):
                    return new IndianCensusAdapter(). LoadCensusData(CsvFilePath, dataHeadres);
               // case (CensusAnalyser.country.US);
                    //return new USCensusAdapter().LoadUSCensusData(CsvFilePath, dataHeadres);

                default:
                    throw new CensusAnalyserException("No Such Country", CensusAnalyserException.ExceptionType.NO_SUCH_COUNTRY);
            }
        }
    }
}
