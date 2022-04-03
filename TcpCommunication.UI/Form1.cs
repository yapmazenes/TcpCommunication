using Common.Data.Constants.Enums;
using Common.Data.Requests;
using Common.Helpers;
using Common.Tcp;
using System.Windows.Forms;
/*
 * Muzaffer Enes Yapmaz 31.08.2020
 * Sonuclar
 * App
 * (1,1,AND) => 1
 * (1,0,AND) => 0
   (0,1,AND) => 0
   (0,0,AND) => 0
   
    ServerAnd
    Listening on port: 8080...
    A: 1 AND B: 1
    ...
    ---------------------------------
    App
 * (1,1,OR) => 1
 * (1,0,OR) => 1
   (0,1,OR) => 1
   (0,0,OR) => 0
   
    ServerOr
    Listening on port: 8081...
    A: 1 OR B: 1
    ...

 */

namespace Mul3
{
    public partial class Form1 : Form
    {
        TcpClientHelper tcpHelper = new TcpClientHelper("127.0.0.1"); //TcpClientHelper sınıfından bir nesne olusturulur ve Hangi ip adresini dinleyeceği belirtilir

        public Form1()
        {
            InitializeComponent();
        }

        private Inputs GetInputs() => //UI 'dan ilgili data'lar alınır

            new Inputs
            {
                A = _rbA1.Checked,
                B = _rbB1.Checked
            };

        private void SetResult(bool result) => _lblResult.Text = BitConverterExtension.GetBit(result).ToString(); //Sonuc ilgili label'a gönderilir

        private void _btnOr_Click(object sender, System.EventArgs e)
        { //OR butonuna basılır
            var inputs = GetInputs(); //Input'lar alınır 

            inputs.OperationType = OperationTypes.OR; //OperationType belirtilir

            var result = tcpHelper.GetResult(OperationTypes.OR, inputs); //tcpClientHelper'a Or islemi yapılacagi belirtilir ve ilgili input'lar verilir

            SetResult(result); //Sonuc yazdirilir
        }

        private void _btnAnd_Click(object sender, System.EventArgs e)
        {
            var inputs = GetInputs();

            inputs.OperationType = OperationTypes.AND;

            var result = tcpHelper.GetResult(OperationTypes.AND, inputs);

            SetResult(result);
        }
    }
}
