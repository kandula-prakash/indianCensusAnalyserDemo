using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using censusAnalyserTest.POCO;
using Newtonsoft.Json;
using censusAnalyserTest.DTO;


namespace censusAnalyserTest
{
    public class CensusAnalyser
    {
     
        
            public static int a = 10;
            public enum Country
            {
                INDIA, US, BRAZIL
            }


            Dictionary<string, CensusDTO> dataMap;
            public Dictionary<string, CensusDTO> LoadCensusData(string csvFilePath, Country country, string dataHeaders)
            {
                dataMap = new CsvAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
                return dataMap;
            }
        }
    }
