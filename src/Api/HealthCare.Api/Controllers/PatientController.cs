using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessInterfaces;
using ResourceModel;

namespace HealthCare.Api.Controllers
{       
    public class PatientController : ApiController
    {
        public IOutPatient _outPatient;
        public PatientController(IOutPatient patient)
        {
            _outPatient = patient;
        }

        public void Get()
        {
            OutPatient patient = new OutPatient();
            patient.Addr1 = "New Maruthi Nagar";
            patient.Addr2 = "Hyderabad";
            patient.City = "Hyd";
            patient.Dob = new DateTime(1984, 06, 10);
            patient.FirstName = "Pappu";
            patient.LastName = "Venkatrao";
            patient.Gender = "Male";
            long phone = 9985010756;
            patient.PhoneNumber = phone;
            patient.State = "Andhra Pradesh";
            patient.ZipCode = 533201;
            patient.Country = "India";
            var result = _outPatient.GenerateOpNumber(patient);
            var res = result;
        }
    }
}
