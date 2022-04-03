using Common.Data.Constants.Enums;
using Common.Helpers.Tcp;

namespace ServerOr
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpServerHelper tcpServerHelper = new TcpServerHelper(OperationTypes.OR); //TcpServerHelper nesnesi create edilir ve constructure 'da operationType verilir

            tcpServerHelper.Start(x => x.A | x.B);//Server calistirilir ve serverın yapacağı Func operation burada yazılır
            //verilen input A ve B | operatoru islemi ile OR opearasyonuna tabi tutulur
        }
    }
}
