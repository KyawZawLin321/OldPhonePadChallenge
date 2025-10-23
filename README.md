# OldPhonePadChallenge

## Overview

This project implements an **Old Phone Keypad text input system** in C#. The application converts a sequence of numeric keypad presses (like on old mobile phones) into the corresponding text output, supporting:

- Multiple letters per key (e.g., `2` → `A`, `22` → `B`, `222` → `C`)
- Pause between same-key presses (represented by space)
- Backspace functionality using `*`
- End of input using `#`

The solution is designed to be **production-ready, robust, and maintainable**, following professional engineering standards.

---

## Features

- Converts sequences like `"4433555 555666#"` → `"HELLO"`
- Handles backspaces with `*` (removes the last typed character)
- Supports punctuation for key `1` (`.,!?`)
- Supports spaces via `0`
- Handles complex sequences like `"8 88777444666*664#"` → `"TURING"`

---

## Project Structure
```
OldPhonePadChallenge/
├─ OldPhonePadChallenge/               # Main project
├─ OldPhonePadChallenge/OldPhone.cs    # Core logic for OldPhonePad method
├─ OldPhonePadChallenge.Tests/         # xUnit test project
├─ OldPhonePadChallenge.Tests/OldPhonePadTests.cs # Unit tests for OldPhonePad
└─ README.md                           # This file

---
```
## How to Run

1. Clone the repository:
   ```bash
   git clone <repository-url>
   cd OldPhonePadChallenge
2. Build the project:
   ```bash
   dotnet build
   ```
3. Run the program:
   ```
   dotnet run --project OldPhonePadChallenge
4. Enter keypad input sequences ending with #, for example:
   ```
   Enter input (end with #): 4433555 555666#
   Output: HELLO
Running Tests

This project uses xUnit for testing. To run all tests: 
   ```
   dotnet test
   ```
Example test cases:
| Input                | Expected Output |
| -------------------- | --------------- |
| `33#`                | `E`             |
| `227*#`              | `B`             |
| `4433555 555666#`    | `HELLO`         |
| `8 88777444666*664#` | `TURING`        |

AI Usage

To tidy up and refactor the code, OpenAI GPT-4 was used with the following prompt:
"Refactor and optimize this C# OldPhonePad method to correctly handle backspaces, multiple key presses, spaces, and end-of-input, ensuring it passes all test cases."
Core problem-solving and logic were implemented manually.

Notes
-The solution is designed to be extensible, allowing easy modification of the keypad mapping.

-Backspace (*) always removes the last character typed.

-Space ( ) is treated as a pause between repeated presses of the same key.

-Input must always end with # to signal completion.

Author

Kyaw Zaw Lin

Junior Software Engineer Applicant – Iron Software




