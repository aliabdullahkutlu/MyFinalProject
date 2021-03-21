using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) //params ile siz virgülle istediğiniz kadar IResult türünde parametre ekleyebilirsiniz
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)  //kurala uymayanları döndürür
                {
                    return logic;
                }
            }
            return null;
        } 
    }
}
