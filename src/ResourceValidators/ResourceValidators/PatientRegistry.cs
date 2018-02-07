using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using ResourceModel;
using StructureMap.Configuration.DSL;

namespace ResourceValidators
{
    public class PatientRegistry : Registry
    {
        public PatientRegistry()
        {
            For<IValidator<OutPatient>>().Singleton().Use<OutPatientValidator>();
        }
    }
}
