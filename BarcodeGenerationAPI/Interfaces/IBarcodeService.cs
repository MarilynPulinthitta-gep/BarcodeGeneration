using BarcodeGenerationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeGenerationAPI.Interfaces
{
    public interface IBarcodeService
    {
        Task<List<BarcodeResponse>> GenerateBarcodeList(List<string> inputList);
    }
}
