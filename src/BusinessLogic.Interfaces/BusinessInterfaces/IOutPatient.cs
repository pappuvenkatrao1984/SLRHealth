using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResourceModel;

namespace BusinessInterfaces
{
    public interface IOutPatient
    {
        string GenerateOpNumber(OutPatient patitent);
        string GenerateBill();
        string SaveData(OutPatitentDetails patientDetails);
    }
}
