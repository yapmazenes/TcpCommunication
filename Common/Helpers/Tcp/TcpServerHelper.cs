using Common.Data.Constants.Enums;
using Common.Data.Requests;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Common.Helpers.Tcp
{
    public class TcpServerHelper
    {
        private TcpListener _tcpListener;
        private TcpClient _tcpClient;
        private NetworkStream _networkStream;

        private readonly OperationTypes _operationType;

        public TcpServerHelper(OperationTypes operationType)
        {
            _operationType = operationType;
            _tcpListener = new TcpListener(IPAddress.Any, (int)_operationType); //Dinlenilecek port, operationType'dan alınır
        }

        public void Start(Func<Inputs, bool> operation)
        {
            try
            {
                _tcpListener.Start(); //Sunucu dinlemeye başlar
                var thread = new Thread(new ParameterizedThreadStart(ExecuteOperation)); //Parametre alan Thread fonksiyonu start edilir
                thread.Start(operation); //Thread başlatılır ve Start metoduna gelen Func ilgili metoda verilir.

                Console.WriteLine($"Listening on port: {(int)_operationType}...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void ExecuteOperation(object operation)
        {
            while (true)
            {
                _tcpClient = _tcpListener.AcceptTcpClient();
                _networkStream = _tcpClient.GetStream();

                byte[] data = new byte[(int)BufferSizes.Inputs];
                _networkStream.Read(data, 0, data.Length); //ilgili parametreler alınır ve data Buffer'ı içerisine aktarılır

                var inputs = (Inputs)ObjectConverter.FromByteArray(data); //ByteArray Objeye Convert edilir
                Console.WriteLine($"A: {BitConverterExtension.GetBit(inputs.A) } {_operationType} B: {BitConverterExtension.GetBit(inputs.B)}");

                bool result = ((Func<Inputs, bool>)operation)(inputs); //İlgili Func operation'ına gelen input verilir ve sonuç alınır

                data = BitConverter.GetBytes(result); //Gelen sonuç ByteArray a çevrilir

                _networkStream.Write(data, 0, data.Length); //Dinleyen TcpClient'a sonuç gönderilir
                _networkStream.Flush();

                _networkStream.Close();
                _tcpClient.Close();
            }
        }

    }

}
