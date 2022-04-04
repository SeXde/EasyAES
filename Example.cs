using System.Text;
using System.Security.Cryptography;

// Example

string message = "Don't trust mr five";
string password = "Super secret password 100% real no fake";

var tuple = EasyAES.Encrypt(message, password);
string encrypted = tuple.Item1;
byte[] iv = tuple.Item2;
string decrypted = EasyAES.Decrypt(encrypted, password, iv);

Console.WriteLine("The encrypted text is: {0}", encrypted);
Console.WriteLine("The decrypted text is: {0}", decrypted);

