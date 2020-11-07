using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using static ServiceMtk_P2_096.Matematika;

namespace ServiceMtk_P2_096
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMatematika
    {
        [OperationContract]
        [FaultContract(typeof(MathFault))]
        /* output->*/
        int Tambah(int a, int b); //method

        [OperationContract]
        [FaultContract(typeof(MathFault))]
        int Kurang(int a, int b); //input

        [OperationContract]
        [FaultContract(typeof(MathFault))]
        int Kali(int a, int b);

        [OperationContract]
        [FaultContract(typeof(MathFault))]
        int Bagi(int a, int b);

        [OperationContract]
        [FaultContract(typeof(MathFault))]
        Koordinat TKoordinat(Koordinat a, Koordinat b); //object dari class
    }


    [DataContract]
    class MathFault
    {
        [DataMember]
        public string Kode { get; set; }
        [DataMember]
        public string Pesan { get; set; }
    }
}
