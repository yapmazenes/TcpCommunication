using Common.Data.Constants.Enums;
using Common.Data.Requests;
using Common.Helpers;
using System;
using System.Net;
using System.Net.Sockets;

namespace Common.Tcp
{
    public class TcpClientHelper
    {
        private TcpClient _tcpClient;

        private NetworkStream _networkStream;

        private string _ipAddress;

        public TcpClientHelper(string ipAddress)
        {
            _ipAddress = ipAddress;
        }

        public bool GetResult(OperationTypes operationType, Inputs inputs)
        {
            try
            {
                _tcpClient = new TcpClient();
                _tcpClient.Connect(IPAddress.Parse(_ipAddress), (int)operationType);
                _networkStream = _tcpClient.GetStream();
                var data = ObjectConverter.ToByteArray(inputs); //Converter sinifimin herangi bir objeyi ByteArray'a cevirme fonksiyonu

                _networkStream.Write(data, 0, data.Length); //İlgili data sonucu almak üzere TcpServer'a aktarılır
                _networkStream.Flush(); 

                data = new byte[(int)BufferSizes.Inputs]; //TcpServer'dan sonucu almak için bir Buffer olusturulur
                _networkStream.Read(data, 0, data.Length); //TcpServer'dan sonuc alınır

                var result = BitConverter.ToBoolean(data, 0); //Sonuc Boolean'a donusturulur 1-0

                _networkStream.Close();
                _tcpClient.Close();

                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
