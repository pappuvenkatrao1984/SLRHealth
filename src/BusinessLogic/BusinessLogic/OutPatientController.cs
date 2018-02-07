using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessInterfaces;
using FluentValidation;
using ResourceModel;
using ResourceValidators;
using StructureMap;
using StructureMap.Configuration.DSL;


namespace BusinessLogic
{
    public class OutPatientController : IOutPatient
    {
        public string GenerateOpNumber(OutPatient patitent)
        {
            var container = new Container(new PatientRegistry());
            var instance = container.GetInstance<IValidator<OutPatient>>();
            var result =instance.Validate(patitent);
            var res1 = result.IsValid;
            return "0123";

        }

        public string GenerateBill()
        {
            throw new NotImplementedException();
        }

        public string SaveData(OutPatitentDetails patientDetails)
        {
            throw new NotImplementedException();
        }
    }
}
