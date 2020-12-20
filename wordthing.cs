using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            int wordAmount;

            string[] wholelottawords = new string[]
            { "Adult", "Aeroplane", "Air", "Aircraft", "Carrier", "Airforce", "Airport", "Album", "Alphabet", "Apple", "Arm", "Army", "Baby", "Backpack", "Balloon", "Banana", "Bank", "Barbecue", "Bathroom", "Bathtub", "Bed", "Bee", "Bible", "Bird", "Bomb", "Book", "Boss", "Bottle", "Bowl", "Box", "Boy", "Brain", "Bridge", "Butterfly", "Button", "Cappuccino", "Car", "Car-race", "Carpet", "Carrot", "Cave", "Chair", "Chess", "Chief", "Child", "Chisel", "Chocolates", "Church", "Circle", "Circus", "Clock", "Clown", "Coffee", "Comet", "Compact", "Compass", "Computer", "Crystal", "Cup", "Cycle", "Data", "Desk", "Diamond", "Dress", "Drill", "Drink", "Drum", "Dung", "Ears", "Earth", "Egg", "Electricity", "Elephant", "Eraser", "Explosive", "Eyes", "Family", "Fan", "Feather", "Festival", "Film", "Finger", "Fire", "Flood", "Light" ,"Flower" ,"Foot" ,"Fork" ,"Freeway" ,"Fruit" ,"Fungus" ,"Game", "Garden" ,"Gas" ,"Gate" ,"Gemstone" ,"Girl" ,"Gloves" ,"God" ,"Grapes" ,"Guitar" ,"Hammer" ,"Hat" ,"Hieroglyph" ,"Highway" ,"Horoscope" ,"Horse" ,"Hose" ,"Ice" ,"Ice-cream" ,"Insect" ,"Jet" ,"fighter" ,"Junk" ,"Kaleidoscope" ,"Kitchen" ,"Knife" ,"Leather" ,"Leg" ,"Library" ,"Liquid" ,"Magnet" ,"Man" ,"Map" ,"Maze" ,"Meat" ,"Meteor" ,"Microscope" ,"Milk" ,"Milkshake" ,"Mist" ,"Money" ,"Monster" ,"Mosquito" ,"Mouth" ,"Nail" ,"Navy" ,"Necklace" ,"Needle" ,"Onion" ,"PaintBrush" ,"Pants" ,"Parachute" ,"Passport" ,"Pebble" ,"Pendulum" ,"Pepper" ,"Perfume" ,"Pillow" ,"Plane" ,"Planet" ,"Pocket" ,"Post-office" ,"Potato" ,"Printer" ,"Prison" ,"Pyramid" ,"Radar" ,"Rainbow" ,"Record" ,"Restaurant" ,"Rifle" ,"Ring" ,"Robot" ,"Rock" ,"Rocket" ,"Roof" ,"Room" ,"Rope" ,"Saddle" ,"Salt" ,"Sandpaper" ,"Sandwich" ,"Satellite" ,"School" ,"Sex" ,"Ship" ,"Shoes" ,"Shop" ,"Shower" ,"Signature" ,"Skeleton" ,"Slave" ,"Snail" ,"Software" ,"Solid" ,"Space" ,"Shuttle" ,"Spectrum" ,"Sphere" ,"Spice" ,"Spiral" ,"Spoon" ,"Sports-car" ,"Spot" ,"Light" ,"Square" ,"Staircase" ,"Star" ,"Stomach" ,"Sun" ,"Sunglasses" ,"Surveyor" ,"Swimming" ,"Pool" ,"Sword" ,"Table" ,"Tapestry" ,"Teeth" ,"Telescope" ,"Television" ,"Tennis" ,"racquet" ,"Thermometer" ,"Tiger" ,"Toilet" ,"Tongue" ,"Torch" ,"Torpedo" ,"Train" ,"Treadmill" ,"Triangle" ,"Tunnel" ,"Typewriter" ,"Umbrella" ,"Vacuum" ,"Vampire" ,"Videotape" ,"Vulture" ,"Water" ,"Weapon" ,"Web" ,"Wheelchair" ,"Window" ,"Woman" ,"Worm" ,"X-ray" };

            Console.Title = "Random Word Generator by GrandmaSocks";

            Console.WriteLine("Welcome to a random word generator");
            Console.WriteLine("Continue?");

            Console.ReadLine();

            Console.Clear();
            
            Console.Write("The Random words are: ");

            for (int i = 0; i < 25; i++)
            {
                Random rand = new Random();
                int index = rand.Next(wholelottawords.Length);
                Console.Write(wholelottawords[index]);
                Console.Write(" ");
            }
        }
    }
}


