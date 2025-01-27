using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace CaesarCipher;

public class CaesarCipher
{
    public static string Encode(string message, int shift)
    {
        //string of the alphabet
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string capAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //variable to store the encoded message
        string newMessage = "";

        //loops through each letter in the message
        foreach (char letter in message)
        {
            //if the letter is in the alphabet..
            if (alphabet.Contains(letter))
            {
                //get the position of the shifted letter
                int shiftPos = (alphabet.IndexOf(letter) + shift) % 26;
                //add that letter to the new message
                newMessage += alphabet[shiftPos];
            }
            else if (capAlphabet.Contains(letter))
            {
                int shiftPos = (capAlphabet.IndexOf(letter) + shift) % 26;
                //add that letter to the new message
                newMessage += capAlphabet[shiftPos];
            }
            //if it isn't in the alphabet
            else
            {
                //dont shift it and just add it to the message 
                newMessage += letter;
            }
        }
        //return the new message
        return newMessage;
    }

    public static string Decode(string message, int shift) => Encode(message, 26 - shift);
}