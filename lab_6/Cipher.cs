// Milan Murray ~ 19 Oct 22
// Delegates

using System;
using System.Text;

namespace Encryption;

/*
	A system is required which allows for different ciphers to be used to encrypt plaintext messages into ciphertext. 
	Use a delegate to define a set of methods which take a plaintext message as input and return a ciphertext message. 

	Implement two different ciphers which can be plugged and played via the delegate. 
	The first cipher should be a simple Caeser cipher which shifts up every character in the plaintext by one character position. 
	The second cipher should just reverse the plaintext to form the ciphertext. 
*/

delegate string EncryptionDelegate(string text_in);

static class Cipher
{
	public static string Cipher1(string textIn)
	{
		const int key = 1;
		StringBuilder cipherText = new StringBuilder(textIn);

		int charWrap = (int)(char.MaxValue);

		for (int i = 0; i < cipherText.Length; i++)
		{
			cipherText[i] = (char)((cipherText[i] + key) % charWrap);
		}

		return cipherText.ToString();
	}

	public static void Main()
	{
		EncryptionDelegate ed1 = null;
		ed1 += Cipher1;
		Console.WriteLine(ed1("delegate"));
	}

}
