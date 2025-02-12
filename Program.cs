namespace BankAccount
{
    class Program
    {
        public static int currentAccountSold = 1000;
        public static int savingsAccountSold = 2000;
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Appuyez sur Entrée pour afficher le menu");
                Console.ReadLine(); // Attendre l'appui sur Entrée
                ShowMenu();
                UserMenuChoice();
            }

        }

        static void ShowMenu()
        {
            Console.WriteLine("[I] Voir les informations sur le titulaire du compte");
            Console.WriteLine("[CS] Compte courant - Consulter le solde");
            Console.WriteLine("[CD] Compte courant - Déposer des fonds");
            Console.WriteLine("[CR] Compte courant - Retirer des fonds");
            Console.WriteLine("[ES] Compte épargne - Consulter le solde");
            Console.WriteLine("[ED] Compte épargne - Déposer des fonds");
            Console.WriteLine("[ER] Compte épargne - Retirer des fonds");
            Console.WriteLine("[Q] Quitter");
        }
        static void UserMenuChoice()
        {
            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "I":
                    ShowAccountInfo();
                    break;
                case "CS":
                    ShowCurrentAccountSold();
                    break;
                case "CD":
                    DepositCurrentAccount();
                    break;
                case "CR":
                    WithdrawCurrentAccount();
                    break;
                case "ES":
                    ShowSavingsAccountSold();
                    break;
                case "ED":
                    DepositSavingsAccount();
                    break;
                case "ER":
                    WithdrawSavingsAccount();
                    break;
                case "Q":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Choix invalide");
                    break;
            }
        }

        // ? Show account sold
        static void ShowCurrentAccountSold()
        {
            Console.WriteLine("Le solde de votre compte courant est de " + currentAccountSold + " euros");
        }

        // ? Show savings account sold
        static void ShowSavingsAccountSold()
        {
            Console.WriteLine("Le solde de votre compte épargne est de " + savingsAccountSold + " euros");
        }


        // ? Deposit funds in accounts
        static void DepositCurrentAccount()
        {
            Console.WriteLine("Combien souhaitez-vous déposer sur votre compte courant ?");
            int deposit = Convert.ToInt32(Console.ReadLine());
            currentAccountSold += deposit;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Dépôt en cours...");
            }
            Console.WriteLine("Votre nouveau solde est de " + currentAccountSold + " euros");
        }

        // ? Deposit funds in savings account
        static void DepositSavingsAccount()
        {
            Console.WriteLine("Combien souhaitez-vous déposer sur votre compte epargne ?");
            int deposit = Convert.ToInt32(Console.ReadLine());
            currentAccountSold -= deposit;
            savingsAccountSold += deposit;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Dépôt en cours...");
            }
            Console.WriteLine("Votre nouveau solde est de " + savingsAccountSold + " euros");
        }

        // ? Withdraw funds from accounts
        static void WithdrawCurrentAccount()
        {
            Console.WriteLine("Combien souhaitez-vous retirer de votre compte courant ?");
            int withdraw = Convert.ToInt32(Console.ReadLine());
            currentAccountSold -= withdraw;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Retrait en cours...");
            }
            Console.WriteLine("Votre nouveau solde est de " + currentAccountSold + " euros");
        }

        // ? Withdraw funds from savings account
        static void WithdrawSavingsAccount()
        {
            Console.WriteLine("Combien souhaitez-vous retirer de votre compte épargne ?");
            int withdraw = Convert.ToInt32(Console.ReadLine());
            savingsAccountSold -= withdraw;
            currentAccountSold += withdraw;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Retrait en cours...");
            }
            Console.WriteLine("Votre nouveau solde est de " + savingsAccountSold + " euros");
        }


        static void ShowAccountInfo()
        {
            Console.WriteLine("Nom : Dupont");
            Console.WriteLine("Prénom : Jean");
            Console.WriteLine("Date de naissance : 01/01/2000");
            Console.WriteLine("Adresse : 1 rue de la Paix, 75000 Paris");
        }


    }
}