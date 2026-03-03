# Bank C# (Console)

A **console bank simulator** in C# with a text menu to manage a current account and a savings account.  
This project was created as part of the OpenClassrooms course *"Apprenez à programmer en C#"* to practice control flow, user input, and simple state management in a .NET console application.

---

## 🚀 Overview

The app runs in a loop: it displays a menu, waits for a key press, then lets the user choose an action. Two accounts are simulated in memory:

- **Current account** (*compte courant*) — Initial balance: 1000 €  
- **Savings account** (*compte épargne*) — Initial balance: 2000 €  

Available actions: view account holder info, view balance, deposit, or withdraw for each account. Deposits and withdrawals on the savings account are implemented as transfers to/from the current account.

The goal was to reinforce understanding of:

- Console I/O (`Console.ReadLine`, `Console.WriteLine`)
- Loops and switch/case for menu handling
- Static variables for shared state (balances)
- Basic arithmetic and type conversion (`Convert.ToInt32`)

---

## 🧠 Key Features

- **Text menu** — Options: account holder info (I), current account balance/deposit/withdraw (CS, CD, CR), savings balance/deposit/withdraw (ES, ED, ER), quit (Q)
- **Current account** — View balance, deposit (add to balance), withdraw (subtract from balance)
- **Savings account** — View balance; “deposit” transfers from current to savings; “withdraw” transfers from savings to current
- **Account holder info** — Displays a fixed identity (name, date of birth, address)
- **In-memory state** — No persistence; balances reset when the app exits

---

## 🛠 Tech Stack

<p align="center">
  <img src="https://skillicons.dev/icons?i=cs" />
</p>

- **C# / .NET 9** — Language and runtime
- **Console application** — No external packages; only the .NET SDK

---

## 🗂 Project Structure

```
Bank_C-/
├── README.md
├── Bank_C#.sln           # Solution file
├── ConsoleApp1.csproj    # Project file (.NET 9 console)
└── Program.cs            # Entry point, menu, account logic (single file)
```

- `Program.cs` — `Main` loop, `ShowMenu`, `UserMenuChoice`, and all account operations (show balance, deposit, withdraw) for both accounts.

---

## 📦 Installation

To run the project locally:

1. Clone the repo:
   ```bash
   git clone https://github.com/initd-fr/Bank_C-.git
   cd Bank_C-
   ```

2. Restore and run:
   ```bash
   dotnet restore
   dotnet run
   ```
   Or open the solution in Visual Studio / Rider and run the project.

3. Follow the on-screen menu: press Enter to show the menu, then type the option letter(s) (e.g. `CS`, `CD`, `Q`) and press Enter.

---

## 🖥 Usage

| Key | Action |
|-----|--------|
| **I**  | Show account holder info (name, DOB, address) |
| **CS** | Show current account balance |
| **CD** | Deposit into current account |
| **CR** | Withdraw from current account |
| **ES** | Show savings account balance |
| **ED** | Deposit into savings (transfer from current) |
| **ER** | Withdraw from savings (transfer to current) |
| **Q**  | Quit the application |

After each action the menu is shown again on the next Enter key press.

---

## 📌 Notes

- **Educational project** — No overdraft checks, no persistence, no input validation (e.g. negative amounts). Balances can go negative.
- **French UI** — Menu and messages are in French; logic is straightforward to adapt or extend.
- **Single file** — All logic lives in `Program.cs`; suitable for learning before refactoring into classes (e.g. `BankAccount`, `Customer`).
