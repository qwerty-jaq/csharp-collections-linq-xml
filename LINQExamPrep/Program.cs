namespace LINQExamPrep
{
    public class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int AnimalId { get; set; }

        public Animal(string name, double weight, double height, int animalid)
        {
            Name = name;
            Weight = weight;
            Height = height;
            AnimalId = animalid;
        }
        public override string ToString()
        {
            return string.Format("{0} weighs {1}kg nd is {2}cm tall", Name, Weight, Height);
        }

    }

    public class Owner
    {
        public string Name { get; set; }
        public int OwnerId { get; set; }

        public Owner(string name, int ownerid)
        {
            Name = name;
            OwnerId = ownerid;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            QueryStringArray();
            QueryIntArray();
            Console.ReadLine();
        }

        static void QueryStringArray()
        {
            String[] dogs = { "K 9", "Brian Griffin", "Scooby Doo", "Snoopy", "Pluto", "Charlie B. Barkin", "Old Yeller" };

            var dogQuery = from dog in dogs
                           where dog.Contains(" ")
                           orderby dog descending
                           select dog;

            foreach (var dog in dogQuery)
            {
                Console.WriteLine(dog + " ");
            }
            Console.WriteLine();
        }

        static int[] QueryIntArray()
        {
            int[] nums = {5,10,15, 20, 25, 30, 35, 40, 45, 50};

            var gt20 = from n in nums
                       where n > 20
                       orderby n 
                       select n;

            foreach (var i in gt20)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"Get Type: {gt20.GetType()}");

            var list = gt20.ToList<int>();
            var arrayGT20 = gt20.ToArray();

            nums[0] = 40;

            foreach (var i in gt20)
            {
                Console.WriteLine(i + " ");
            }   
            Console.WriteLine();

            return arrayGT20;
        }
    }
}
