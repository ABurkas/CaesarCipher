# CaesarCipher 👨‍💻

## Project Description
This project is a basic **encryption and decryption program** written in C#. It allows users to encrypt or decrypt text using a simple Caesar cipher (shift-based cipher). 
The user can specify whether they want to encrypt or decrypt the input text and provide the key (shift value) used for the transformation. The program ensures valid inputs for both the mode (`encrypt`/`decrypt`) and the shift key to prevent invalid operations.
<h2 align="center">Encryption</h2>

![C__Users_Właściciel_source_repos_CaesarCipher_CaesarCipher_bin_Debug_CaesarCipher exe 2025-03-08 15-46-31](https://github.com/user-attachments/assets/747a99c5-c031-4e97-9050-0ae17220284e)
<h2 align="center">Decryption</h2>

![C__Users_Właściciel_source_repos_CaesarCipher_CaesarCipher_bin_Debug_CaesarCipher exe 2025-03-08 15-47-51](https://github.com/user-attachments/assets/c10393d0-866f-4d7b-97b2-af0a765d2abf)

## Key Features

- **Input Validation**: Ensures that the user enters a valid encryption mode (`encrypt` or `decrypt`) and a valid numeric key for the shift.
- **Encryption/Decryption**: Provides two modes—`encrypt` and `decrypt`—to either shift characters forward or backward in the alphabet based on the provided key.
- **Support for Upper and Lower Case**: The program supports both upper and lower case letters in the input text while preserving the case of each character.
- **Handling Non-Alphabetic Characters**: Non-alphabetic characters, such as spaces and punctuation marks, are not affected by the encryption/decryption process and remain unchanged.
- **Flexible Key Entry**: The user can enter any integer as the key, and the program will handle positive and negative values to shift characters correctly.

## Problems Solved During Development

### **Input Validation**:
- **Problem**: Initial versions of the program would break if an invalid mode (neither `encrypt` nor `decrypt`) or a non-numeric key was entered.
- **Solution**: Implemented validation to ensure the user can only enter `encrypt` or `decrypt` as mode choices. For the key, the program uses `int.TryParse()` to validate that the user input is a valid integer.
- If invalid input is detected, the user is prompted to re-enter the correct values.

### **Handling Invalid Encryption/Decryption Mode**:
- **Problem**: Without proper validation, the program could fail when an invalid mode was entered (e.g., "encr" or "decryp").
- **Solution**: Added checks to ensure that the mode is only either `encrypt` or `decrypt`. If the mode is invalid, the program displays an error message and prompts the user to re-enter the correct mode.

### **Character Shifting with Caesar Cipher**:
- **Problem**: Shifting characters beyond the bounds of the alphabet (e.g., `'Z'` to `'A'`) required special handling to ensure proper wrapping around.
- **Solution**: The encryption and decryption functions handle character shifting using modulo arithmetic to ensure that letters wrap correctly. Upper and lower case letters are treated separately to preserve the case.

### **Handling Non-Alphabetic Characters**:
- **Problem**: Early versions of the program affected all characters, including punctuation marks and spaces, which led to undesired results.
- **Solution**: Non-alphabetic characters (spaces, punctuation) are ignored during the encryption and decryption process, meaning they remain unchanged in the output.

### **Program Flow Control**:
- **Problem**: Managing the flow of the program, including handling multiple inputs in a session and allowing users to quit the program gracefully, was a challenge.
- **Solution**: Implemented a simple loop that continuously prompts the user for input until a valid mode and key are provided. Users can quit by entering invalid inputs and receiving an error message.

## Conclusion
This encryption/decryption program offers a simple yet effective way to apply a Caesar cipher to text inputs. 
It is robust against invalid inputs (such as invalid modes and non-numeric keys) and provides clear feedback to the user in case of errors. 
The program serves as a good starting point for learning about basic encryption techniques and can be extended to include more complex ciphers or a graphical user interface (GUI) in the future.
