using System;
using QRCoder;

class Program
{
    static void Main()
    {
        Console.Write("input text or url for QR-code: ");
        string inputText = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(inputText, QRCodeGenerator.ECCLevel.Q);

        Console.WriteLine("QR-code:");
        Console.WriteLine();
        PrintQRCode(qrCodeData);
    }

    // show image QR-code to console
    static void PrintQRCode(QRCodeData qrCodeData)
    {
        for (int y = 0; y < qrCodeData.ModuleMatrix.Count; y++)
        {
            for (int x = 0; x < qrCodeData.ModuleMatrix[y].Count; x++)
            {
                char module = qrCodeData.ModuleMatrix[y][x] ? '\u2588' : ' ';
                Console.Write(module);
            }
            Console.WriteLine();
        }
    }
}
