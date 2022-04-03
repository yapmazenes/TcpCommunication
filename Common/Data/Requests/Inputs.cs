using Common.Data.Constants.Enums;
using System;

namespace Common.Data.Requests
{
    [Serializable]
    public class Inputs
    {
        public bool A { get; set; }
        public bool B { get; set; }
        public OperationTypes OperationType { get; set; }
    }
}
