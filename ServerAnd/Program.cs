using Common.Data.Constants.Enums;
using Common.Helpers.Tcp;

namespace ServerAnd
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpServerHelper tcpServerHelper = new TcpServerHelper(OperationTypes.AND); //TcpServerHelper nesnesi create edilir ve constructure 'da operationType verilir

            tcpServerHelper.Start(x => x.A & x.B); //Server calistirilir ve serverın yapacağı Func operation burada yazılır
            //verilen input A ve B & operatoru islemi ile AND opearasyonuna tabi tutulur
        }
    }
}
