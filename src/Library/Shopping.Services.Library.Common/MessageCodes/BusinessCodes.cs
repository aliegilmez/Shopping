namespace Shopping.Services.Library.Common.MessageCodes
{
    public class BusinessCodes
    {
        public const string SystemError = "FBE000"; // istek atılır. Sonucu hatalı döner.
        public const string TokenIsNullOrEmpty = "FBE001"; //Token is Null or Empty
        public const string PaymentPageIsNull = "FBE002"; //Payment Page is Null
        public const string NoInvoiceData = "FBE003"; //There is No Invoice Data
        public const string TransactionIsNull = "FBE004"; //Transaction Is Null
        public const string TransactionError = "FBE005"; //There is Transaction Error
        public const string SignatureNull = "FBE006"; //Signature Is Null
        public const string SignatureNotMatching = "FBE007"; //Signature is not matching
        public const string InvoiceCheckError = "FBE008"; //Invoice Data Check Error
        public const string SystemErrorWithParameters = "FBE010"; //sisteme atılan istekte sistemden dönen hatanın mesajını basar.
        public const string TimeExpired = "FBE011"; //Para yatırma işlemi süresince para yatırılmadı.

    }
}
