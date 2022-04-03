# TcpCommunication
Network Programming: Tcp Communication Project

İlgili solution içerisinde 1 .NetFramework ve 2 .NetCore olmak üzere 2 farklı çatıda proje geliştirilmiştir ve her iki çatıda da ortak olarak kullanılması gereken
Class'lar mevcuttur. Bu Class'ları her 3 projede de tekrar etmemek için Common adında farklı bir Class library oluşturulmuştur. Bu library'nin
her iki Framework'e de hizmet edebilmesi için bu library .Net Standart Library olarak seçilmiştir.

İçerisinde Enumlar, Request şablonu ve Helper'lar yer almaktadır.
BufferSizes.cs isimli enum ortak olarak TcpClient ve Server'larda ortak kullanılan Byte buffer'ların boyutunu temsil etmektedir.

OperationTypes.cs isimli enum ise AND ve OR işlemlerinin hangi portlar üzerinde yapılacağını temsil etmektedir.
Requests/Inputs.cs ise gelecek değerlerin şablonunu tutmaktadır.

Helpers/Tcp/TcpClientHelper.cs ve TcpServerHelper.cs isimli iki helper Server'larımızda ve Client'larımızda yapılacak işlemleri barındırmaktadır.
Bir Tcp Serverını dinlemek için TcpClientHelper'ın constructure metoduna Server'ın ipAddress'ini. 
GetResult metoduna ise OperationTypes'ını ve Inputs' bilgilerini vermek yeterli.

BitConverterExtension.cs
-Gelen bool değişkenini bit tipine dönüştürür. (True:1, False:0)

ObjectConverter.cs
Kendisine verilen ToByteArray metoduna verilen Object nesnesini BinaryFormatter sınıfından, MemoryStream sınıfının içerisine objeyi serilize
eder.Ardından ToArray metodu ile diziye dönüştürülür.

Aynı mantıkla FromByteArray metodu ile tam tersi işlem yapılır ve ByteArray'den Object nesnesine cast edilir.

ServerAnd Projesi

Program.cs

TcpServerHelper tcpServerHelper = new TcpServerHelper(OperationTypes.AND); server sınıfından bir nesne oluşturulur ve server'ın hangi 
portu kullanacağı OperationTypes olarak verilir.

tcpServerHelper.Start(x => x.A & x.B);  Server start edilir ve Func olarak yapılacak işlem şablonu verilir.

ServerOr Projesi

TcpServerHelper tcpServerHelper = new TcpServerHelper(OperationTypes.OR);

tcpServerHelper.Start(x => x.A | x.B);  Şablon verilir


 TcpClientHelper tcpHelper = new TcpClientHelper("127.0.0.1");  Server'a bağlantı kurulur

 GetInputs metodu ile A ve B değişkenleri UI 'dan elde edilir.

 _btnOr_Click event'i ile Or fonksionu tetiklenir ve şu şekildedir.

 gelen input içerisine;

  inputs.OperationType = OperationTypes.OR; verilir.
   
   var result = tcpHelper.GetResult(OperationTypes.OR, inputs);  TcpHelper nesnesinden sonuç elde edilir.

   SetResult(result); ile sonuç label etiketine yazdırılır.
