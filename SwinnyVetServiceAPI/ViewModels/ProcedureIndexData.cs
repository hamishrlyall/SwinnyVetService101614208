using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SwinnyVetServiceAPI.Models;

namespace SwinnyVetServiceAPI.ViewModels
{
    public class ProcedureIndexData
    {
        public IEnumerable<Procedure> Procedure { get; set; }
        public IEnumerable<Treatment> Treatments { get; set; }
        public IEnumerable<Owner> Owner { get; set; }
        public IEnumerable<Pet> Pet { get; set; }

    }
}