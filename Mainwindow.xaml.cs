using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ZooScenario
{
    /// <summary>
    /// Contains interaction logic for MainWindow.xaml.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Event handlers may begin with lower-case letters.")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Field that represents the Como Zoo.
        /// </summary>
        public Zoo ComoZoo;

        /// <summary>
        /// Field that represents the San Diego Zoo.
        /// </summary>
        public Zoo SanDiegoZoo;

        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Creates the Como Zoo and related objects.
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param>
        private void newComoZooButton_Click(object sender, RoutedEventArgs e)
        {
            this.ComoZoo = new Zoo();

            this.ComoZoo.AnimalSnackMachine = new VendingMachine();

            this.ComoZoo.AnimalSnackMachine.FoodPricePerPound = 0.75m;
            this.ComoZoo.AnimalSnackMachine.FoodStock = 250.0;
            this.ComoZoo.AnimalSnackMachine.MoneyBalance = 42.75m;

            this.ComoZoo.BirthArea = new BirthingRoom();

            this.ComoZoo.FeaturedAnimal = new Animal();

            // Assign field values of the birth area.
            this.ComoZoo.BirthArea.Temperature = 77.0;

            this.ComoZoo.BirthArea.Doctor = new Employee();

            this.ComoZoo.BirthArea.Doctor.Name = "Flora";
            this.ComoZoo.BirthArea.Doctor.Number = 98;

            // Assign field values of Como Zoo.
            this.ComoZoo.Capacity = 1000;

            // Assign field values of the featured animal.
            this.ComoZoo.FeaturedAnimal.Age = 4;
            this.ComoZoo.FeaturedAnimal.Gender = "Female";
            this.ComoZoo.FeaturedAnimal.Name = "Dolly";
            this.ComoZoo.FeaturedAnimal.Type = "Dingo";
            this.ComoZoo.FeaturedAnimal.Weight = 35.3;

            // Make animal pregnant.
            this.ComoZoo.FeaturedAnimal.MakePregnant();

            this.ComoZoo.LadiesRoom = new Restroom();
            this.ComoZoo.LadiesRoom.Gender = "Female";
            this.ComoZoo.LadiesRoom.Capacity = 4;

            this.ComoZoo.MensRoom = new Restroom();
            this.ComoZoo.MensRoom.Gender = "Male";
            this.ComoZoo.MensRoom.Capacity = 4;

            this.ComoZoo.Name = "Como Zoo";

            this.ComoZoo.TicketBooth = new Booth();
            this.ComoZoo.TicketBooth.Attendant = new Employee();
            this.ComoZoo.TicketBooth.TicketPrice = 15.00m;

            this.ComoZoo.TicketBooth.Attendant.Name = "Sam";
            this.ComoZoo.TicketBooth.Attendant.Number = 42;

            this.ComoZoo.Visitor = new Guest();
            this.ComoZoo.Visitor.Age = 11;
            this.ComoZoo.Visitor.Name = "Darla";

            this.ComoZoo.Visitor.Wallet = new Wallet();
            this.ComoZoo.Visitor.Wallet.MoneyBalance = 5.25m;
        }

        /// <summary>
        /// Creates the San Diego Zoo and related objects.
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param>
        private void newSanDiegoZooButton_Click(object sender, RoutedEventArgs e)
        {
            this.SanDiegoZoo = new Zoo();

            this.SanDiegoZoo.AnimalSnackMachine = new VendingMachine();

            this.SanDiegoZoo.AnimalSnackMachine.FoodPricePerPound = 1.20m;
            this.SanDiegoZoo.AnimalSnackMachine.FoodStock = 3.5;
            this.SanDiegoZoo.AnimalSnackMachine.MoneyBalance = 56.25m;

            this.SanDiegoZoo.BirthArea = new BirthingRoom();

            this.SanDiegoZoo.FeaturedAnimal = new Animal();

            // Assign field values of the birth area.
            this.SanDiegoZoo.BirthArea.Temperature = 77.0;

            this.SanDiegoZoo.BirthArea.Doctor = new Employee();

            this.SanDiegoZoo.BirthArea.Doctor.Name = "Steve";
            this.SanDiegoZoo.BirthArea.Doctor.Number = 24;

            // Assign field values of SanDiego Zoo.
            this.SanDiegoZoo.Capacity = 3000;

            // Assign field values of the featured animal.
            this.SanDiegoZoo.FeaturedAnimal.Age = 5;
            this.SanDiegoZoo.FeaturedAnimal.Gender = "Female";
            this.SanDiegoZoo.FeaturedAnimal.Name = "Patti";
            this.SanDiegoZoo.FeaturedAnimal.Type = "Platypus";
            this.SanDiegoZoo.FeaturedAnimal.Weight = 3.27;

            this.SanDiegoZoo.LadiesRoom = new Restroom();
            this.SanDiegoZoo.LadiesRoom.Gender = "Female";
            this.SanDiegoZoo.LadiesRoom.Capacity = 12;

            this.SanDiegoZoo.MensRoom = new Restroom();
            this.SanDiegoZoo.MensRoom.Gender = "Male";
            this.SanDiegoZoo.MensRoom.Capacity = 12;

            this.SanDiegoZoo.Name = "San Diego Zoo";

            this.SanDiegoZoo.TicketBooth = new Booth();
            this.SanDiegoZoo.TicketBooth.Attendant = new Employee();
            this.SanDiegoZoo.TicketBooth.TicketPrice = 25.50m;

            this.SanDiegoZoo.TicketBooth.Attendant.Name = "Betty";
            this.SanDiegoZoo.TicketBooth.Attendant.Number = 84;

            this.SanDiegoZoo.Visitor = new Guest();
            this.SanDiegoZoo.Visitor.Age = 13;
            this.SanDiegoZoo.Visitor.Name = "Dave";

            this.SanDiegoZoo.Visitor.Wallet = new Wallet();
            this.SanDiegoZoo.Visitor.Wallet.MoneyBalance = 3.75m;
        }

        private void darlaFeedDingoButton_Click(object sender, RoutedEventArgs e)
        {
            this.ComoZoo.Visitor.FeedAnimal(this.ComoZoo.FeaturedAnimal, this.ComoZoo.AnimalSnackMachine);
        }

        private void daveFeedPlatypusButton_Click(object sender, RoutedEventArgs e)
        {
            this.SanDiegoZoo.Visitor.FeedAnimal(this.SanDiegoZoo.FeaturedAnimal, this.SanDiegoZoo.AnimalSnackMachine);
        }

        private void birthDingoButton_Click(object sender, RoutedEventArgs e)
        {
            this.ComoZoo.BirthAnimal();
        }

        private void birthPlatypusButton_Click(object sender, RoutedEventArgs e)
        {
            this.SanDiegoZoo.BirthAnimal();
        }

        private void floraFillVendingMachineButton_Click(object sender, RoutedEventArgs e)
        {
            this.ComoZoo.BirthArea.Doctor.FillVendingMachine(this.ComoZoo.AnimalSnackMachine);
        }

        private void bettyFillVendingMachineButton_Click(object sender, RoutedEventArgs e)
        {
            this.SanDiegoZoo.TicketBooth.Attendant.FillVendingMachine(this.SanDiegoZoo.AnimalSnackMachine);
        }
    }
}
