using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarcodeGenerationAPI.Models
{
    public class BarcodeResponse
    {
        public string valueBarcoded { get; set; }
        public string barcodeImageString { get; set; }
    }
}