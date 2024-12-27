using System;
using System.Text;

namespace PlayFair
{
    public class PlayFairCipher
    {
        private char[,] keyMatrix;

        // Constructor
        public PlayFairCipher() { }

        // Generate the key matrix based on the provided key
        public void GenerateMatrix(string key)
        {
            key = key.ToLower().Replace(" ", "").Replace("j", "i");
            StringBuilder keyBuilder = new StringBuilder();
            bool[] seen = new bool[26];

            // Add characters from the key to the matrix
            foreach (char c in key)
            {
                if (c >= 'a' && c <= 'z' && !seen[c - 'a'])
                {
                    keyBuilder.Append(c);
                    seen[c - 'a'] = true;
                }
            }

            // Fill the remaining matrix with other letters
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (c != 'j' && !seen[c - 'a'])
                {
                    keyBuilder.Append(c);
                }
            }

            // Populate the 5x5 key matrix
            keyMatrix = new char[5, 5];
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    keyMatrix[i, j] = keyBuilder[index++];
                }
            }
        }

        // Encrypt the plaintext
        public string Encrypt(string plaintext)
        {
            plaintext = PrepareInput(plaintext);
            StringBuilder ciphertext = new StringBuilder();

            for (int i = 0; i < plaintext.Length; i += 2)
            {
                var pos1 = FindPosition(plaintext[i]);
                var pos2 = FindPosition(plaintext[i + 1]);

                if (pos1.Item1 == pos2.Item1)
                {
                    // Same row
                    ciphertext.Append(keyMatrix[pos1.Item1, (pos1.Item2 + 1) % 5]);
                    ciphertext.Append(keyMatrix[pos2.Item1, (pos2.Item2 + 1) % 5]);
                }
                else if (pos1.Item2 == pos2.Item2)
                {
                    // Same column
                    ciphertext.Append(keyMatrix[(pos1.Item1 + 1) % 5, pos1.Item2]);
                    ciphertext.Append(keyMatrix[(pos2.Item1 + 1) % 5, pos2.Item2]);
                }
                else
                {
                    // Rectangle
                    ciphertext.Append(keyMatrix[pos1.Item1, pos2.Item2]);
                    ciphertext.Append(keyMatrix[pos2.Item1, pos1.Item2]);
                }
            }

            return ciphertext.ToString();
        }

        // Decrypt the ciphertext
        public string Decrypt(string ciphertext)
        {
            StringBuilder plaintext = new StringBuilder();

            for (int i = 0; i < ciphertext.Length; i += 2)
            {
                var pos1 = FindPosition(ciphertext[i]);
                var pos2 = FindPosition(ciphertext[i + 1]);

                if (pos1.Item1 == pos2.Item1)
                {
                    // Same row
                    plaintext.Append(keyMatrix[pos1.Item1, (pos1.Item2 + 4) % 5]);
                    plaintext.Append(keyMatrix[pos2.Item1, (pos2.Item2 + 4) % 5]);
                }
                else if (pos1.Item2 == pos2.Item2)
                {
                    // Same column
                    plaintext.Append(keyMatrix[(pos1.Item1 + 4) % 5, pos1.Item2]);
                    plaintext.Append(keyMatrix[(pos2.Item1 + 4) % 5, pos2.Item2]);
                }
                else
                {
                    // Rectangle
                    plaintext.Append(keyMatrix[pos1.Item1, pos2.Item2]);
                    plaintext.Append(keyMatrix[pos2.Item1, pos1.Item2]);
                }
            }

            return plaintext.ToString();
        }

        // Prepare the plaintext by removing spaces and making the length even
        private string PrepareInput(string input)
        {
            input = input.ToLower().Replace(" ", "").Replace("j", "i");
            StringBuilder prepared = new StringBuilder(input);

            for (int i = 0; i < prepared.Length - 1; i += 2)
            {
                if (prepared[i] == prepared[i + 1])
                {
                    prepared.Insert(i + 1, 'x');
                }
            }

            if (prepared.Length % 2 != 0)
            {
                prepared.Append('z');
            }

            return prepared.ToString();
        }

        // Find the position of a character in the key matrix
        private (int, int) FindPosition(char c)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (keyMatrix[i, j] == c)
                    {
                        return (i, j);
                    }
                }
            }
            throw new ArgumentException($"Character {c} not found in key matrix.");
        }
    }
}
