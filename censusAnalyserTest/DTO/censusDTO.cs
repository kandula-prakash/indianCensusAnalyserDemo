using System;
using System.Collections.Generic;
using System.Text;
using censusAnalyserTest.POCO;
using censusAnalyserTest.DTO;

namespace censusAnalyserTest.DTO
{
   public class censusDTO
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public int tin;
        public string stateCode;
        public long population;
        public long area;
        public long density;
        public long housingUnits;
        public double totalArea;
        public double waterArea;
        public double landArea;
        public double populationDensity;
        public double housingDensity;

        public censusDTO(StateCodeDAO stateCodeDao)
        {
            this.serialNumber = stateCodeDao.serialNumber;
            this.stateName = stateCodeDao.stateName;
            this.tin=stateCodeDao.tin;
            this.stateCode = stateCodeDao.stateCode;

        }
        public censusDTO(CensusDataDAO censusDataDao)
        {
            this.state = censusDataDao.state;
            this.area = censusDataDao.area;
            this.population = censusDataDao.population;
            this.density = censusDataDao.density;
        }
        //public censusDTO(USCensusDAO usCensusDAO)
        //{
        //    this.stateCode = usCensusDAO.stateCode;
        //    this.stateName = usCensusDAO.stateName;
        //    this.population = usCensusDAO.population;
        //    this.housingUnits = usCensusDAO.housingUnits;
        //    this.totalArea = usCensusDAO.totalArea;
        //    this.waterArea = usCensusDAO.waterArea;
        //    this.landArea = usCensusDAO.landArea;
            



        }
           
    }

