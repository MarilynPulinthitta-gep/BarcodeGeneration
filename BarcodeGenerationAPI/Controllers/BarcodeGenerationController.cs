using BarcodeGenerationAPI.Interfaces;
using BarcodeGenerationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarcodeGenerationAPI.Controllers
{
    public class BarcodeGenerationController : ApiController
    {
        private IBarcodeService barcodeService;

        public BarcodeGenerationController(IBarcodeService service)
        {
            this.barcodeService = service;
        }

        [HttpPost]
        public List<BarcodeResponse> BarcodeGenerationByValue([FromBody] List<string> inputList)
        {
            try
            {
                List<BarcodeResponse> barcodeResponseList = barcodeService.GenerateBarcodeList(inputList).Result;
                return barcodeResponseList;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
