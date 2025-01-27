// using System.Text;
//
// namespace CeasarCipher;
//
// public class CaesarCipher
// {
//     public static string Encode(string message, int shift)
//     {
//         string alphabet = "abcdefghijklmnopqrstuvwxyz";
//         string newMessage = "";
//
//         foreach (char letter in message)
//         {
//             if (alphabet.Contains(letter))
//             {
//                 int nextLetter = alphabet.IndexOf(letter) + shift;
//                 newMessage += alphabet[nextLetter];
//             }
//             else
//             {
//                 newMessage += letter;
//             }
//         }
//         return newMessage;
//     }
// }