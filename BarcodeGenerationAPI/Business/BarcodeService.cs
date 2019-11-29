using BarcodeGenerationAPI.Interfaces;
using BarcodeGenerationAPI.Models;
using IronBarCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;


namespace BarcodeGenerationAPI.Business
{
    public class BarcodeService : IBarcodeService
    {
        public async Task<List<BarcodeResponse>> GenerateBarcodeList(List<string> inputList)
        {
            
                List<BarcodeResponse> responseList = new List<BarcodeResponse>();
                foreach (string valueToBeBarcoded in inputList)
                {
                    responseList.Add(await GenerateBarcode(valueToBeBarcoded));
                }
                return responseList;
            
        }
        private async Task<BarcodeResponse> GenerateBarcode(string valueToBeBarcoded)
        {
            IronBarCode.License.LicenseKey = "IRONBARCODE-9616125CAA-158537-339F50-9F611B3982-4A8455EA-UEx8432422FE1B58D8-GEP.IRO190917.6315.38225.OEM.3PRO.1YR.SUPPORTED.UNTIL.17.SEP.2020";
            var generatedBarcode = BarcodeWriter.CreateBarcode(valueToBeBarcoded, BarcodeEncoding.Code128);
            byte[] ironImageArray = generatedBarcode.ToJpegBinaryData();
            BarcodeResponse response = new BarcodeResponse()
            {
                valueBarcoded = valueToBeBarcoded,
                barcodeImageString = Convert.ToBase64String(ironImageArray)
            };

            return response;
        }
    }
}