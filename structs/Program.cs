namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Guest[] n = new Guest[10];
            Console.Write("How many rooms will be rented? ");
            var room = int.Parse(Console.ReadLine());

            for (int i = 0; i < room; i++)
            {
                Console.WriteLine($"Rent #{i + 1}");
                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.Write("Email: ");
                var email = Console.ReadLine();
                Console.Write("Room: ");
                var number = int.Parse(Console.ReadLine());
                n[number] = new Guest(name, email);
            }
            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++)
            {
                if (n[i] != null)
                    Console.WriteLine($"{i}: {n[i]}");
            }

        }
    }
    class Guest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Guest(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public override string ToString()
        {
            return $"{Name}, {Email}";
        }
    }
}