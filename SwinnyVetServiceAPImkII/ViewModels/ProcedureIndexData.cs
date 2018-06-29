using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SwinnyVetServiceAPImkII.Models;

namespace SwinnyVetServiceAPImkII.ViewModels
{
    public class ProcedureIndexData
    {
        public IEnumerable<Procedure> Procedures { get; set; }
        public IEnumerable<Treatment> Treatments { get; set; }
        public IEnumerable<Owner> Owners { get; set; }
        public IEnumerable<Pet> Pets { get; set; }

    }
}